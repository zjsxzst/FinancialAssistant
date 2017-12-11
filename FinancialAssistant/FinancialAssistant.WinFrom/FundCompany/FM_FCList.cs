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

namespace FinancialAssistant.WinFrom.FundCompany
{
    public partial class FM_FCList : Form
    {
        CompanyServices CompanyServices = new CompanyServices();
        private int DataCount = 0, DataTotalPages = 0;
        public FM_FCList()
        {
            InitializeComponent();
        }

        private void FM_FCList_Load(object sender, EventArgs e)
        {
            COM_Page.Text = "10";
            int PageNum = 0, PageCount = 0;
            dataGridView1.DataSource = new BindingList<Fund_Company>(CompanyServices.GetData(10, 1, ref PageNum, ref PageCount, SetWhere(), null));
            List<int> data = new List<int>();
            if (PageNum + 5 > PageCount)
                PageNum = PageCount;
            else
                PageNum += 5;
            for (int i = 1; i <= PageNum; i++)
                data.Add(i);
            COM_Skip.DataSource = new BindingList<int>(data);
            COM_Skip.Text = "1";

        }
        private string SetWhere()
        {
            string Where = "";
            if (!string.IsNullOrWhiteSpace(markTextBox2.Text))
                Where = "ID=" + markTextBox2.Text;
            if (!string.IsNullOrWhiteSpace(markTextBox1.Text))
            {
                if (!string.IsNullOrWhiteSpace(Where))
                    Where = Where + " and CompanyName like'%" + markTextBox1.Text + "%'";
                else
                    Where = " CompanyName like'%" + markTextBox1.Text + "%'";
            }
            if (!string.IsNullOrWhiteSpace(Where))
                return "Where "+Where;
            else
                return "";
        }
        private void BT_UpPage_Click(object sender, EventArgs e)
        {
            int PageNum = 0, PageCount = 0;
            if (DataCount == 0)
                DataCount = CompanyServices.GetCount();
            int Mod = DataCount % int.Parse(COM_Page.Text);
            if (DataTotalPages == 0)
            {
                DataTotalPages = DataCount / int.Parse(COM_Page.Text);
                if (Mod != 0)
                    DataTotalPages += 1;
            }
            if (int.Parse(COM_Skip.Text) > 1)
            {
                int page = int.Parse(COM_Skip.Text) - 1;
                dataGridView1.DataSource = new BindingList<Fund_Company>(CompanyServices.GetData(int.Parse(COM_Page.Text), page, ref PageNum, ref PageCount, SetWhere(), null));
                List<int> data = new List<int>();
                if (PageNum + 5 > PageCount)
                    if (Mod != 0)
                        PageNum = PageCount + 1;
                    else
                        PageNum = PageCount;
                else
                    PageNum += 5;
                for (int i = 1; i <= PageNum; i++)
                    data.Add(i);
                COM_Skip.DataSource = new BindingList<int>(data);
                COM_Skip.Text = page.ToString();
            }
        }

        private void BT_HomePage_Click(object sender, EventArgs e)
        {
            int PageNum = 0, PageCount = 0;
            if (DataCount == 0)
                DataCount = CompanyServices.GetCount();
            int Mod = DataCount % int.Parse(COM_Page.Text);
            if (DataTotalPages == 0)
            {
                DataTotalPages = DataCount / int.Parse(COM_Page.Text);
                if (Mod != 0)
                    DataTotalPages += 1;
            }
            dataGridView1.DataSource = new BindingList<Fund_Company>(CompanyServices.GetData(int.Parse(COM_Page.Text), 1, ref PageNum, ref PageCount, SetWhere(), null));
            List<int> data = new List<int>();
            if (PageNum + 5 > PageCount)
                PageNum = PageCount;
            else
                PageNum += 5;
            for (int i = 1; i <= PageNum; i++)
                data.Add(i);
            COM_Skip.DataSource = new BindingList<int>(data);
            COM_Skip.Text = "1";
        }

