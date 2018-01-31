using FinancialAssistant.Data;
using FinancialAssistant.DoMain.Fund;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialAssistant.Services.Fund
{
    public class Fund_HistoricalPriceServices
    {
        public bool Update(Fund_HistoricalPrice FH)
        {
            string sql = GroupSQL.Update(FH, "ID='"+ FH.ID+"'");
            return SqlProcessing.ExeNoQuery(sql);
        }
        public bool Insert(Fund_HistoricalPrice FH)
        {
            string sql = GroupSQL.Insert(FH);
            return SqlProcessing.ExeNoQuery(sql);
        }
        public Fund_HistoricalPrice GetEinzelband(string ID)
        {
            string sql = GroupSQL.Select(new Fund_HistoricalPrice(), "ID='" + ID + "'");
            IList<Fund_HistoricalPrice> List = SqlProcessing<Fund_HistoricalPrice>.ExeQuerys(sql);
            if (List.Count > 0)
                return List[0];
            else
                return new Fund_HistoricalPrice();
        }
    }
}
