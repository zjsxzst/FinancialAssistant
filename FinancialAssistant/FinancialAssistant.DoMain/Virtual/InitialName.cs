using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace FinancialAssistant.DoMain.Virtual
{
    [XmlRoot("Root")]
    public class InitialName
    {
        public string Key { get; set; }

        public string Value { get; set; }
        public string Type { get; set; }
    }
}
