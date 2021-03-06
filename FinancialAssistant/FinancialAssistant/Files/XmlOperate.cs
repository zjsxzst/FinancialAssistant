﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
//|------------------------------------------------------------|
//|                    基础信息：                              |
//|     名称：XmlOperate                                       |
//|     功能：Xml操作                                          |
//|     最后修改时间：2017/10/27                               |
//|------------------------------------------------------------|
namespace FinancialAssistant.Files
{
    public class XmlOperate<T> where T : new()
    {
        /// <summary>
        /// 单表序列化
        /// </summary>
        /// <param name="details"></param>
        /// <param name="Ptah"></param>
        static public bool Serialize(T details, string Ptah, ref string erro)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                using (TextWriter writer = new StreamWriter(Ptah))
                {
                    serializer.Serialize(writer, details);
                }
                return true;
            }
            catch (Exception ex)
            {
                erro = ex.ToString();
                return false;
            }
        }
        /// <summary>
        /// 列表序列化
        /// </summary>
        /// <param name="list"></param>
        /// <param name="Ptah"></param>
        public static bool Serialize(List<T> list, string Ptah, ref string erro)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<T>));
                using (TextWriter writer = new StreamWriter(Ptah))
                {
                    serializer.Serialize(writer, list);
                }
                return true;
            }
            catch (Exception ex)
            {
                erro = ex.ToString();
                return false;
            }
        }
        /// <summary>
        /// 单表反序列化
        /// </summary>
        /// <param name="details"></param>
        /// <param name="Ptah"></param>
        /// <param name="erro"></param>
        /// <returns></returns>
        public static bool DSerialize(ref T details, string Ptah, ref string erro)
        {
            try
            {
                XmlSerializer deserializer = new XmlSerializer(typeof(T));
                TextReader reader = new StreamReader(Ptah);
                object obj = deserializer.Deserialize(reader);
                details = (T)obj;
                reader.Close();
                return true;
            }
            catch (Exception ex)
            {
                erro = ex.ToString();
                return false;
            }
        }
        /// <summary>
        /// 列表反序列化
        /// </summary>
        /// <param name="details"></param>
        /// <param name="Ptah"></param>
        /// <param name="erro"></param>
        /// <returns></returns>
        public static bool DSerialize(ref List<T> details, string Ptah, ref string erro)
        {
            try
            {
                XmlSerializer deserializer = new XmlSerializer(typeof(List<T>));
                TextReader reader = new StreamReader(Ptah);
                object obj = deserializer.Deserialize(reader);
                details = (List<T>)obj;
                reader.Close();
                return true;
            }
            catch (Exception ex)
            {
                erro = ex.ToString();
                return false;
            }
        }
    }
}
