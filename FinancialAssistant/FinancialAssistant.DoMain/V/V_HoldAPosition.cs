using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialAssistant.DoMain.V
{
    public class V_HoldAPosition
    {
        public string ID { get; set; }

        public string FundName { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Quantity { get; set; }
        public string NUM
        {
            get
            {
                return (this.UnitPrice * this.Quantity).ToString("f2");
            }
            set { this.NUM = value; }
        }
        public string CompanyName { get; set; }

    }
}
