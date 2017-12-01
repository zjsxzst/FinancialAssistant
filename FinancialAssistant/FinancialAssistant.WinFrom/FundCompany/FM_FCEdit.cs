using FinancialAssistant.DoMain.Fund;
using FinancialAssistant.Services.Fund;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialAssistant.WinFrom.FundCompany
{
    public partial class FM_FCEdit : Form
    {
        CompanyServices CompanyServices = new CompanyServices();
        public FM_FCEdit()
        {
            InitializeComponent();
        }

        private void BT_Save_Click(object sender, EventArgs e)
        {
            Fund_Company FC = new Fund_Company();
            FC.CompanyName = markTextBox1.Text;
            if (CompanyServices.Insert(FC))
                this.Close();
            else
                MessageBox.Show("未知错误,请重试！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void BT_ESC_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