        private void 添加ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FM_FCEdit FC = new FM_FCEdit();
            if (FC.ShowDialog() == DialogResult.OK)
            {
                DataCount = CompanyServices.GetCount();
                DataCount = CompanyServices.GetCount();
                int Mod = DataCount % int.Parse(COM_Page.Text);
                DataTotalPages = DataCount / int.Parse(COM_Page.Text);
                if (Mod != 0)
                    DataTotalPages += 1;
                int PageNum = 0, PageCount = 0;
                int page = int.Parse(COM_Skip.Text);
                dataGridView1.DataSource = new BindingList<Fund_Company>(CompanyServices.GetData(int.Parse(COM_Page.Text), page, ref PageNum, ref PageCount, SetWhere(), null));
            }
        }

        private void BT_Skip_Click(object sender, EventArgs e)
        {
            int PageNum = 0, PageCount = 0;
            if (DataCount == 0)
                DataCount = CompanyServices.GetCount();
            int Mod = DataCount % int.Parse(COM_Page.Text);
            if (DataTotalPages == 0)
            {
                DataTotalPages = DataCount / int.Parse(COM_Page.Text);
                if (Mod != 0)
                    DataTotalPages += 1;
            }
            if (int.Parse(COM_Skip.Text) > 0 && int.Parse(COM_Skip.Text) <= DataTotalPages)
            {
                int page = int.Parse(COM_Skip.Text);
                dataGridView1.DataSource = new BindingList<Fund_Company>(CompanyServices.GetData(int.Parse(COM_Page.Text), page, ref PageNum, ref PageCount, SetWhere(), null));
                List<int> data = new List<int>();
                if (PageNum + 5 > PageCount)
                    if (Mod != 0)
                        PageNum = PageCount + 1;
                    else
                        PageNum = PageCount;
                else
                    PageNum += 5;
                for (int i = 1; i <= PageNum; i++)
                    data.Add(i);
                COM_Skip.DataSource = new BindingList<int>(data);
                COM_Skip.Text = page.ToString();
            }
            else
            {
                if (int.Parse(COM_Skip.Text) > 0)
                    MessageBox.Show("超过总页数！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                else if (int.Parse(COM_Skip.Text) == 0)
                    MessageBox.Show("页数不能为0！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                else
                    MessageBox.Show("页数不能为负数！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
        private void BT_NextPage_Click(object sender, EventArgs e)
        {
            int PageNum = 0, PageCount = 0;
            if (DataCount == 0)
                DataCount = CompanyServices.GetCount();
            int Mod = DataCount % int.Parse(COM_Page.Text);
            if (DataTotalPages == 0)
            {
                DataTotalPages = DataCount / int.Parse(COM_Page.Text);
                if (Mod != 0)
                    DataTotalPages += 1;
            }
            int page = int.Parse(COM_Skip.Text);
            if (page > 0 && page + 1 <= DataTotalPages)
            {
                page++;
                dataGridView1.DataSource = new BindingList<Fund_Company>(CompanyServices.GetData(int.Parse(COM_Page.Text), page, ref PageNum, ref PageCount, SetWhere(), null));
                List<int> data = new List<int>();
                if (PageNum + 5 > PageCount)
                    if (Mod != 0)
                        PageNum = PageCount + 1;
                    else
                        PageNum = PageCount;
                else
                    PageNum += 5;
                for (int i = 1; i <= PageNum; i++)
                    data.Add(i);
                COM_Skip.DataSource = new BindingList<int>(data);
                COM_Skip.Text = page.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int PageNum = 0, PageCount = 0;
            DataCount = CompanyServices.GetCount();
            int Mod = DataCount % int.Parse(COM_Page.Text);

            DataTotalPages = DataCount / int.Parse(COM_Page.Text);
            if (Mod != 0)
                DataTotalPages += 1;
            dataGridView1.DataSource = new BindingList<Fund_Company>(CompanyServices.GetData(int.Parse(COM_Page.Text), 1, ref PageNum, ref PageCount, SetWhere(), null));
            List<int> data = new List<int>();
            if (PageNum + 5 > PageCount)
                PageNum = PageCount;
            else
                PageNum += 5;
            for (int i = 1; i <= PageNum; i++)
                data.Add(i);
            COM_Skip.DataSource = new BindingList<int>(data);
            COM_Skip.Text = "1";
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            Fund_Company FC = new Fund_Company();
            int index = dataGridView1.CurrentRow.Index;
            FC.Id = int.Parse(dataGridView1.Rows[index].Cells[0].Value.ToString());
            FC.CompanyName = dataGridView1.Rows[index].Cells[1].Value.ToString();
            FM_FCEdit FCE = new FM_FCEdit(FC);
            FCE.Show();
        }

        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.RowIndex >= 0)
                {
                    //若行已是选中状态就不再进行设置
                    if (dataGridView1.Rows[e.RowIndex].Selected == false)
                    {
                        dataGridView1.ClearSelection();
                        dataGridView1.Rows[e.RowIndex].Selected = true;
                    }
                    //只选中一行时设置活动单元格
                    if (dataGridView1.SelectedRows.Count == 1)
                    {
                        dataGridView1.CurrentCell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    }
                    //弹出操作菜单
                    LISTStrip.Show(MousePosition.X, MousePosition.Y);
                }
            }
        }

        private void 添加ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FM_FCEdit FC = new FM_FCEdit();
            if (FC.ShowDialog() == DialogResult.OK)
            {
                DataCount = CompanyServices.GetCount();
                DataCount = CompanyServices.GetCount();
                int Mod = DataCount % int.Parse(COM_Page.Text);
                DataTotalPages = DataCount / int.Parse(COM_Page.Text);
                if (Mod != 0)
                    DataTotalPages += 1;
                int PageNum = 0, PageCount = 0;
                int page = int.Parse(COM_Skip.Text);
                dataGridView1.DataSource = new BindingList<Fund_Company>(CompanyServices.GetData(int.Parse(COM_Page.Text), page, ref PageNum, ref PageCount, SetWhere(), null));
            }
        }

        private void 修改ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Edit();
            int PageNum = 0, PageCount = 0;
            int page = int.Parse(COM_Skip.Text);
            dataGridView1.DataSource = new BindingList<Fund_Company>(CompanyServices.GetData(int.Parse(COM_Page.Text), page, ref PageNum, ref PageCount, SetWhere(), null));
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Delete();
            DataCount = CompanyServices.GetCount();
            DataCount = CompanyServices.GetCount();
            int Mod = DataCount % int.Parse(COM_Page.Text);
            DataTotalPages = DataCount / int.Parse(COM_Page.Text);
            if (Mod != 0)
                DataTotalPages += 1;
            int PageNum = 0, PageCount = 0;
            int page = int.Parse(COM_Skip.Text);
            dataGridView1.DataSource = new BindingList<Fund_Company>(CompanyServices.GetData(int.Parse(COM_Page.Text), page, ref PageNum, ref PageCount, SetWhere(), null));
        }

        private void 修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Edit();
        }
        private void Edit()
        {
            Fund_Company FC = new Fund_Company();
            int index = dataGridView1.CurrentRow.Index;
            FC.Id = int.Parse(dataGridView1.Rows[index].Cells[0].Value.ToString());
            FC.CompanyName = dataGridView1.Rows[index].Cells[1].Value.ToString();
            FM_FCEdit FCE = new FM_FCEdit(FC);
            if (FCE.ShowDialog() == DialogResult.OK)
            {
                int PageNum = 0, PageCount = 0;
                int page = int.Parse(COM_Skip.Text);
                dataGridView1.DataSource = new BindingList<Fund_Company>(CompanyServices.GetData(int.Parse(COM_Page.Text), page, ref PageNum, ref PageCount, SetWhere(), null));
            }
        }
        private void Delete()
        {
            int index = dataGridView1.CurrentRow.Index;
            int Id = int.Parse(dataGridView1.Rows[index].Cells[0].Value.ToString());
            if (CompanyServices.Delete(Id))
            {
                int Mod = DataCount % int.Parse(COM_Page.Text);
                if (DataTotalPages == 0)
                {
                    DataTotalPages = DataCount / int.Parse(COM_Page.Text);
                    if (Mod != 0)
                        DataTotalPages += 1;
                }
                int PageNum = 0, PageCount = 0;
                int page = int.Parse(COM_Skip.Text);
                dataGridView1.DataSource = new BindingList<Fund_Company>(CompanyServices.GetData(int.Parse(COM_Page.Text), page, ref PageNum, ref PageCount, SetWhere(), null));
            }
            else
            {
                MessageBox.Show("请重试！");
            }
        }

