using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using ZedGraph;

namespace Chaos
{
    public partial class Form1 : Form
    {
        // Global variables
        LogisticMap logisticMap;
        const string resultsFolder = ".\\Results\\";

        public Form1()
        {
            // Initialize the logistic map object
            logisticMap = new LogisticMap(1);

            // Initialize the graphical user interface
            InitializeComponent();
        }

        /**********************************************************************************
        * buttonMap_Click() Method                                                        *
        * Inputs:                                                                         *
        *     object sender                                                               *
        *     EventArgs e                                                                 *
        *                                                                                 *
        * Outputs                                                                         *
        *     none                                                                        *
        * Returns:                                                                        *
        *     void                                                                        *
        * Description:                                                                    *
        *     Calculates the trajectories of two points starting a distance apart and     *
        *    graphs these trajectories.  The distance between the trajectory points is    *
        *    also graphed and the slope of the exponential region is determined.          *
        **********************************************************************************/
        private void buttonMap_Click(object sender, EventArgs e)
        {
            try
            {
                PointPairList xPoints = new PointPairList();
                PointPairList yPoints = new PointPairList();
                PointPairList lyapunovPoints = new PointPairList();
                PointPairList lyapunovSlopes = new PointPairList();
                TextObj fitLabel = new TextObj();
                bool linearFitted = false;
                bool linearFitNotNaN = false;

                // Set values to user inputs
                double X = Convert.ToDouble(textBoxX.Text);
                double E = Convert.ToDouble(textBoxE.Text);
                double Mu = Convert.ToDouble(textBoxMu.Text);
                double N = Convert.ToInt32(textBoxN.Text);
                double Y = X + E;
                logisticMap.Mu = Mu;

                for (int i = 0; i < N; i++)
                {
                    // Map x into f(x)
                    double fOfX = logisticMap.Map(X);
                    double fOfY = logisticMap.Map(Y);

                    // Add the new point to the list if it is the last point in the sequence
                    if (i == N - 1 || checkBoxWholeTrajectory.Checked)
                    {
                        xPoints.Add(X, fOfX);
                        yPoints.Add(Y, fOfY);
                    }

                    // Add the displacement between f(x) and f(y) to the Lyapunov graph
                    double displacement = Math.Pow((Math.Pow((fOfX-fOfY),2)),0.5);
                    lyapunovPoints.Add(i,Math.Log(displacement));
                    
                    // Find the fit of the linear region of log(displacement) and add it to the Lyapunov graph.
                    if (i == 0)
                    {
                        lyapunovSlopes.Add(lyapunovPoints[0].X, lyapunovPoints[0].Y);
                    }

                    if (N > 1 && (i == N - 1 || lyapunovPoints[i].Y > -2) && !linearFitted)
                    {
                        lyapunovSlopes.Add(lyapunovPoints[i].X, lyapunovPoints[i].Y);

                        // Calculate the equation for the linear fit and make a label for it on the graph
                        double mFit = Math.Round((lyapunovSlopes[1].Y - lyapunovSlopes[0].Y) / (lyapunovSlopes[1].X - lyapunovSlopes[0].X), 2);
                        double bFit = Math.Round((lyapunovSlopes[0].Y - (mFit * lyapunovSlopes[0].X)), 2);
                        string fitEq = "Y = (" + mFit + ") * X + (" + bFit + ")";
                        fitLabel.Text = fitEq;
                        fitLabel.Location.X = 2 * i;
                        fitLabel.Location.Y = lyapunovSlopes[0].Y;
                        fitLabel.Location.AlignH = AlignH.Center;
                        fitLabel.Location.AlignV = AlignV.Bottom;
                        fitLabel.IsClippedToChartRect = true;
                        linearFitted = true;

                        if(mFit != double.NaN && mFit != double.NegativeInfinity && mFit != double.PositiveInfinity)
                        {
                            linearFitNotNaN = true;
                        }
                    }

                    // Use f(x) as the next x value
                    X = fOfX;
                    Y = fOfY;
                }

                GraphPane graphPane = zedGraphControlMap.GraphPane;
                GraphPane lGraphPane = zedGraphControlLyapunov.GraphPane;

                // Clear the old graphs
                graphPane.CurveList.Clear();
                lGraphPane.CurveList.Clear();
                lGraphPane.GraphObjList.Clear();

                // Add the new curves to the graphs
                LineItem xCurve = graphPane.AddCurve("X", xPoints, Color.Red, SymbolType.Circle);
                LineItem yCurve = graphPane.AddCurve("Y (X+E)", yPoints, Color.Blue, SymbolType.XCross);
                LineItem lyanpunovCurve = lGraphPane.AddCurve("Log(displacement)", lyapunovPoints, Color.Red, SymbolType.Circle);
                xCurve.Line.IsVisible = false;
                yCurve.Line.IsVisible = false;

                // If a linear fit was made, display it on the graph
                if (linearFitNotNaN)
                {
                    LineItem lyanpunovSlopeCurve = lGraphPane.AddCurve("Slope of Exponent", lyapunovSlopes, Color.Blue, SymbolType.Circle);
                    lyanpunovSlopeCurve.Line.Width = 5;
                    lGraphPane.GraphObjList.Add(fitLabel);
                }
                else
                {
                    lyapunovSlopes.Clear();
                }

                // Save the data to file if specified
                if (checkBoxSaveToFile.Checked)
                {
                    string fileName = DateTime.Now.Month.ToString() + "_" + DateTime.Now.Day.ToString() + "_" + DateTime.Now.Year.ToString() + "_" + DateTime.Now.Hour.ToString() + "." + DateTime.Now.Minute.ToString() + "." + DateTime.Now.Second.ToString() + "LyapunovExponent.txt";
                    string filePath = resultsFolder + fileName;
                    WriteToTextFile(filePath, lyapunovPoints, lyapunovSlopes);
                }

                // Scale the axises of the graphs and display the new data
                zedGraphControlMap.AxisChange();
                zedGraphControlLyapunov.AxisChange();
                zedGraphControlMap.Invalidate();
                zedGraphControlLyapunov.Invalidate();
            }
            catch (Exception ee)
            {
                MessageBox.Show("An error occured trying to generate the logistic map trajectories.");
            }
        }

