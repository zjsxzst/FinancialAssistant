using FinancialAssistant.Data;
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
        Fund_HoldAPositionBatServices Fund_HoldAPositionBatServices = new Fund_HoldAPositionBatServices();
        Fund_HoldAPositionServices Fund_HoldAPositionServices = new Fund_HoldAPositionServices();
        public FM_HoldAPositionEdit()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal Surplus = 0;
            decimal TotalNumber = 0;
            Fund_HoldAPositionBat FHPB = new Fund_HoldAPositionBat();
            FHPB.ID = comboBox1.SelectedValue.ToString();
            
            
            FHPB.UnitPrice= Decimal.Parse(markTextBox2.Text);
            FHPB.InputDate = dateTimePicker1.Value;
            if (RadioSell.Checked)
            {
                //卖出按照份数*单价计算，所得为单价*份数-手续费
                FHPB.Monetary = Decimal.Parse(markTextBox1.Text) * FHPB.UnitPrice;
                FHPB.ArrivalAmount = Decimal.Parse(markTextBox1.Text) * FHPB.UnitPrice * (1 - (decimal.Parse(markTextBox3.Text) / 100));
                FHPB.Type = 2;
            }
               
            if (RadioBuy.Checked)
            {
                //买入按照金额/当天单价计算，得到的份额为(金额-手续费)/单价
                FHPB.Monetary = Decimal.Parse(markTextBox1.Text);               
                FHPB.ArrivalAmount = Decimal.Parse(markTextBox1.Text) * (1 - (decimal.Parse(markTextBox3.Text) / 100));
                FHPB.Type = 1;
            }
               
            IList<Fund_HoldAPositionBat> Top1 = Fund_HoldAPositionBatServices.GetTop1("Residue=0 and Id='" + FHPB.ID + "' order by inputdate desc");
            IList<Fund_HoldAPositionBat> List = new List<Fund_HoldAPositionBat>();
            if (Top1.Count>0)
            {
                DateTime Dt = Top1[0].InputDate;
                List = Fund_HoldAPositionBatServices.GetDataList("inputdate>'" + Dt + "' and Id='"+ FHPB.ID + "' order by inputdate desc");
                
            }
            else
            {
                List = Fund_HoldAPositionBatServices.GetDataList("Id='" + FHPB.ID + "' order by inputdate desc");
            }

            foreach (var item in List)
            {
                //decimal Temp = item.Quantity * item.UnitPrice;
                if (item.Type == 1)
                {
                    //买入按照金额/当天单价计算，得到的份额为(金额-手续费)/单价
                    Surplus += item.ArrivalAmount;
                    TotalNumber += item.Quantity;
                }
                else
                {
                    //卖出按照份数*单价计算，所得为单价*份数-手续费
                    Surplus -= item.Monetary;
                    TotalNumber -= item.Quantity;
                }
            }
            if (FHPB.Type == 1)
            {
                FHPB.Quantity = FHPB.ArrivalAmount / FHPB.UnitPrice;
                Surplus += FHPB.ArrivalAmount;
                TotalNumber += FHPB.Quantity;
            }
            else
            {
                FHPB.Quantity = Decimal.Parse(markTextBox1.Text);
                //操作金额=份数*数量
                Surplus -= FHPB.Monetary;
                TotalNumber -= FHPB.Quantity;
            }
            FHPB.Residue = Surplus;
            
            Fund_HoldAPositionBatServices.Insert(FHPB);
            //decimal prices = 0;
            Fund_HoldAPosition FHAP = new Fund_HoldAPosition();
            FHAP.ID = comboBox1.SelectedValue.ToString();
            FHAP.Quantity = TotalNumber;
            FHAP.UnitPrice = Surplus/ TotalNumber;

            //prices = FHAP.Quantity * FHAP.UnitPrice;
            //if (RadioSell.Checked)
            //    prices = -prices;
            if (Fund_HoldAPositionServices.GetData(FHAP.ID).Count > 0)
                Fund_HoldAPositionServices.Update(FHAP);
            else
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

        private void button3_Click(object sender, EventArgs e)
        {
            List<string> a = SqlProcessing.GetAllTable();
            for(int i=0;i<a.Count;i++)
            {
                List<string> b = SqlProcessing.GetColumns(a[i]);
            }
            //User u = new User();
            //u.name = "ahbool";
            //u.gender = "男";
            //u.DT = DateTime.Now;
            //object[] b=ReflectClass.GetElementNameList(u);
            //object[] c = ReflectClass.GetElementValueList(u);
            //string a = getProperties(u);
        }
        public string getProperties<T>(T t)
        {
            string tStr = string.Empty;
            if (t == null)
            {
                return tStr;
            }
            System.Reflection.PropertyInfo[] properties = t.GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);

            if (properties.Length <= 0)
            {
                return tStr;
            }
            foreach (System.Reflection.PropertyInfo item in properties)
            {
                string name = item.Name;
                object value = item.GetValue(t, null);
                if (item.PropertyType.IsValueType || item.PropertyType.Name.StartsWith("String"))
                {
                    tStr += string.Format("{0}:{1},", name, value);
                }
                else
                {
                    getProperties(value);
                }
            }
            return tStr;
        }

        private void RadioSell_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "份数：";
            markTextBox1.WaterText = "请输入卖出份数";
        }

        private void RadioBuy_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "金额：";
            markTextBox1.WaterText = "请输入购买金额";
            
        }
    }
    public class User
    {
        public string name { get; set; }
        public string gender { get; set; }
        public string age { get; set; }
        public DateTime DT { get; set; }
    }
}
