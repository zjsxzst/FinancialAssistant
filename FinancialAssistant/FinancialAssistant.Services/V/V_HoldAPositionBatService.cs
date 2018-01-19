using FinancialAssistant.Data;
using FinancialAssistant.DoMain.V;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialAssistant.Services.V
{
    public class V_HoldAPositionBatService
    {
        public IList<V_HoldAPositionBat> GetData(int pageSize, int pageIndex, ref int pageNum, string Where/*, ref int TotalPages*/)
        {
            string sql = GroupSQL.Select(new V_HoldAPositionBat(), Where);
            return SqlProcessing<V_HoldAPositionBat>.Paging(sql, pageSize, pageIndex, ref pageNum/*,ref TotalPages*/);
        }
        public int GetCount()
        {
            string Sql = "SELECT COUNT(*) FROM V_HoldAPositionBat";
            return int.Parse(SqlProcessing.ExeQuery(Sql).Rows[0][0].ToString());
        }
    }
}
