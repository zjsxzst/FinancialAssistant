using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FinancialAssistant.DoMain.Fund
{
    public class test
    {
        public int Id { get; set; }
        public string L1 { get; set; }
        public string L2{ get; set; }
        public string L3 { get; set; }
        [Description("None")]
        public string L4 { get; set; }
        public string L5 { get; set; }
    }
}
