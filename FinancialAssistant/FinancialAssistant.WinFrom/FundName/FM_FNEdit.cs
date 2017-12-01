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

namespace FinancialAssistant.WinFrom.FundName

{
    public partial class FM_FNEdit : Form
    {
        private CompanyServices CompanyServices = new CompanyServices();
        private FundNameServices FundNameServices = new FundNameServices();
        public FM_FNEdit()
        {
            InitializeComponent();
        }

        private void BT_Save_Click(object sender, EventArgs e)
        {
            Fund_Name FN = new Fund_Name();
            FN.ID = int.Parse(markTextBox2.Text);
            FN.FundName = markTextBox1.Text;
            FN.CompanyID = int.Parse(ComBox_Company.SelectedValue.ToString());
            if (FundNameServices.Insert(FN))
                this.Close();
            else
                MessageBox.Show("未知错误,请重试！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void FM_FNEdit_Load(object sender, EventArgs e)
        {
            IList<Fund_Company> LFM = CompanyServices.GetData();
            ComBox_Company.DataSource = LFM;
            ComBox_Company.ValueMember = "Id";//实际值
            ComBox_Company.DisplayMember = "CompanyName";//显示值
        }

        private void BT_ESC_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
