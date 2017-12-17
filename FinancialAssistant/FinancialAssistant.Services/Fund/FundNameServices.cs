using FinancialAssistant.Data;
using FinancialAssistant.DoMain.Fund;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialAssistant.Services.Fund
{
    public class FundNameServices
    {
        public bool Update(Fund_Name FN)
        {
            string sql = string.Format("UPDATE Fund_Name SET [FundName] = '{0}',[CompanyID]={1} WHERE ID='{2}' ",FN.FundName,FN.CompanyID,FN.ID);
            return SqlProcessing.ExeNoQuery(sql);
        }
        public bool Delete(int Id)
        {
            string sql = string.Format("DELETE FROM Fund_Name Where Id='{0}' ", Id);
            return SqlProcessing.ExeNoQuery(sql);
        }
        public bool Insert(Fund_Name FN)
        {
            string sql = string.Format("INSERT INTO Fund_Name (FundName,CompanyID,ID) VALUES ('{0}',{1},'{2}')", FN.FundName,FN.CompanyID,FN.ID);
            return SqlProcessing.ExeNoQuery(sql);
        }
        public IList<Fund_Name> GetData()
        {
            string sql = "SELECT * FROM Fund_Name";
            return SqlProcessing<Fund_Name>.ExeQuerys(sql);
        }
        public IList<Fund_Name> GetData(string Where)
        {
            string sql = string.Format("SELECT * FROM Fund_Name where {0}", Where);
            return SqlProcessing<Fund_Name>.ExeQuerys(sql);
        }
    }
}
