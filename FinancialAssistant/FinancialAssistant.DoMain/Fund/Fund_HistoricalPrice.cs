using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialAssistant.DoMain.Fund
{
    public class Fund_HistoricalPrice
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
        /// 基金号
        /// </summary>
        public string FundID { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }
        /// <summary>
        /// 来源,1=手工输入,2=爬虫
        /// </summary>
        public int Sources{get;set;}
        /// <summary>
        /// 提交日期
        /// </summary>
        public DateTime InputDate { get; set; }
        /// <summary>
        /// 是否作废
        /// </summary>
        public int InVain { get; set; }
    }
}
