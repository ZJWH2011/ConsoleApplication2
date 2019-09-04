using NPlot;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloEPlot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //this.plotSurface2D1.Clear();

            plot.Clear();//清空
            int[] opens = { 1, 2, 1, 2, 1, 3 };//圆柱底坐标
            double[] closes = { 2, 2, 2, 1, 2, 1 };//圆柱顶坐标
            float[] lows = { 0, 1, 1, 1, 0, 0 };//下线坐标
            System.Int64[] highs = { 3, 2, 3, 3, 3, 4 };//上线坐标
            int[] times = { 0, 1, 2, 3, 4, 5 };//X轴位置
            CandlePlot cp = new CandlePlot();
            cp.CloseData = closes;
            cp.OpenData = opens;
            cp.LowData = lows;
            cp.HighData = highs;
            cp.AbscissaData = times;
            plot.Add(cp);
            plot.AddInteraction(new NPlot.Windows.PlotSurface2D.Interactions.HorizontalDrag());
            plot.AddInteraction(new NPlot.Windows.PlotSurface2D.Interactions.VerticalDrag());
            plot.AddInteraction(new NPlot.Windows.PlotSurface2D.Interactions.AxisDrag(true));

            plot.XAxis1.IncreaseRange(0.1);
            plot.YAxis1.IncreaseRange(0.1); //缩小到合适大小
            plot.Refresh();

        }
    }
}
