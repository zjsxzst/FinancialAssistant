using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialAssistant.Data
{
    /// <summary>
    /// 基础sql组合类
    /// </summary>
    public class GroupSQL
    {
        /// <summary>
        /// 新增
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t">实例类</param>
        /// <returns></returns>
        public static string Insert<T>(T t)
        {
            string[] T_Table = typeof(T).ToString().Split('.');
            string Table = T_Table[T_Table.Length - 1];
            string sql = string.Format("INSERT INTO {0} VALUES (", Table);
            object[] List = ReflectClass.GetElementValueList(t);
            for(int i=0;i<List.Length;i++)
            {
                if(i<List.Length-1)
                    sql += string.Format("'{0}',", List[i]);
                else
                    sql += string.Format("'{0}')", List[i]);
            }
            return sql;
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t">实例类</param>
        /// <param name="Where">筛选条件</param>
        /// <returns></returns>
        public static string Update<T>(T t,string Where)
        {
            string[] T_Table = typeof(T).ToString().Split('.');
            string Table = T_Table[T_Table.Length - 1];
            string sql = string.Format("UPDATE {0} SET ", Table);
            ArrayList Name=new ArrayList(),Value=new ArrayList();
            ReflectClass.GetList(t, ref Name, ref Value);
            object[] NameList= (object[])Name.ToArray(typeof(object));
            object[] ValueList = (object[])Value.ToArray(typeof(object));
            
            for (int i = 0; i < NameList.Length; i++)
            {
                if (i < NameList.Length - 1)
                    sql += string.Format("{0}='{1}',", NameList[i], ValueList[i]);
                else
                    sql += string.Format("{0}='{1}'", NameList[i], ValueList[i]);
            }
            if (!string.IsNullOrWhiteSpace(Where))
                sql += " Where " + Where;
            return sql;
        }
        /// <summary>
        /// 查询
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t">实例类</param>
        /// <param name="Where">筛选条件</param>
        /// <returns></returns>
        public static string Select<T>(T t,string Where)
        {
            string sql = string.Format("select * From {0}", SqlProcessing.GetT(t));
            if (!string.IsNullOrWhiteSpace(Where))
                sql += " Where " + Where;
            return sql;
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t">实例类</param>
        /// <param name="Where">筛选条件</param>
        /// <returns></returns>
        public static string Delect<T>(T t,string Where)
        {
            string sql = string.Format("Delect * From {0}", SqlProcessing.GetT(t));
            if (!string.IsNullOrWhiteSpace(Where))
                sql += " Where " + Where;
            return sql;
        }
    }
}
