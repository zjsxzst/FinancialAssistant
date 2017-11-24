using FinancialAssistant.Data;
using FinancialAssistant.DoMain.Sys;
using FinancialAssistant.Services.Universal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialAssistant.Services.Sys
{
    public class UserServices
    {
        private UniversalServices UniversalServices=new UniversalServices();
        public bool VerifyUser(string UserName, string Pwd)
        {
            string sql = string.Format("SELECT * FROM Sys_User where UserName={0}", UserName);
            IList<User> IUser = SqlProcessing<User>.ExeQuerys(sql);
            if (IUser.Count > 0)
            {
                string Type = UniversalServices.SetEADType(IUser[0].Type);
                string Pwd_Temp = UniversalServices.SetPsdText(Pwd, Type, "qwertyuiop", "zxcvbnmv");
                if (IUser[0].UserPWD == Pwd_Temp)
                    return true;
                else
                    return false;
            }
               
            else
                return false;
        }
    }
}
