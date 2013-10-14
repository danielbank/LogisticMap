namespace Chaos
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.buttonMap = new System.Windows.Forms.Button();
            this.textBoxN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxE = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.zedGraphControlMap = new ZedGraph.ZedGraphControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.zedGraphControlLyapunov = new ZedGraph.ZedGraphControl();
            this.textBoxMu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxSaveToFile = new System.Windows.Forms.CheckBox();
            this.checkBoxWholeTrajectory = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "X";
            // 
            // textBoxX
            // 
            this.textBoxX.Location = new System.Drawing.Point(33, 19);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(100, 20);
            this.textBoxX.TabIndex = 2;
            // 
            // buttonMap
            // 
            this.buttonMap.Location = new System.Drawing.Point(525, 17);
            this.buttonMap.Name = "buttonMap";
            this.buttonMap.Size = new System.Drawing.Size(75, 23);
            this.buttonMap.TabIndex = 3;
            this.buttonMap.Text = "Map It";
            this.buttonMap.UseVisualStyleBackColor = true;
            this.buttonMap.Click += new System.EventHandler(this.buttonMap_Click);
            // 
            // textBoxN
            // 
            this.textBoxN.Location = new System.Drawing.Point(285, 19);
            this.textBoxN.Name = "textBoxN";
            this.textBoxN.Size = new System.Drawing.Size(100, 20);
            this.textBoxN.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(265, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "N";
            // 
            // textBoxE
            // 
            this.textBoxE.Location = new System.Drawing.Point(159, 18);
            this.textBoxE.Name = "textBoxE";
            this.textBoxE.Size = new System.Drawing.Size(100, 20);
            this.textBoxE.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(139, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "E";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 96);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(794, 568);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.zedGraphControlMap);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(786, 542);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Logistic Map";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // zedGraphControlMap
            // 
            this.zedGraphControlMap.Location = new System.Drawing.Point(-2, 1);
            this.zedGraphControlMap.Name = "zedGraphControlMap";
            this.zedGraphControlMap.ScrollGrace = 0;
            this.zedGraphControlMap.ScrollMaxX = 0;
            this.zedGraphControlMap.ScrollMaxY = 0;
            this.zedGraphControlMap.ScrollMaxY2 = 0;
            this.zedGraphControlMap.ScrollMinX = 0;
            this.zedGraphControlMap.ScrollMinY = 0;
            this.zedGraphControlMap.ScrollMinY2 = 0;
            this.zedGraphControlMap.Size = new System.Drawing.Size(788, 541);
            this.zedGraphControlMap.TabIndex = 0;
            this.zedGraphControlMap.GraphPane.Title.Text = "Logistic Map";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.zedGraphControlLyapunov);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(786, 542);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Lyapunov Exponent";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // zedGraphControlLyapunov
            // 
            this.zedGraphControlLyapunov.Location = new System.Drawing.Point(-2, 1);
            this.zedGraphControlLyapunov.Name = "zedGraphControlLyapunov";
            this.zedGraphControlLyapunov.ScrollGrace = 0;
            this.zedGraphControlLyapunov.ScrollMaxX = 0;
            this.zedGraphControlLyapunov.ScrollMaxY = 0;
            this.zedGraphControlLyapunov.ScrollMaxY2 = 0;
            this.zedGraphControlLyapunov.ScrollMinX = 0;
            this.zedGraphControlLyapunov.ScrollMinY = 0;
            this.zedGraphControlLyapunov.ScrollMinY2 = 0;
            this.zedGraphControlLyapunov.Size = new System.Drawing.Size(788, 541);
            this.zedGraphControlLyapunov.TabIndex = 1;
            this.zedGraphControlLyapunov.GraphPane.Title.Text = "Lyapunov Exponent";
            this.zedGraphControlLyapunov.GraphPane.XAxis.Title.Text = "Step Number";
            this.zedGraphControlLyapunov.GraphPane.YAxis.Title.Text = "Log(displacement)";
            // 
            // textBoxMu
            // 
            this.textBoxMu.Location = new System.Drawing.Point(419, 19);
            this.textBoxMu.Name = "textBoxMu";
            this.textBoxMu.Size = new System.Drawing.Size(100, 20);
            this.textBoxMu.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(391, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Mu";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(743, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Problem 5.9";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(718, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Blake Chobanian";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(739, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Homework 3";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(756, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "PHY 541";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(741, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Daniel Bank";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxWholeTrajectory);
            this.groupBox1.Controls.Add(this.checkBoxSaveToFile);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxX);
            this.groupBox1.Controls.Add(this.buttonMap);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxN);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxE);
            this.groupBox1.Controls.Add(this.textBoxMu);
            this.groupBox1.Location = new System.Drawing.Point(56, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(656, 70);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Logistic Map Control Panel";
            // 
            // checkBoxSaveToFile
            // 
            this.checkBoxSaveToFile.AutoSize = true;
            this.checkBoxSaveToFile.Checked = true;
            this.checkBoxSaveToFile.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSaveToFile.Location = new System.Drawing.Point(525, 46);
            this.checkBoxSaveToFile.Name = "checkBoxSaveToFile";
            this.checkBoxSaveToFile.Size = new System.Drawing.Size(108, 17);
            this.checkBoxSaveToFile.TabIndex = 11;
            this.checkBoxSaveToFile.Text = "Save Data to File";
            this.checkBoxSaveToFile.UseVisualStyleBackColor = true;
            // 
            // checkBoxWholeTrajectory
            // 
            this.checkBoxWholeTrajectory.AutoSize = true;
            this.checkBoxWholeTrajectory.Location = new System.Drawing.Point(429, 45);
            this.checkBoxWholeTrajectory.Name = "checkBoxWholeTrajectory";
            this.checkBoxWholeTrajectory.Size = new System.Drawing.Size(90, 17);
            this.checkBoxWholeTrajectory.TabIndex = 12;
            this.checkBoxWholeTrajectory.Text = "Plot All Points";
            this.checkBoxWholeTrajectory.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 688);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Logistic Map and Lyapunov Exponent";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.Button buttonMap;
        private System.Windows.Forms.TextBox textBoxN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxE;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private ZedGraph.ZedGraphControl zedGraphControlLyapunov;
        private System.Windows.Forms.TabPage tabPage1;
        private ZedGraph.ZedGraphControl zedGraphControlMap;
        private System.Windows.Forms.TextBox textBoxMu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxSaveToFile;
        private System.Windows.Forms.CheckBox checkBoxWholeTrajectory;
    }
}

