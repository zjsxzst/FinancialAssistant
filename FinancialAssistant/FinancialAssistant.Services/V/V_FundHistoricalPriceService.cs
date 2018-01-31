using FinancialAssistant.Data;
using FinancialAssistant.DoMain.V;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialAssistant.Services.V
{
    public class V_FundHistoricalPriceService
    {
        public IList<V_FundHistoricalPrice> GetData(int pageSize, int pageIndex, ref int pageNum,
                                           /* ref int TotalPages,*/ string Where, string OrderBy)
        {
            if (string.IsNullOrWhiteSpace(Where))
                Where = "1=1";
            if (!string.IsNullOrWhiteSpace(OrderBy))
                Where = Where + " Order by " + OrderBy+" desc";
            string sql = GroupSQL.Select(new V_FundHistoricalPrice(), Where);
            return SqlProcessing<V_FundHistoricalPrice>.Paging(sql, pageSize, pageIndex, ref pageNum/*, ref TotalPages*/);
        }
        public int GetCount(string Where)
        {
            string Sql = "SELECT COUNT(*) FROM V_FundHistoricalPrice";
            if (!string.IsNullOrWhiteSpace(Where))
                Sql = Sql + " " + Where;
            return int.Parse(SqlProcessing.ExeQuery(Sql).Rows[0][0].ToString());
        }
    }
}
