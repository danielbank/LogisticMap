LogisticMap
===========

A C# Windows application that plots the spread between two points on a logistic map and calculates the Lyapunov exponent for the spreading.  This project is a solution to Exercise 5.9 from Dr. James Sethna's *Statistical Mechanics: Entropy, Order Parameters, and Complexity* (http://pages.physics.cornell.edu/~sethna/StatMech/EntropyOrderParametersComplexity.pdf).

Installation Instructions:
===========

1. Download the compressed folder from the website by clicking the link 'Download the Application'

2. Unzip the compressed folder and open it.

3. There should be two .dll files in the folder (ZedGraph.dll and ZedGraph.Web.dll).  Do not remove or change the names of these files as doing so will cause problems with the application.

4. Run Chaos.exe.

Application Instructions:
===========

1) To see the spread of two points X and X+E over N steps on a logistic map with constant Mu, enter these values into the Logistic Map control panel and click 'Map It'.

2) The final points of the two trajectories should appear on the graph titled 'Logistic Map'.  To view the log(displacement) between the two points as a function of steps, click over to the 'Lyapunov Exponent' tab. The graph titled 'Lyapunov Exponent' should contain this data if everything went normally.  Some zooming on the graph may be required to view the linear region in the beginning.

3) A linear fit of this line and the equation describing it should also appear on the graph.

4) If the 'Save Data to File' checkbox is clicked, the points of the log(displacement) graph will be written to an text file (it can be opened in Excel for easier perusal).

Graph Instructions:
===========

1) To zoom, click-drag the mouse across the graph to create a rectangular region of interest and release.  Another way to zoom is to use the scroll-wheel on the mouse.

2) To unzoom, right-click on the graph.  A pop-up list of options should appear.  Choose 'Undo All Zoom/Pan' or 'Set Scale to Default'.

3) To move the graph view without changing the zoom, hold the CTRL key and click-drag the mouse across the graph.

4) To view graph points, right-click on the graph.  A pop-up list of options should appear.  Choose 'Show Point Values'.

5) To save a copy of the graph, right-click on the graph.  A pop-up list of options should appear.  Choose 'Save Image As...', browse to a directory, a file name, and click 'Save'.

Credits
===========

Daniel Bank (daniel.p.bank@gmail.com)
Blake Chobanian (blake.chobanian@gmail.com)
October 10th 2013
MIT License
https://github.com/danielbank/RandomWalk/blob/master/LICENSE