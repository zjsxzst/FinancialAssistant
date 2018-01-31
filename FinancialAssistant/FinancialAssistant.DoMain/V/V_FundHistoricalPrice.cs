using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialAssistant.DoMain.V
{
    public class V_FundHistoricalPrice
    {
        /// <summary>
        /// ID
        /// </summary>
        public string ID { get; set; }
        /// <summary>
        /// 单价
        /// </summary>
        public decimal UnitPrice { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }
        ///<summary>
        ///来源
        /// </summary>
        /// 
        public string Sources { get; set; }
        /// <summary>
        /// 基金号
        /// </summary>
        public string FundID { get; set; }
        /// <summary>
        /// 基金名
        /// </summary>
        public string FundName { get; set; }
        /// <summary>
        /// 基金公司
        /// </summary>
        public string CompanyName { get; set; }
        /// <summary>
        /// 提交日期
        /// </summary>
        public DateTime InputDate { get; set; }
        /// <summary>
        /// 是否作废
        /// </summary>
        public string InVain { get; set; }
    }
}
