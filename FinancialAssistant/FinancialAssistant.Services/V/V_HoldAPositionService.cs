using FinancialAssistant.Data;
using FinancialAssistant.DoMain.V;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialAssistant.Services.V
{
    public class V_HoldAPositionService
    {
        public IList<V_HoldAPosition> GetData(int start,int end)
        {
            return SqlProcessing<V_HoldAPosition>.Paging(start,end);
        }
        public int  GetCount()
        {
            string Sql = "SELECT COUNT(*) FROM V_HoldAPosition";
            return int.Parse(SqlProcessing.ExeQuery(Sql).Rows[0][0].ToString());
        }
    }
}
