using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FinancialAssistant.Data
{
    public class ReflectClass
    {
        public static string getProperties<T>(T t)
        {
            string tStr = string.Empty;
            if (t == null)
            {
                return tStr;
            }
            PropertyInfo[] properties = t.GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public);

            if (properties.Length <= 0)
            {
                return tStr;
            }
            foreach (PropertyInfo item in properties)
            {
                string name = item.Name;
                object value = item.GetValue(t, null);
                if (item.PropertyType.IsValueType || item.PropertyType.Name.StartsWith("String"))
                {
                    tStr += string.Format("{0}:{1},", name, value);
                }
                else
                {
                    getProperties(value);
                }
            }
            return tStr;
        }
        /// <summary>
        /// 获取实例类所有列名
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <returns></returns>
        public static object[] GetElementNameList<T>(T t)
        {
            ArrayList List = new ArrayList();
            PropertyInfo[] properties = t.GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public);
            foreach (PropertyInfo item in properties)
            {
                //List.Add(item.Name);
                var obs = (DescriptionAttribute[])item.GetCustomAttributes(typeof(DescriptionAttribute), false);//获取自定义特性  
                if(obs.Length>0)
                {
                    if(obs[0].Description!= "None")
                        List.Add(item.Name);
                }
                else
                    List.Add(item.Name);

            }
            return (object[])List.ToArray(typeof(object));
        }
        /// <summary>
        /// 获取实例类所有值
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <returns></returns>
        public static object[] GetElementValueList<T>(T t)
        {
            ArrayList List = new ArrayList();
            PropertyInfo[] properties = t.GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public);
            foreach (PropertyInfo item in properties)
            {
                var obs = (DescriptionAttribute[])item.GetCustomAttributes(typeof(DescriptionAttribute), false);//获取自定义特性  
                if (obs.Length > 0)
                {
                    if (obs[0].Description != "None")
                        List.Add(item.GetValue(t, null));
                }
                else
                    List.Add(item.GetValue(t, null));
                //string a =item.Attributes.ToString();

            }
            return (object[])List.ToArray(typeof(object));
        }
        /// <summary>
        /// 获取完整的实例类数据
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <param name="Name"></param>
        /// <param name="Value"></param>
        /// <returns></returns>
        public static bool GetList<T>(T t,ref ArrayList Name,ref ArrayList Value)
        {
            try
            {
                //ArrayList Names = new ArrayList();
                //ArrayList Values = new ArrayList();
                PropertyInfo[] properties = t.GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public);
                foreach (PropertyInfo item in properties)
                {
                    var obs = (DescriptionAttribute[])item.GetCustomAttributes(typeof(DescriptionAttribute), false);//获取自定义特性  
                    if (obs.Length > 0)
                    {
                        if (obs[0].Description != "None")
                        {
                            Name.Add(item.Name);
                            Value.Add(item.GetValue(t, null));
                        }
                    }
                    else
                    {
                        Name.Add(item.Name);
                        Value.Add(item.GetValue(t, null));
                    }                        
                }
                //Name=(object[])Names.ToArray(typeof(object));
                //Value = (object[])Values.ToArray(typeof(object));
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
           
        }
    }
}
