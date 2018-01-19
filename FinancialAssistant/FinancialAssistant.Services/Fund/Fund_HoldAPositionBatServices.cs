using FinancialAssistant.Data;
using FinancialAssistant.DoMain.Fund;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialAssistant.Services.Fund
{
    public class Fund_HoldAPositionBatServices
    {
        Fund_HoldAPositionBat Entity = new Fund_HoldAPositionBat();
        //public bool Update(Fund_HoldAPositionBat FN)
        //{
        //    string sql = GroupSQL.Update(FN, "ID='" + FN.ID + "'");
        //    return SqlProcessing.ExeNoQuery(sql);
        //}
        public IList<Fund_HoldAPositionBat> GetData(string Id)
        {
            string sql = GroupSQL.Select(Entity, "Id ='" + Id + "'");
            return SqlProcessing<Fund_HoldAPositionBat>.ExeQuerys(sql);
        }
        public IList<Fund_HoldAPositionBat> GetDataList(string WAO)
        {
            string sql = GroupSQL.Select(Entity, WAO);
            return SqlProcessing<Fund_HoldAPositionBat>.ExeQuerys(sql);
        }
        public bool Insert(Fund_HoldAPositionBat FN)
        {
            string sql = GroupSQL.Insert(FN);
            return SqlProcessing.ExeNoQuery(sql);
        }
        public bool Update(Fund_HoldAPositionBat FB)
        {
            string sql = GroupSQL.Update(FB, "OrderNumber='"+FB.OrderNumber+"'");
            return SqlProcessing.ExeNoQuery(sql);
        }
        public IList<Fund_HoldAPositionBat> GetTop1(string WAO)
        {
            string sql = "SELECT TOP 1 * FROM Fund_HoldAPositionBat ";
            if(!string.IsNullOrWhiteSpace(WAO))
                sql +="where "+ WAO;
            return SqlProcessing<Fund_HoldAPositionBat>.ExeQuerys(sql);
        }
        //public bool Delete(string Id)
        //{
        //    string sql = GroupSQL.Delect(Entity, "Id ='" + Id + "'");
        //    return SqlProcessing.ExeNoQuery(sql);
        //}
    }
}
