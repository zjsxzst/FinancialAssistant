using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialAssistant.DoMain.Fund
{
    public class Fund_HoldAPosition
    {
        /// <summary>
        /// 基金号
        /// </summary>
        public string ID { get; set; }
        //public int FundId { get; set; }
        /// <summary>
        /// 单价
        /// </summary>
        public decimal UnitPrice { get; set; }
        /// <summary>
        /// 数量
        /// </summary>
        public decimal Quantity { get; set; }
    }
}
