using FinancialAssistant.Data;
using FinancialAssistant.DoMain.Fund;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialAssistant.Services.Fund
{
    public class Fund_HoldAPositionServices
    {
        public bool Update(Fund_HoldAPosition FN)
        {
            string sql = string.Format("UPDATE Fund_HoldAPosition SET [FundId] = {0},[UnitPrice]={1} WHERE ID={2} ", FN.Quantity,FN.UnitPrice, FN.ID);
            return SqlProcessing.ExeNoQuery(sql);
        }
        public bool Insert(Fund_HoldAPosition FN)
        {
            string sql = string.Format("INSERT INTO Fund_HoldAPosition (ID,Quantity,UnitPrice) VALUES ({0},{1},{2})", FN.ID, FN.Quantity,FN.UnitPrice);
            return SqlProcessing.ExeNoQuery(sql);
        }
    }
}
