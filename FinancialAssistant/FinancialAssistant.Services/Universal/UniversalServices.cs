using FinancialAssistant.Data;
using FinancialAssistant.Files;
using FinancialAssistant.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialAssistant.Services.Universal
{
    public class UniversalServices
    {
        /// <summary>
        /// 获取加密方式
        /// </summary>
        /// <param name="Type"></param>
        /// <returns></returns>
        public string SetEADType(int Type)
        {
            switch(Type)
            {
                case 0:
                    return "MD5";
                case 1:
                    return "DES";
                case 2:
                    return "ASC";
                case 3:
                    return "SuperDES";
                case 4:
                    return "SuperASC";
            }

            return string.Empty;
        }
        /// <summary>
        /// 获取获取加密后的内容
        /// </summary>
        /// <param name="Data"></param>
        /// <param name="Type"></param>
        /// <param name="Pwd"></param>
        /// <param name="SIV"></param>
        /// <returns></returns>
        public string SetPsdText(string Data,string Type,string Pwd,string SIV)
        {
            switch(Type)
            {
                case "MD5":
                    return Encryption.TransformationMD5(Data);
                case "DES":
                    return Encryption.DESEncrypt(Data,Pwd,SIV);
                case "ASC":
                    return Encryption.AESEncrypt(Data, Pwd);
                case "SuperDES":
                    return Encryption.SuperEncrypt(Data, Pwd, SIV);
                case "SuperASC":
                    return Encryption.SuperAESEncrypt(Data, Pwd);
            }
            return string.Empty;
        }
        /// <summary>
        /// 初始化Config文件
        /// </summary>
        /// <returns></returns>
        public bool InitConfig()
        {
           try
            {
                SqlData SD = new SqlData();
                SD.connStr = "Data Source=.;Initial Catalog=FinancialAssistant;User ID=sasa;Pwd={0}";
                SD.honeybee = "123456";
                string path = Environment.CurrentDirectory + "\\Config.xml";
                string erro = "";
                SD.connStr = Encryption.SuperEncrypt(SD.connStr, "zjsxzsta", "zjsxzstb");
                SD.honeybee = Encryption.SuperEncrypt(SD.honeybee, "zjsxzsta", "zjsxzstb");
                XmlOperate<SqlData>.Serialize(SD, path, ref erro);
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }
    }
}
