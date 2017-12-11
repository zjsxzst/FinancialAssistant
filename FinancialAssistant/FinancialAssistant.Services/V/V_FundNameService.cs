using FinancialAssistant.Data;
using FinancialAssistant.DoMain.V;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialAssistant.Services.V
{
    public class V_FundNameService
    {
        public IList<V_FundName> GetData(int pageSize, int pageIndex, ref int pageNum,
                                           /* ref int TotalPages,*/ string Where, string OrderBy)
        {
            string sql = "select * from V_FundName";
            if (!string.IsNullOrWhiteSpace(Where))
                sql = sql + " " + Where;
            if (!string.IsNullOrWhiteSpace(OrderBy))
                sql = sql + " " + OrderBy;
            return SqlProcessing<V_FundName>.Paging(sql, pageSize, pageIndex, ref pageNum/*, ref TotalPages*/);
        }
        public int GetCount(string Where)
        {
            string Sql = "SELECT COUNT(*) FROM V_FundName";
            if (!string.IsNullOrWhiteSpace(Where))
                Sql = Sql + " " + Where;
            return int.Parse(SqlProcessing.ExeQuery(Sql).Rows[0][0].ToString());
        }
    }
}
