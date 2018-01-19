using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        /// 持仓数量
        /// </summary>
        public decimal Quantity { get; set; }
        /// <summary>
        /// 公司名
        /// </summary>
        public string CompanyName { get; set; }
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
        /// 订单号
        /// </summary>
        public string OrderNumber { get; set; }
        /// <summary>
        /// 操作日期
        /// </summary>
        public DateTime InputDate { get; set; }
        /// <summary>
        /// 持有额度
        /// </summary>
        public decimal Residue { get; set; }
        /// <summary>
        /// 类型
        /// </summary>
        public int Type { get; set; }
        /// <summary>
        /// 是否作废
        /// </summary>
        public int InVain { get; set; }
        ///<summary>
        ///类型中文名
        ///</summary>
        public string TypeName { get; set; }
        ///<summary>
        ///作废中文名
        /// </summary>
        public string InVainName { get; set; }

    }
}
