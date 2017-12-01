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

namespace FinancialAssistant.WinFrom.HoldAPosition
{
    public partial class FM_HoldAPositionEdit : Form
    {
        FundNameServices FundNameServices = new FundNameServices();
        Fund_HoldAPositionServices Fund_HoldAPositionServices = new Fund_HoldAPositionServices();
        public FM_HoldAPositionEdit()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Fund_HoldAPosition FHAP = new Fund_HoldAPosition();
            FHAP.ID = int.Parse(comboBox1.SelectedValue.ToString());
            FHAP.Quantity = Double.Parse(markTextBox1.Text);
            FHAP.UnitPrice = Double.Parse(markTextBox2.Text);
            Fund_HoldAPositionServices.Insert(FHAP);
            this.Close();
        }

        private void FM_HoldAPositionEdit_Load(object sender, EventArgs e)
        {
            IList<Fund_Name> IFN = FundNameServices.GetData();
            comboBox1.DataSource = IFN;
            comboBox1.ValueMember = "Id";//实际值
            comboBox1.DisplayMember = "FundName";//显示值
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
