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
        FundNameServices FundNameServices = new FundNameServices();
        CompanyServices CompanyServices = new CompanyServices();
        Fund_Name FN = new Fund_Name();
        IList<Fund_Company> IFC = new List<Fund_Company>();
        bool BZ = true;
        public FM_FNEdit()
        {
            InitializeComponent();
        }
        public FM_FNEdit(Fund_Name FN)
        {
            InitializeComponent();
            markTextBox2.Text = FN.ID.ToString();
            markTextBox1.Text = FN.FundName;
            IFC=CompanyServices.GetData("", "Where Id=" + FN.CompanyID.ToString());
            ComBox_Company.Text = IFC[0].CompanyName;
            //ComBox_Company.SelectedIndex = -1;
            BZ = false;
        }
        private void BT_Save_Click(object sender, EventArgs e)
        {
            Fund_Name FN = new Fund_Name();
            FN.ID =markTextBox2.Text;
            FN.FundName = markTextBox1.Text;
            FN.CompanyID = int.Parse(ComBox_Company.SelectedValue.ToString());
            if(BZ)
            {
                if (FundNameServices.Insert(FN))
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                    MessageBox.Show("未知错误,请重试！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (FundNameServices.Update(FN))
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                    MessageBox.Show("未知错误,请重试！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FM_FNEdit_Load(object sender, EventArgs e)
        {
            IList<Fund_Company> LFM = CompanyServices.GetData();
            ComBox_Company.DataSource = LFM;
            ComBox_Company.ValueMember = "Id";//实际值
            ComBox_Company.DisplayMember = "CompanyName";//显示值
            if(BZ)
                ComBox_Company.SelectedIndex = -1;
            else
                ComBox_Company.Text = IFC[0].CompanyName;
        }

        private void BT_ESC_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
