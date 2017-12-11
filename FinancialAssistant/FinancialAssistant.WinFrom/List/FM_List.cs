using FinancialAssistant.Data;
using FinancialAssistant.DoMain.V;
using FinancialAssistant.Services.V;
using FinancialAssistant.WinFrom.FundCompany;
using FinancialAssistant.WinFrom.FundName;
using FinancialAssistant.WinFrom.HoldAPosition;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialAssistant.WinFrom.List
{
    public partial class FM_List : Form
    {
        V_HoldAPositionService V_HoldAPositionService = new V_HoldAPositionService();
        public FM_List()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

            FM_FCEdit FC = new FM_FCEdit();
            FC.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FM_FNEdit FF = new FM_FNEdit();
            FF.Show();
        }

        private void FM_List_Load(object sender, EventArgs e)
        {
            //comboBox1.Text = "10";
            //dataGridView1.DataSource = new BindingList<V_HoldAPosition>(V_HoldAPositionService.GetData(100, 1,"",""));
            //int Count = V_HoldAPositionService.GetCount();
            //List<int> data = new List<int>();
            //int num = Count / int.Parse(comboBox1.Text) + 1, endnum = 1;
            //if (endnum + 5 > num)
            //    endnum = num;
            //else
            //    endnum += 5;
            //for (int i = 1; i <= endnum; i++)
            //    data.Add(i);
            //comboBox2.DataSource = new BindingList<int>(data);
            //comboBox2.Text = "1";
        }
        /// <summary>
        /// 首页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {            
            int Count = V_HoldAPositionService.GetCount();
            List<int> data = new List<int>();
            int num = Count / int.Parse(comboBox1.Text) + 1, endnum = 1;
            if (endnum + 5 > num)
                endnum = num;
            else
                endnum += 5;
            for (int i = 1; i <= endnum; i++)
                data.Add(i);
            comboBox2.DataSource = new BindingList<int>(data);
            comboBox2.Text = "1";
            //dataGridView1.DataSource = new BindingList<V_HoldAPosition>(V_HoldAPositionService.GetData(1,int.Parse(comboBox1.Text)));
        }
        /// <summary>
        /// 上一页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void button1_Click(object sender, EventArgs e)
        {
            int Count = V_HoldAPositionService.GetCount();
            List<int> data = new List<int>();
            int page = int.Parse(comboBox2.Text);
            int num = Count / int.Parse(comboBox1.Text)+1, startnum= int.Parse(comboBox2.Text), endnum= int.Parse(comboBox2.Text);
            if (startnum - 5 <= 0)
                startnum = 1;
            else
                startnum = startnum - 5;
            if (endnum + 5 > num)
                endnum = num;
            else
                endnum += 5;
            for (int i = startnum; i <= endnum; i++)
                data.Add(i);
            int start = int.Parse(comboBox1.Text) * (int.Parse(comboBox2.Text) - 2)+1;
            int end = int.Parse(comboBox1.Text) * (int.Parse(comboBox2.Text)-1);
            //IList<V_HoldAPosition> IVP = V_HoldAPositionService.GetData(start, end);
            //if (IVP.Count != 0)
            //{
            //    dataGridView1.DataSource = new BindingList<V_HoldAPosition>(IVP);
            //    comboBox2.DataSource = new BindingList<int>(data);
            //    comboBox2.Text = (page - 1).ToString();
            //}

        }
        /// <summary>
        /// 下一页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void button2_Click(object sender, EventArgs e)
        {
            int Count = V_HoldAPositionService.GetCount();
            List<int> data = new List<int>();
            int page = int.Parse(comboBox2.Text);
            int num = Count / int.Parse(comboBox1.Text) + 1, startnum = int.Parse(comboBox2.Text), endnum = int.Parse(comboBox2.Text);
            if (startnum - 5 <= 0)
                startnum = 1;
            else
                startnum = startnum - 5;
            if (endnum + 5 > num)
                endnum = num;
            else
                endnum += 5;
            for (int i = startnum; i <= endnum; i++)
                data.Add(i);
            int start = int.Parse(comboBox1.Text) * (int.Parse(comboBox2.Text))+1;
            int end = int.Parse(comboBox1.Text) * (int.Parse(comboBox2.Text)+1);
            //IList<V_HoldAPosition> IVP = V_HoldAPositionService.GetData(start, end);
            //if (IVP.Count != 0)
            //{
            //    dataGridView1.DataSource = new BindingList<V_HoldAPosition>(IVP);
            //    comboBox2.DataSource = new BindingList<int>(data);
            //    comboBox2.Text = (page + 1).ToString();
            //}

        }

        /// <summary>
        /// 尾页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            int Count=   V_HoldAPositionService.GetCount();
            List<int> data = new List<int>();
            int num = Count / int.Parse(comboBox1.Text) + 1, startnum = int.Parse(comboBox2.Text);

            if (startnum - 5 <= 0)
                startnum = 1;
            else
                startnum = startnum - 5;
            for (int i = startnum; i <= num; i++)
                data.Add(i);
            int start = (num-1) * (int.Parse(comboBox1.Text)) + 1;
            int end = Count;
            //IList<V_HoldAPosition> IVP = V_HoldAPositionService.GetData(start, end);
            //if (IVP.Count != 0)
            //    dataGridView1.DataSource = new BindingList<V_HoldAPosition>(IVP);
            //comboBox2.DataSource = new BindingList<int>(data);
            //comboBox2.Text = (num).ToString();

        }
        /// <summary>
        /// 跳转
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)
        {
            List<int> data = new List<int>();
            int Count = V_HoldAPositionService.GetCount();
            int page = int.Parse(comboBox2.Text);
            int num = Count / int.Parse(comboBox1.Text) + 1, startnum = int.Parse(comboBox2.Text), endnum = int.Parse(comboBox2.Text);
            if (page<= num && page>0)
            {  
                if (startnum - 5 <= 0)
                    startnum = 1;
                else
                    startnum = startnum - 5;
                if (endnum + 5 > num)
                    endnum = num;
                else
                    endnum += 5;
                for (int i = startnum; i <= endnum; i++)
                    data.Add(i);
                int start = int.Parse(comboBox1.Text) * (int.Parse(comboBox2.Text) - 1) + 1;
                int end = int.Parse(comboBox1.Text) * (int.Parse(comboBox2.Text));
                //IList<V_HoldAPosition> IVP = V_HoldAPositionService.GetData(start, end);
                //if (IVP.Count != 0)
                //{
                //    dataGridView1.DataSource = new BindingList<V_HoldAPosition>(IVP);
                //    comboBox2.DataSource = new BindingList<int>(data);
                //    comboBox2.Text = (page).ToString();
                //}
            }
            else
            {
                if(page>0)
                    MessageBox.Show("超过总页数！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                else if (page == 0)
                    MessageBox.Show("页数不能为0！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                else
                    MessageBox.Show("页数不能为负数！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
 
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            FM_HoldAPositionEdit FHP = new FM_HoldAPositionEdit();
            FHP.Show();
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            int Count = V_HoldAPositionService.GetCount();
            List<int> data = new List<int>();
            int num = Count / int.Parse(comboBox1.Text) + 1, endnum = 1;
            if (endnum + 5 > num)
                endnum = num;
            else
                endnum += 5;
            for (int i = 1; i <= endnum; i++)
                data.Add(i);
            comboBox2.DataSource = new BindingList<int>(data);
            comboBox2.Text = "1";
            //dataGridView1.DataSource = new BindingList<V_HoldAPosition>(V_HoldAPositionService.GetData(1, int.Parse(comboBox1.Text)));
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
          
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
