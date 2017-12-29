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
        Fund_HoldAPosition Entity = new Fund_HoldAPosition();
        public bool Update(Fund_HoldAPosition FN)
        {
            string sql = GroupSQL.Update(FN, "ID='"+FN.ID+"'");
            return SqlProcessing.ExeNoQuery(sql);
        }
        public IList<Fund_HoldAPosition> GetData(string Id)
        {
            string sql = GroupSQL.Select(Entity, "Id ='" + Id + "'");
            return SqlProcessing<Fund_HoldAPosition>.ExeQuerys(sql);
        }
        public bool Insert(Fund_HoldAPosition FN)
        {
            string sql = GroupSQL.Insert(FN);
            return SqlProcessing.ExeNoQuery(sql);
        }
        public bool Delete(string Id)
        {
            string sql = GroupSQL.Delect(Entity, "Id ='" + Id + "'");
            return SqlProcessing.ExeNoQuery(sql);
        }
    }
}
