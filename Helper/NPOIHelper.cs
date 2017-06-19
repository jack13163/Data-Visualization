using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using NPOI.HSSF.UserModel;
using System.IO;
using NPOI.SS.UserModel;
using ZedGraph;

namespace Helper
{
    public class NPOIHelper
    {
        /// <summary>
        /// 读取excel ,默认第一行为标头(获取DataTable)
        /// </summary>
        /// <param name="strFileName">excel文档路径</param>
        /// <returns></returns>
        public DataTable Import(string strFileName)
        {
            DataTable dt = new DataTable();

            HSSFWorkbook hssfworkbook;

            using (FileStream file = new FileStream(strFileName, FileMode.Open, FileAccess.Read))
            {
                hssfworkbook = new HSSFWorkbook(file);
            }
            ISheet sheet = hssfworkbook.GetSheetAt(0);
            System.Collections.IEnumerator rows = sheet.GetRowEnumerator();

            IRow headerRow = sheet.GetRow(0);
            int cellCount = headerRow.LastCellNum;

            for (int j = 0; j < cellCount; j++)
            {
                ICell cell = headerRow.GetCell(j);
                dt.Columns.Add(cell.ToString());
            }

            for (int i = (sheet.FirstRowNum + 1); i <= sheet.LastRowNum; i++)
            {
                IRow row = sheet.GetRow(i);
                DataRow dataRow = dt.NewRow();

                for (int j = row.FirstCellNum; j < cellCount; j++)
                {
                    if (row.GetCell(j) != null)
                    {
                        if (row.GetCell(j).ToString().Contains('/'))
                        {
                            string[] a = row.GetCell(j).ToString().Split('/');

                            dataRow[j] = "20" + a[2] + "-" + a[0] + "-" + a[1];
                        }
                        else
                        {
                            dataRow[j] = row.GetCell(j).ToString();
                        }
                    }
                    else
                    {
                        dataRow[j] = null;
                    }
                }

                dt.Rows.Add(dataRow);
            }
            return dt;
        }

        /// <summary>
        /// DataTable转换为PointPairList
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public PointPairList Translate(DataTable dt)
        {
            ZedGraph.PointPair p ;
            ZedGraph.PointPairList pl = new ZedGraph.PointPairList();
            
            //遍历datatable
            for (int i=0;i<dt.Rows.Count; i++)
            {
                double x = Double.Parse(dt.Rows[0].ToString());
                double y = Double.Parse(dt.Rows[1].ToString());
                p = new PointPair(x,y);
                pl.Add(p);
            }

            return pl;
        }

        /// <summary>
        /// 直接读取出PointPairList
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public PointPairList ReadExcel(string path)
        {
            return Translate(Import(path));
        }
    }
}
