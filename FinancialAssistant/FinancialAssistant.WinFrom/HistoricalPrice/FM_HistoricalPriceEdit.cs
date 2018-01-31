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

namespace FinancialAssistant.WinFrom.HistoricalPrice
{
    public partial class FM_HistoricalPriceEdit : Form
    {
        FundNameServices FundNameServices = new FundNameServices();
        Fund_HistoricalPriceServices service = new Fund_HistoricalPriceServices();
        private string ID = string.Empty;
        public FM_HistoricalPriceEdit()
        {
            InitializeComponent();
        }
        public FM_HistoricalPriceEdit(string ID)
        {
            InitializeComponent();
            Fund_HistoricalPrice Data = service.GetEinzelband(ID);
            if (Data != new Fund_HistoricalPrice())
            {
                markTextBox1.Text = Data.UnitPrice.ToString();
                dateTimePicker1.Value = Data.InputDate;
                markTextBox2.Text = Data.Remark;
                this.ID = ID;
                IList<Fund_Name> FS = FundNameServices.GetData();
                if (FS.Count > 0)
                {
                    comboBox1.DataSource = FS;
                    comboBox1.ValueMember = "Id";//实际值
                    comboBox1.DisplayMember = "FundName";//显示值
                    IList<Fund_Name> FTS = FS.Where(m => m.ID == Data.FundID).ToList();

                    if (FTS.Count > 0)
                    {

                        comboBox1.Text = FTS[0].FundName;

                    }

                }
            }
            comboBox1.Enabled = false;
            markTextBox1.Enabled = false;
            dateTimePicker1.Enabled = false;
            //markTextBox2.Enabled = false;
            checkBox1.Enabled = true;
        }
        private void FM_HistoricalPriceEdit_Load(object sender, EventArgs e)
        {
            if (checkBox1.Enabled == false)
            {
                IList<Fund_Name> IFN = FundNameServices.GetData();
                comboBox1.DataSource = IFN;
                comboBox1.ValueMember = "Id";//实际值
                comboBox1.DisplayMember = "FundName";//显示值
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Fund_HistoricalPrice FH = new Fund_HistoricalPrice();
            if(ID==string.Empty)
                FH.ID = Guid.NewGuid().ToString();
            else
                FH.ID = ID;
            FH.UnitPrice = decimal.Parse(markTextBox1.Text);
            FH.InputDate = DateTime.Parse(dateTimePicker1.Text);
            FH.Remark = markTextBox2.Text;
            FH.Sources = 1;
            FH.FundID = comboBox1.SelectedValue.ToString();
            if (checkBox1.CheckState == CheckState.Checked)
                FH.InVain = 1;
            else
                FH.InVain = 0;
            if (checkBox1.Enabled == false)
            {
                if (service.Insert(FH))
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                    MessageBox.Show("未知错误，请重试！", "提示");
            }
            else
            {                
                if (service.Update(FH))
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                    MessageBox.Show("未知错误，请重试！", "提示");
            }

        }
    }
}
