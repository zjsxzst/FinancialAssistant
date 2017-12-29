using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialAssistant.DoMain.V
{
    public class V_HoldAPositionBat
    {
        /// <summary>
        /// id
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// 基金名
        /// </summary>
        public string FundName { get; set; }
        /// <summary>
        /// 单价
        /// </summary>
        public double UnitPrice { get; set; }
        /// <summary>
        /// 持仓数量
        /// </summary>
        public double Quantity { get; set; }
        /// <summary>
        /// 公司名
        /// </summary>
        public string CompanyName { get; set; }
    }
}
