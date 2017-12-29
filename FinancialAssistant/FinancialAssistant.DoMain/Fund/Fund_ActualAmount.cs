using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialAssistant.DoMain.Fund
{
    public class Fund_ActualAmount
    {
        /// <summary>
        /// 基金号
        /// </summary>
        public string ID { get; set; }
        /// <summary>
        /// 订单号
        /// </summary>
        public string OrderNumber { get; set; }
        /// <summary>
        /// 总金额
        /// </summary>
        public decimal Amount { get; set; }
    }
}
