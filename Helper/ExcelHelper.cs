using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Office.Interop.Excel;
using System.IO;
using System.Reflection;
using System.Diagnostics;
using ZedGraph;

namespace Helper
{
    /// <summary>
    /// 通过excel获取数据
    /// </summary>
    public class ExcelHelper
    {
        //定义缺省值
        private object missing = Missing.Value;
        //创建excel程序
        private Application app = new Application();
        //工作簿集合对象
        Workbooks wbs = null;
        //工作簿
        Workbook wb = null;

        public ExcelHelper() { }

        /// <summary>
        /// 根据数据的excel文件的路径，获取点击数据
        /// 注意：excel中B列为X的值，C列为Y的值，且，第一列不算
        /// </summary>
        /// <param name="path">文件路径</param>
        /// <returns>点集</returns>
        public ZedGraph.PointPairList getData(string path)
        {
            ZedGraph.PointPair p = new ZedGraph.PointPair();
            ZedGraph.PointPairList pl = new ZedGraph.PointPairList();

            if (app != null)
            {
                //创建工作簿集合对象
                wbs = app.Workbooks;
                //进程不可见
                app.Visible = false;
                //以只读方式打开excel文件
                Workbook wb = app.Application.Workbooks.Open(path, missing, true, missing, missing, missing,
                 missing, missing, missing, true, missing, missing, missing, missing, missing);
                //取得第一个工作薄
                Worksheet ws = (Worksheet)wb.Worksheets.get_Item(1);

                //取得总记录行数   (包括标题列)
                int rowsint = ws.UsedRange.Cells.Rows.Count; //得到行数
                //int columnsint = mySheet.UsedRange.Cells.Columns.Count;//得到列数

                //取得数据范围区域 (不包括标题列) 
                Range rng1 = ws.Cells.get_Range("B2", "B" + rowsint);
                Range rng2 = ws.Cells.get_Range("C2", "C" + rowsint);
                //获取该范围内的数据
                object[,] arryItem = (object[,])rng1.Value2;
                object[,] arryCus = (object[,])rng2.Value2;
                //处理这个二纬数组
                for (int i = 1; i <= rowsint - 1; i++)
                {
                    //第一列
                    p.X = Double.Parse(arryItem[i, 1].ToString());
                    //第二列
                    p.Y = Double.Parse(arryCus[i, 1].ToString());
                    //添加到点集合中
                    pl.Add(p);
                }
            }
            //不显示提示
            app.DisplayAlerts = false;
            //退出
            Quit();
            return pl;
        }

        /// <summary>
        /// 退出excel应用程序
        /// </summary>
        /// <param name="excel"></param>
        public void Quit()
        {
            app.Quit(); 
            app = null;
            Process[] procs = Process.GetProcessesByName("excel");


            foreach (Process pro in procs)
            {
                pro.Kill();//没有更好的方法,只有杀掉进程
            }
            GC.Collect();
        }

        /// <summary>
        /// 获取excel中的
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public PointPairList[] getDataOnce(string path)
        {
            PointPairList[] plArray = new PointPairList[4];
            ZedGraph.PointPair p1 = new ZedGraph.PointPair();
            ZedGraph.PointPair p2 = new ZedGraph.PointPair();
            ZedGraph.PointPair p3 = new ZedGraph.PointPair();
            ZedGraph.PointPair p4 = new ZedGraph.PointPair();
                        
            if (app != null)
            {
                //创建工作簿集合对象
                wbs = app.Workbooks;
                //进程不可见
                app.Visible = false;
                //以只读方式打开excel文件
                Workbook wb = app.Application.Workbooks.Open(path, missing, true, missing, missing, missing,
                 missing, missing, missing, true, missing, missing, missing, missing, missing);
                //取得第一个工作薄
                Worksheet ws = (Worksheet)wb.Worksheets.get_Item(1);

                //取得总记录行数   (包括标题列)
                int rowsint = ws.UsedRange.Cells.Rows.Count; //得到行数
                //int columnsint = mySheet.UsedRange.Cells.Columns.Count;//得到列数

                //取得数据范围区域 (不包括标题列) 
                Range rng1 = ws.Cells.get_Range("B2", "B" + rowsint);
                Range rng2 = ws.Cells.get_Range("C2", "C" + rowsint);
                
                Range rng3 = ws.Cells.get_Range("D2", "D" + rowsint);
                Range rng4 = ws.Cells.get_Range("E2", "E" + rowsint);

                Range rng5 = ws.Cells.get_Range("F2", "F" + rowsint);
                Range rng6 = ws.Cells.get_Range("G2", "G" + rowsint);

                Range rng7 = ws.Cells.get_Range("H2", "H" + rowsint);
                Range rng8 = ws.Cells.get_Range("I2", "I" + rowsint);

                //获取该范围内的数据
                object[,] arryItem1 = (object[,])rng1.Value2;
                object[,] arryCus1 = (object[,])rng2.Value2;

                object[,] arryItem2 = (object[,])rng3.Value2;
                object[,] arryCus2 = (object[,])rng4.Value2;

                object[,] arryItem3 = (object[,])rng5.Value2;
                object[,] arryCus3 = (object[,])rng6.Value2;

                object[,] arryItem4 = (object[,])rng7.Value2;
                object[,] arryCus4 = (object[,])rng8.Value2;

                //创建点集
                for (int i = 0; i < 4;i++ )
                {
                    plArray[i] = new PointPairList();
                }

                //处理这个二纬数组
                for (int i = 1; i <= rowsint - 1; i++)
                {
                    //第一列
                    p1.X = Double.Parse(arryItem1[i, 1].ToString());
                    //第二列
                    p1.Y = Double.Parse(arryCus1[i, 1].ToString());
                    //添加到点集合中
                    plArray[0].Add(p1);

                    //第一列
                    p2.X = Double.Parse(arryItem2[i, 1].ToString());
                    //第二列
                    p2.Y = Double.Parse(arryCus2[i, 1].ToString());
                    //添加到点集合中
                    plArray[1].Add(p2);

                    //第一列
                    p3.X = Double.Parse(arryItem3[i, 1].ToString());
                    //第二列
                    p3.Y = Double.Parse(arryCus3[i, 1].ToString());
                    //添加到点集合中
                    plArray[2].Add(p3);

                    //第一列
                    p4.X = Double.Parse(arryItem4[i, 1].ToString());
                    //第二列
                    p4.Y = Double.Parse(arryCus4[i, 1].ToString());
                    //添加到点集合中
                    plArray[3].Add(p4);
                }
            }

            //不显示提示
            app.DisplayAlerts = false;

            return plArray;
        }
    }
}
