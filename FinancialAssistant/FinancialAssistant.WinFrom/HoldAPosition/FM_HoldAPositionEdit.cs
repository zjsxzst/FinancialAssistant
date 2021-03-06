﻿using FinancialAssistant.Data;
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
        string OrderNumber = string.Empty;

        public FM_HoldAPositionEdit()
        {
            InitializeComponent();
        }
        public FM_HoldAPositionEdit(Fund_HoldAPositionBat FB,string CompanyName)
        {
            InitializeComponent();
            comboBox1.Text = CompanyName;
            markTextBox1.Text = FB.ArrivalAmount.ToString();
            markTextBox2.Text = FB.UnitPrice.ToString();
            dateTimePicker1.Text = FB.InputDate.ToString();
            decimal a = ((FB.Monetary / FB.ArrivalAmount)-1);
            markTextBox3.Text = (((FB.Monetary / FB.ArrivalAmount)-1 )*100).ToString().Substring(0,4);
            if (FB.Type == 1)
                RadioBuy.Checked = true;
            else if (FB.Type == 2)
                RadioSell.Checked = true;
            if (FB.InVain == 1)
                CHE_InVain.Checked = true;
            comboBox1.Enabled = false;
            markTextBox1.Enabled = false;
            markTextBox2.Enabled = false;
            markTextBox2.Enabled = false;
            RadioBuy.Enabled = false;
            RadioSell.Enabled = false;
            dateTimePicker1.Enabled = false;
            markTextBox3.Enabled = false;
            CHE_InVain.Enabled = true;
            OrderNumber = FB.OrderNumber;

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
                //获取未作废的
                if(item.InVain==0 && item.OrderNumber!=OrderNumber)
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
            }
            if(CHE_InVain.CheckState == CheckState.Unchecked)
            {
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
            }
            else
                FHPB.Quantity = FHPB.ArrivalAmount / FHPB.UnitPrice;        
            FHPB.Residue = Surplus;
            if(CHE_InVain.CheckState == CheckState.Checked)
                FHPB.InVain = 1;
            else
                FHPB.InVain = 0;       
            if (CHE_InVain.Enabled == false)
            {
                FHPB.OrderNumber = Guid.NewGuid().ToString();
                Fund_HoldAPositionBatServices.Insert(FHPB);
            }           
            else
            {
                if (OrderNumber != string.Empty)
                    FHPB.OrderNumber = OrderNumber;
                Fund_HoldAPositionBatServices.Update(FHPB);
            }                
            //decimal prices = 0;
            Fund_HoldAPosition FHAP = new Fund_HoldAPosition();
            FHAP.ID = comboBox1.SelectedValue.ToString();
            FHAP.Quantity = TotalNumber;
            if (TotalNumber != 0)
                FHAP.UnitPrice = Surplus / TotalNumber;
            else
                FHAP.UnitPrice = 0;

            //prices = FHAP.Quantity * FHAP.UnitPrice;
            //if (RadioSell.Checked)
            //    prices = -prices;
            if (Fund_HoldAPositionServices.GetData(FHAP.ID).Count > 0)
                Fund_HoldAPositionServices.Update(FHAP);
            else
                Fund_HoldAPositionServices.Insert(FHAP);
            this.DialogResult = DialogResult.OK;
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
