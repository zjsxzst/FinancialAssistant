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
        Fund_Company FCD = new Fund_Company();
        int type = 0;
        public FM_FCEdit()
        {
            InitializeComponent();
            type = 1;
        }
        public FM_FCEdit(Fund_Company FC)
        {
            InitializeComponent();
            this.FCD = FC;
            markTextBox1.Text = FC.CompanyName;
        }
        private void BT_Save_Click(object sender, EventArgs e)
        {
            if (type==1)
            {
                Fund_Company FC = new Fund_Company();
                FC.CompanyName = markTextBox1.Text;
                if (CompanyServices.Insert(FC))
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                    
                else
                    MessageBox.Show("未知错误,请重试！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                FCD.CompanyName = markTextBox1.Text.Trim();
                if (CompanyServices.Update(FCD))
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                    MessageBox.Show("未知错误,请重试！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BT_ESC_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FM_FCEdit_Load(object sender, EventArgs e)
        {

        }
    }
}