        /**********************************************************************************
        * WriteToTextFile() Method                                                        *
        * Inputs:                                                                         *
        *     string filePath                                                             *
        *     double[,] data                                                             *
        *                                                                                 *
        * Outputs                                                                         *
        *     none                                                                        *
        * Returns:                                                                        *
        *     void                                                                        *
        * Description:                                                                    *
        *     Writes the points of the Lyapunov Exponent graph to file.                   *
        **********************************************************************************/

        public void WriteToTextFile(string filePath, PointPairList ldata, PointPairList fdata)
        {
            try
            {
                // Create a StreamWriter for writing the file
                StreamWriter writer = new StreamWriter(filePath, false);

                // If a linear fit has been created, save its data
                if (fdata.Count > 0)
                {
                    // Write the linear fit header
                    writer.WriteLine("Linear Fit");
                    writer.WriteLine("Step #:\tLog(displacement):\t");

                    // Write the linear fit points
                    for (int i = 0; i < fdata.Count; i++)
                    {
                        writer.Write(fdata[i].X);
                        writer.Write("\t");
                        writer.Write(fdata[i].Y);
                        writer.WriteLine();
                    }
                    writer.WriteLine();
                }
                
                // Write the log(displacement) header
                writer.WriteLine("Log(displacement) Data");
                writer.WriteLine("Step #:\tLog(displacement):\t");

                // Write the log(displacement) points
                for (int i = 0; i < ldata.Count; i++)
                {
                    writer.Write(ldata[i].X);
                    writer.Write("\t");
                    writer.Write(ldata[i].Y);
                    writer.WriteLine();
                }

                // Close the file
                writer.Flush();   //flush the buffer text immediately into the text file
                writer.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("An error occured trying to save data to file.");
            }
        }
    }
}
