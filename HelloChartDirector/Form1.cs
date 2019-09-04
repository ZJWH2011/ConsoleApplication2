using ChartDirector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloChartDirector
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            createChart(this.winChartViewer1, 0);
        }

        public void createChart(WinChartViewer viewer, int chartIndex)
        {
            // The data for the bar chart
            double[] data = { 85, 156, 179.5, 211, 123 };

            // The labels for the bar chart
            string[] labels = { "Mon", "Tue", "Wed", "Thu", "Fri" };

            // Create a XYChart object of size 250 x 250 pixels
            XYChart c = new XYChart(250, 250);

            // Set the plotarea at (30, 20) and of size 200 x 200 pixels
            c.setPlotArea(30, 20, 200, 200);

            // Add a bar chart layer using the given data
            c.addBarLayer(data);

            // Set the labels on the x axis.
            c.xAxis().setLabels(labels);

            // Output the chart
            viewer.Chart = c;

            //include tool tip for the chart
            viewer.ImageMap = c.getHTMLImageMap("clickable", "", "title='{xLabel}: {value} GBytes'");
        }

    }
}
