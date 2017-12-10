using FinancialAssistant.Files;
using FinancialAssistant.Table;
using FinancialAssistant.Text;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialAssistant.Data
{
    /// <summary>
    /// 错误的写法，暂时找不到更好的方式
    /// </summary>
    public class SqlData
    {
        /// <summary>
        /// 连接字符串
        /// </summary>
        public string connStr { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        public string honeybee { get; set; }
    }
    public class SqlProcessing<T> where T : new()
    {
        //public static string Flie_Path = System.IO.Directory.GetCurrentDirectory() + "\\Data\\DATA.accdb";//当前路径
        public static string PassWD = null;//获取数据库密码
        private static DataTable dt;
        private static string connStr;//= String.Format("Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0}; Jet OLEDB:Database Password ={1}", Flie_Path, PassWD);//;
        private static SqlConnection con = new SqlConnection(connStr);   // TODO: 在此处添加构造函数逻辑

        public static object TextProcessing { get; private set; }

        private static void Init()
        {
            SqlData sd = new SqlData();
            string data = "";
            XmlOperate<SqlData>.DSerialize(ref sd, "Config.xml", ref data);
            PassWD = Encryption.SuperDesDecrypt(sd.honeybee, "zjsxzsta", "zjsxzstb");
            connStr = String.Format(Encryption.SuperDesDecrypt(sd.connStr, "zjsxzsta", "zjsxzstb"), PassWD);
            con = new SqlConnection(connStr);
            //SqlProcessing<SqlData>.Init(sd.connStr, sd.honeybee);
        }
        private static DataTable ExeQuery(String sql)//查询
        {
            Init();
            //if (con.State == ConnectionState.Closed)
            //    con.Open();
            SqlDataAdapter oda = new SqlDataAdapter(sql, con);
            dt = new DataTable();
            oda.Fill(dt);
            con.Close();
            return dt;
        }
        public static IList<T> ExeQuerys(string sql)
        {
            Init();
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlDataAdapter cmd = new SqlDataAdapter(sql, con);
            dt = new DataTable();
            cmd.Fill(dt);
            con.Close();
            if (dt.Rows.Count > 0)
                return Transform<T>.DataTableToList(dt);
            return new List<T>();
        }
        /// <summary>
        /// 获取当前表
        /// </summary>
        /// <returns></returns>
        private static string GetT()
        {
            string[] Temp = typeof(T).ToString().Split('.');
            return Temp[Temp.Length - 1];
        }
        /// <summary>
        /// 基础分页
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="pageSize">单页大小</param>
        /// <param name="pageIndex">当前页数</param>
        /// <param name="pageNum">当前页条数</param>
        /// <returns></returns>
        public static IList<T> PagingBase(string sql, int pageSize, int pageIndex, ref int pageNum)
        {
            DataTable dt = new DataTable();
            Init();
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlDataAdapter oda = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            pageNum = oda.Fill(ds, pageSize * (pageIndex - 1), pageSize, "Page");
            dt = ds.Tables["Page"];
            if (dt.Rows.Count > 0)
                return Transform<T>.DataTableToList(dt);
            return new List<T>();
        }
        /// <summary>
        /// 获取总数
        /// </summary>
        /// <param name="Table"></param>
        /// <param name="Where"></param>
        /// <param name="OrderBy"></param>
        /// <returns></returns>
        /// 
        public static int TotalPage(string sql)
        {
            sql = sql.Replace("*", "Count(*) as counts");
            DataTable DT = ExeQuery(sql);
            return int.Parse(DT.Rows[0]["counts"].ToString());
        }
        /// <summary>
        /// 分页
        /// </summary>
        /// <param name="Sql"></param>
        /// <param name="pageSize">单页大小</param>
        /// <param name="pageIndex">当前页数</param>
        /// <param name="pageNum">当前页条数</param>
        /// <param name="TotalPages">总条数</param>
        /// <returns></returns>
        public static IList<T> Paging(string Sql, int pageSize, int pageIndex, ref int pageNum, ref int TotalPages)
        {
            TotalPages = TotalPage(Sql) / pageSize;
            return PagingBase(Sql, pageSize, pageIndex, ref pageNum);
        }
    }
    public class SqlProcessing
    {
        //public static string Flie_Path = System.IO.Directory.GetCurrentDirectory() + "\\Data\\DATA.accdb";//当前路径
        public static string PassWD = null;//获取数据库密码
        private static DataTable dt;
        private static string connStr;//= String.Format("Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0}; Jet OLEDB:Database Password ={1}", Flie_Path, PassWD);//;
        private static SqlConnection con = new SqlConnection(connStr);   // TODO: 在此处添加构造函数逻辑
        private static void Init()
        {
            SqlData sd = new SqlData();
            string data = "";
            XmlOperate<SqlData>.DSerialize(ref sd, "Config.xml", ref data);
            PassWD = Encryption.SuperDesDecrypt(sd.honeybee, "zjsxzsta", "zjsxzstb");
            connStr = String.Format(Encryption.SuperDesDecrypt(sd.connStr, "zjsxzsta", "zjsxzstb"), PassWD);
            con = new SqlConnection(connStr);
            //SqlProcessing<SqlData>.Init(sd.connStr, sd.honeybee);
        }

        public static DataTable ExeQuery(String sql)//查询
        {
            Init();
            //if (con.State == ConnectionState.Closed)
            //    con.Open();
            SqlDataAdapter oda = new SqlDataAdapter(sql, con);
            dt = new DataTable();
            oda.Fill(dt);
            con.Close();
            return dt;
        }
        public static bool ExeNoQuery(String sql)//添加、修改、删除
        {
            Init();
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            if (cmd.ExecuteNonQuery() > 0)
            {
                con.Close();
                return true;
            }
            else
            {
                con.Close();
                return false;
            }
        }
        public static bool DiaoYongShiWu(String[] sql)//事务调用
        {
            Init();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlTransaction trans = con.BeginTransaction(IsolationLevel.ReadCommitted);
            SqlCommand cmd = new SqlCommand();
            cmd.Transaction = trans;
            cmd.Connection = con;
            try
            {
                foreach (String s in sql)
                {
                    cmd.CommandText = s;
                    cmd.ExecuteNonQuery();
                }
                trans.Commit();
                con.Close();
                return true;
            }
            catch (Exception e)
            {
                trans.Rollback();
                con.Close();
                return false;
            }
        }
        /// <summary>
        /// 基础分页
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="pageSize">单页大小</param>
        /// <param name="pageIndex">当前页数</param>
        /// <param name="pageNum">当前页条数</param>
        /// <returns></returns>
        public static DataTable PagingBase(string sql, int pageSize, int pageIndex,ref int pageNum)
        {
            DataTable dt = new DataTable();
            Init();
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlDataAdapter oda = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            pageNum=oda.Fill(ds, pageSize * (pageIndex - 1), pageSize, "Page");
            dt = ds.Tables["Page"];
            return dt;
        }
        /// <summary>
        /// 获取总数
        /// </summary>
        /// <param name="Table"></param>
        /// <param name="Where"></param>
        /// <param name="OrderBy"></param>
        /// <returns></returns>
        public static int TotalPage(string Sql)
        {
            Sql = Sql.Replace("*", "Count(*) as counts");
            DataTable DT= ExeQuery(Sql);
            return int.Parse(DT.Rows[0]["counts"].ToString());
        }
        /// <summary>
        /// 分页
        /// </summary>
        /// <param name="Sql"></param>
        /// <param name="pageSize">单页大小</param>
        /// <param name="pageIndex">当前页数</param>
        /// <param name="pageNum">当前页条数</param>
        /// <param name="TotalPages">总条数</param>
        /// <returns></returns>
        public static DataTable DTPaging(string Sql, int pageSize, int pageIndex, ref int pageNum,ref int TotalPages)
        {        
            TotalPages = TotalPage(Sql) / pageSize;
            return PagingBase(Sql, pageSize, pageIndex, ref pageNum);
        }

    }
}
