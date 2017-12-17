using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialAssistant.DoMain.Fund
{
    public class Fund_HoldAPositionBat
    {
        public string ID { get; set; }

        public int FundId { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Quantity { get; set; }
        public DateTime InputDate { get; set; }
        public int Type { get; set; }
    }
}
