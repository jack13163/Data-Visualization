using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using ZedGraph;
using System.Collections;
using Helper;

namespace Drilling
{
    public partial class DrawFrm : Form
    {
        //创建ZedGraphControl绘图控件
        private ZedGraph.ZedGraphControl[] graphControlArray = null;

        //读取excel文件
        ExcelHelper eh = new ExcelHelper();

        public DrawFrm()
        {
            //初始化
            InitializeComponent();
            //创建绘图控件
            graphControlArray = initGraphControl();
            //将创建好的绘图控件放到容器中
            putIntoContainer(graphControlArray);

            this.SuspendLayout();
        }

        /// <summary>
        /// 将控件按照先上后下，先左后右的顺序放到容器中
        /// </summary>
        /// <param name="gcArray"></param>
        private void putIntoContainer(ZedGraphControl[] gcArray)
        {
            //将绘图控件装入到容器中
            this.gb_Left_Top.Controls.Add(gcArray[0]);
            this.gb_Right_Top.Controls.Add(gcArray[1]);
            this.gb_Left_Buttom.Controls.Add(gcArray[2]);
            this.gb_Right_Buttom.Controls.Add(gcArray[3]);
        }

        /// <summary>
        /// 清空容器
        /// </summary>
        private void clearContainer()
        {
            //将容器清空
            this.gb_Left_Top.Controls.Clear();
            this.gb_Right_Top.Controls.Clear();
            this.gb_Left_Buttom.Controls.RemoveAt(0);
            this.gb_Right_Buttom.Controls.RemoveAt(0);
        }

        /// <summary>
        /// 一次性创建并初始化四个绘图控件
        /// </summary>
        /// <returns>ZedGraphControl</returns>
        private ZedGraphControl[] initGraphControl()
        {
            ZedGraphControl[] gcArray = new ZedGraphControl[4];
            //循环创建并初始化四个绘图控件
            for (int i = 0; i < gcArray.Length; i++)
            {
                gcArray[i] = new ZedGraphControl();
                // 设置画板的大小
                gcArray[i].Location = new System.Drawing.Point(5, 15);
                gcArray[i].Size = new System.Drawing.Size(480, 240);
            }
            return gcArray;
        }

        private void tsbtnStart_Click(object sender, EventArgs e)
        {
            //清空容器
            clearContainer();

            //将控件添加到容器中
            putIntoContainer(graphControlArray);

            string xlabel = "井深";
            //获取数据
            PointPairList[] array = eh.getDataOnce("F:/C#/Drilling/Drilling/file/01.xlsx");

            //初始化画板
            preparePain(graphControlArray[0], "钻盘转速", xlabel, "钻盘钻速", 0, 700, 0, 700);
            preparePain(graphControlArray[1], "钻压", xlabel, "钻压", 0, 700, 0, 500);
            preparePain(graphControlArray[2], "扭矩", xlabel, "扭矩", 0, 700, 0, 100);
            preparePain(graphControlArray[3], "钻速", xlabel, "钻速", 0, 700, 0, 20);

            //绘图
            pain(graphControlArray[0], "钻盘钻速", array[0]);
            pain(graphControlArray[1], "钻压", array[1]);
            pain(graphControlArray[2], "扭矩", array[2]);
            pain(graphControlArray[3], "钻速", array[3]);
        }

        /// <summary>
        /// 初始化画板，为点的绘制做准备，主要是设置初始化坐标系
        /// </summary>
        /// <param name="graphControl">画板</param>
        /// <param name="title">标题</param>
        /// <param name="xlabel">x轴标签</param>
        /// <param name="ylabel">y轴标签</param>
        private void preparePain(ZedGraphControl graphControl, string title, string xlabel, string ylabel, int xmin, int xmax, int ymin, int ymax)
        {
            //获取画板,每个控件所画图形不同，所以需要单独来绘制
            GraphPane gp = graphControl.GraphPane;
            //显示点的值
            graphControl.IsShowPointValues = true;
            //显示显示虚线
            gp.XAxis.IsShowMinorGrid = false;
            

            //设置坐标系
            //设置标签值
            gp.Title = title;
            gp.XAxis.Title = xlabel;
            gp.YAxis.Title = ylabel;
            //设置坐标轴的最小、最大值和刻度值
            gp.XAxis.Min = xmin;
            gp.XAxis.Max = xmax;
            gp.XAxis.MinorStep = 50;
            gp.YAxis.Min = ymin;
            gp.YAxis.Max = ymax;
            gp.YAxis.MinorStep = 50;
        }

        /// <summary>
        /// 在画板上绘图
        /// </summary>
        /// <param name="graphControl">绘图控件</param>
        /// <param name="columnName">系列名</param>
        /// <param name="list">点集合</param>
        private void pain(ZedGraphControl graphControl, string columnName, PointPairList list)
        {
            //添加曲线
            //去除点使用SymbolType.None
            LineItem li = graphControl.GraphPane.AddCurve(columnName, list, Color.Blue, SymbolType.None);
            
            //改变横轴和纵轴
            graphControl.AxisChange();
            //重绘
            graphControl.Refresh();
        }

        /// <summary>
        /// 窗口关闭时关闭所有打开的excel应用程序
        /// </summary>
        private void DrawFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            eh.Quit();
        }

        /// <summary>
        /// 设置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DrawFrm_Resize(object sender, EventArgs e)
        {
            //通过设置最外层的控件的大小，同时设置上下左右拉伸，实现控件的大小动态改变
            this.panelMainContainer.Width = this.Width -20;
            this.panelMainContainer.Height = this.Height - 70;

            //设置绘图的尺寸
            for (int i = 0; i < graphControlArray.Length;i++ )
            {
                graphControlArray[i].Width = this.Width / 2 - 50;
                graphControlArray[i].Height = this.Height / 2 - 130;
            }
        }
    }
}
