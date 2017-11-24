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
    }
}
