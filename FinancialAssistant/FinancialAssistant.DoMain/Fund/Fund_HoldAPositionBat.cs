using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialAssistant.DoMain.Fund
{
    public class Fund_HoldAPositionBat
    {
        /// <summary>
        /// 基金号
        /// </summary>
        public string ID { get; set; }
        /// <summary>
        /// 公司ID
        /// </summary>
        public int FundId { get; set; }
        /// <summary>
        /// 单价
        /// </summary>
        public decimal UnitPrice { get; set; }
        /// <summary>
        /// 数量
        /// </summary>
        public decimal Quantity { get; set; }
        /// <summary>
        /// 操作金额
        /// </summary>
        public decimal Monetary { get; set; }
        /// <summary>
        /// 实际金额
        /// </summary>
        /// 
        public decimal ArrivalAmount { get; set; }
        /// <summary>
        /// 操作日期
        /// </summary>
        public DateTime InputDate { get; set; }
        /// <summary>
        /// 持有额度
        /// </summary>
        public decimal Residue { get; set; }
        /// <summary>
        /// 订单编号
        /// </summary>
        public string OrderNumber { get; set; }
        /// <summary>
        /// 类型
        /// </summary>
        public int Type { get; set; }
        /// <summary>
        /// 是否作废
        /// </summary>
        public int InVain { get; set; }
    }
}
