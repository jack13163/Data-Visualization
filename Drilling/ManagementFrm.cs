using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using ZedGraph;

namespace Drilling
{
    public partial class ManagementFrm : Form
    {
        //创建绘图控件
        private ZedGraph.ZedGraphControl graph = null;

        public ManagementFrm()
        {
            InitializeComponent(); 
            
            this.graph = new ZedGraph.ZedGraphControl();
            this.SuspendLayout();
            this.Controls.Add(this.graph);
            // 
            // zedGraphControl1
            // 
            this.graph.Location = new System.Drawing.Point(0, 0);
            this.graph.Name = "zedGraphControl1";
            this.graph.Size = new System.Drawing.Size(680, 414);
            this.graph.TabIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            graph.IsShowPointValues = true;
            graph.GraphPane.Title = "Test Case for C#";
            double[] x = new double[100];
            double[] y = new double[100];
            int i;
            for (i = 0; i < 100; i++)
            {
                x[i] = (double)i / 100.0 * Math.PI * 2.0;
                y[i] = Math.Sin(x[i]);
            }
            graph.GraphPane.AddCurve("Sine Wave", x, y, Color.Red, SymbolType.Square);
            graph.AxisChange();
            graph.Invalidate();
        }
    }
}
