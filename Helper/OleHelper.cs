using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.OleDb;

namespace Helper
{
    public class OleHelper
    {
        OleDbConnection oledbConnection = null;

        /// <summary>
        /// 获取excel连接
        /// Extended Properties 关键字设置 Excel 特定的属性。
        /// “HDR=Yes;”指示第一行中包含列名，而不是数据
        /// “IMEX=1;”通知驱动程序始终将“互混”数据列作为文本读取。
        /// Excel 8.0 针对Excel 2000及以上版本，Excel 5.0 针对Excel 97。
        /// Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:/MyExcel.xls;Extended Properties=""Excel 8.0;HDR=Yes;IMEX=1""
        /// </summary>
        /// <param name="filename">excel文件名</param>
        /// <returns>OleDbConnection连接对象</returns>
        public OleDbConnection getConnection(string filename)
        {
            //连接字符串
            string connectionString = "";

            if (filename != null)
            {
                //Excel版本不一样，连接字符串不一样
                if (filename.EndsWith(".xls"))
                {//Excel 2003
                    connectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source =" + filename + "; Extended Properties=Excel 8.0;HDR=Yes";
                }
                else
                {//Excel 2007 up
                    connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + filename + ";Extended Properties=\"Excel 12.0;HDR=No;IMEX=1;\"";
                }
            }

            //创建数据库连接
            oledbConnection = new OleDbConnection(connectionString);
            return oledbConnection;
        }

        /// <summary>
        /// 执行sql查询
        /// </summary>
        /// <param name="sql">sql语句，工作表使用[$]</param>
        /// <param name="paramters"></param>
        /// <returns></returns>
        public DataTable Query(string filename, string sql, params string[] paramters)
        {
            //准备datatable
            DataTable dt = new DataTable();

            //创建数据库连接对象
            getConnection(filename);

            //打开数据库连接
            oledbConnection.Open();

            //创建OleDbCommand对象，用于执行sql语句
            OleDbCommand cmd = new OleDbCommand(sql, oledbConnection) ;
            //获取数据库的索引器
            //执行完成后立即释放索引器
            using (OleDbDataReader oleReader = cmd.ExecuteReader())
            {
                //添加列
                if (oleReader.Read())
                {
                    //获取列数
                    int count = oleReader.FieldCount;

                    //添加列
                    for (int i = 0; i < count; i++)
                    {
                        dt.Columns.Add(oleReader[i].ToString());
                    }
                    
                }

                //循环读取
                while (oleReader.Read())
                {
                    //创建新的行
                    DataRow row = dt.NewRow();

                    //向行中每一列添加元素
                    row[0] = oleReader[0];
                    row[1] = oleReader[1];
                    row[2] = oleReader[2];
                    row[3] = oleReader[3];
                    row[4] = oleReader[4];
                    row[5] = oleReader[5];
                    row[6] = oleReader[6];
                    row[7] = oleReader[7];

                    //向表中添加行
                    dt.Rows.Add(row);
                }
            }
            return dt;
        }

        /// <summary>
        /// 关闭数据库连接
        /// </summary>
        /// <param name="con">待关闭的数据库连接</param>
        /// <returns>执行是否成功</returns>
        public bool closeConnection(OleDbConnection con)
        {
            //判断如果连接未关闭，则关闭
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            return true;
        }
    }
}
