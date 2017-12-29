using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialAssistant.DoMain.V
{
    public class V_HoldAPosition
    {
        /// <summary>
        /// 基金号
        /// </summary>
        public string ID { get; set; }
        /// <summary>
        /// 基金名
        /// </summary>
        public string FundName { get; set; }
        /// <summary>
        /// 单价
        /// </summary>
        public decimal UnitPrice { get; set; }
        /// <summary>
        /// 持有数量
        /// </summary>
        public decimal Quantity { get; set; }
        /// <summary>
        /// 总数
        /// </summary>
        public decimal NUM
        {
            get
            {
                return this.UnitPrice * this.Quantity;
            }
            set { this.NUM = value; }
        }
        /// <summary>
        /// 公司名
        /// </summary>
        public string CompanyName { get; set; }

    }
}
