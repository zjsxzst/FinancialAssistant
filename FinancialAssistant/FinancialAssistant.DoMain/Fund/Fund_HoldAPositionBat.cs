using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialAssistant.DoMain.Fund
{
    public class Fund_HoldAPositionBat
    {
        public int ID { get; set; }

        public int FundId { get; set; }
        public double UnitPrice { get; set; }
        public double Quantity { get; set; }
        public int Type { get; set; }
    }
}
