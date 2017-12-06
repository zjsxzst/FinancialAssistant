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
    public partial class FM_FCList : Form
    {
        CompanyServices CompanyServices = new CompanyServices();
        public FM_FCList()
        {
            InitializeComponent();
        }

        private void FM_FCList_Load(object sender, EventArgs e)
        {
            COM_Page.Text = "10";
            dataGridView1.DataSource = new BindingList<Fund_Company>(CompanyServices.GetData(0, 10, null));
            int Count = CompanyServices.GetCount();
            List<int> data = new List<int>();
            int num = Count / int.Parse(COM_Page.Text) + 1, endnum = 1;
            if (endnum + 5 > num)
                endnum = num;
            else
                endnum += 5;
            for (int i = 1; i <= endnum; i++)
                data.Add(i);
            COM_Skip.DataSource = new BindingList<int>(data);
            COM_Skip.Text = "1";
            
        }
        private string SetWhere()
        {
            string Where = "";
            if (!string.IsNullOrWhiteSpace(markTextBox2.Text))
                Where ="ID=" +markTextBox2.Text;
            if (!string.IsNullOrWhiteSpace(markTextBox1.Text))
            {
                if (!string.IsNullOrWhiteSpace(Where))
                    Where = Where + " and CompanyName='" + markTextBox1.Text+"'";
                else
                    Where = " CompanyName='"+markTextBox1.Text+ "'";
            }
            return Where;
        }
        private void BT_UpPage_Click(object sender, EventArgs e)
        {
            int Count = CompanyServices.GetCount();
            List<int> data = new List<int>();
            int page = int.Parse(COM_Skip.Text);
            int num = Count / int.Parse(COM_Page.Text) + 1, startnum = int.Parse(COM_Skip.Text), endnum = int.Parse(COM_Skip.Text);
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
            int start = int.Parse(COM_Page.Text) * (int.Parse(COM_Skip.Text) - 2) + 1;
            int end = int.Parse(COM_Page.Text) * (int.Parse(COM_Skip.Text) - 1);
            IList <Fund_Company> IFC = CompanyServices.GetData(1, int.Parse(COM_Page.Text), SetWhere());
            if (IFC.Count != 0)
            {
                dataGridView1.DataSource = new BindingList<Fund_Company>(IFC);
                COM_Skip.DataSource = new BindingList<int>(data);
                COM_Skip.Text = (page - 1).ToString();
            }
        }

        private void BT_HomePage_Click(object sender, EventArgs e)
        {
            int Count = CompanyServices.GetCount();
            List<int> data = new List<int>();
            int num = Count / int.Parse(COM_Page.Text) + 1, endnum = 1;
            if (endnum + 5 > num)
                endnum = num;
            else
                endnum += 5;
            for (int i = 1; i <= endnum; i++)
                data.Add(i);
            COM_Skip.DataSource = new BindingList<int>(data);
            COM_Skip.Text = "1";
            dataGridView1.DataSource = new BindingList<Fund_Company>(CompanyServices.GetData(1, int.Parse(COM_Page.Text), SetWhere()));
        }

        private void 添加ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FM_FCEdit FC = new FM_FCEdit();
            FC.Show();
        }

        private void BT_Skip_Click(object sender, EventArgs e)
        {
            List<int> data = new List<int>();
            int Count = CompanyServices.GetCount();
            int page = int.Parse(COM_Skip.Text);
            int num = Count / int.Parse(COM_Page.Text) + 1, startnum = int.Parse(COM_Skip.Text), endnum = int.Parse(COM_Skip.Text);
            if (page <= num && page > 0)
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
                int start = int.Parse(COM_Page.Text) * (int.Parse(COM_Skip.Text) - 1) + 1;
                int end = int.Parse(COM_Page.Text) * (int.Parse(COM_Skip.Text));
                IList<Fund_Company> IVP = CompanyServices.GetData(start, end, SetWhere());
                if (IVP.Count != 0)
                {
                    dataGridView1.DataSource = new BindingList<Fund_Company>(IVP);
                    COM_Skip.DataSource = new BindingList<int>(data);
                    COM_Skip.Text = (page).ToString();
                }
            }
            else
            {
                if (page > 0)
                    MessageBox.Show("超过总页数！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                else if (page == 0)
                    MessageBox.Show("页数不能为0！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                else
                    MessageBox.Show("页数不能为负数！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void BT_NextPage_Click(object sender, EventArgs e)
        {
           
        }
    }
}
