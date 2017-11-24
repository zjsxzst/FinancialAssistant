using FinancialAssistant.Data;
using FinancialAssistant.DoMain.Virtual;
using FinancialAssistant.Files;
using FinancialAssistant.Services.Sys;
using FinancialAssistant.Text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialAssistant.WinFrom
{
    public partial class FM_Login : Form
    {
        private UserServices UserServices = new UserServices();
        public FM_Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserServices.VerifyUser(MTB_UserName.Text.Trim(), MTB_PWD.Text.Trim());

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlData SD = new SqlData();
            SD.connStr = "Data Source=.;Initial Catalog=FinancialAssistant;User ID=sasa;Pwd={0}";
            SD.honeybee = "123456";
            string path = Environment.CurrentDirectory + "\\Config.xml";
            string erro = "";
            SD.connStr= Encryption.SuperEncrypt(SD.connStr, "zjsxzsta", "zjsxzstb");
            SD.honeybee = Encryption.SuperEncrypt(SD.honeybee, "zjsxzsta", "zjsxzstb");
            XmlOperate<SqlData>.Serialize(SD, path, ref erro);
        }
    }
}