        private void BT_TrailerPage_Click(object sender, EventArgs e)
        {
            int PageNum = 0, PageCount = 0;
            if (DataCount == 0)
                DataCount = CompanyServices.GetCount();
            if (DataTotalPages == 0)
            {
                DataTotalPages = DataCount / int.Parse(COM_Page.Text);
                int Mod = DataCount % int.Parse(COM_Page.Text);
                if (Mod != 0)
                    DataTotalPages += 1;
            }
            dataGridView1.DataSource = new BindingList<Fund_Company>(CompanyServices.GetData(int.Parse(COM_Page.Text), DataTotalPages, ref PageNum, ref PageCount, SetWhere(), null));
            List<int> data = new List<int>();
            int started = DataTotalPages - 5;
            if (started < 1)
                started = 1;
            for (int i = started; i <= DataTotalPages; i++)
                data.Add(i);
            COM_Skip.DataSource = new BindingList<int>(data);
            COM_Skip.Text = DataTotalPages.ToString();
        }

        private void COM_Page_TextChanged(object sender, EventArgs e)
        {
            int PageNum = 0, PageCount = 0;
            DataCount = CompanyServices.GetCount();
            DataTotalPages = DataCount / int.Parse(COM_Page.Text);
            int Mod = DataCount % int.Parse(COM_Page.Text);
            if (Mod != 0)
                DataTotalPages += 1;
            if (int.Parse(COM_Page.Text) > 0)
            {
                dataGridView1.DataSource = new BindingList<Fund_Company>(CompanyServices.GetData(int.Parse(COM_Page.Text), 1, ref PageNum, ref PageCount, SetWhere(), null));
                List<int> data = new List<int>();
                if (PageNum + 5 > PageCount)
                    if (Mod != 0)
                        PageNum = PageCount + 1;
                    else
                        PageNum = PageCount;
                else
                    PageNum += 5;
                for (int i = 1; i <= PageNum; i++)
                    data.Add(i);
                COM_Skip.DataSource = new BindingList<int>(data);
                COM_Skip.Text = "1";
            }
        }

        private void BT_TextClone_Click(object sender, EventArgs e)
        {
            markTextBox1.Text = "";
            markTextBox2.Text = "";
        }

        private void 删除ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Index > 0)
            {
                Delete();
                DataCount = CompanyServices.GetCount();
                DataCount = CompanyServices.GetCount();
                int Mod = DataCount % int.Parse(COM_Page.Text);
                DataTotalPages = DataCount / int.Parse(COM_Page.Text);
                if (Mod != 0)
                    DataTotalPages += 1;
                int PageNum = 0, PageCount = 0;
                int page = int.Parse(COM_Skip.Text);
                dataGridView1.DataSource = new BindingList<Fund_Company>(CompanyServices.GetData(int.Parse(COM_Page.Text), page, ref PageNum, ref PageCount, SetWhere(), null));
            }

        }

    }
}
