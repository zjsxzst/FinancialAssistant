using FinancialAssistant.DoMain.Fund;
using FinancialAssistant.DoMain.V;
using FinancialAssistant.Services.Fund;
using FinancialAssistant.Services.V;
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
    public partial class FM_FNList : Form
    {
        CompanyServices CompanySV = new CompanyServices();
        FundNameServices FundNameSV = new FundNameServices();
        V_HoldAPositionService V_HoldAPositionService = new V_HoldAPositionService();
        V_FundNameService V_FundNameService = new V_FundNameService();
        IList<Fund_Company> LFC = new List<Fund_Company>();
        private int DataCount = 0, DataTotalPages = 0;
        bool SearchSwitch = true;
        public FM_FNList()
        {
            InitializeComponent();
        }

        private void FM_FNList_Load(object sender, EventArgs e)
        {
            LFC = CompanySV.GetData();
            Com_FundCompany.DataSource = LFC;
            Com_FundCompany.DisplayMember = "CompanyName";
            Com_FundCompany.ValueMember = "ID";
            Com_FundCompany.SelectedIndex = -1;
            COM_Page.Text = "10";
            int PageNum = 0, PageCount = 0;
            dataGridView1.DataSource = new BindingList<V_FundName>(V_FundNameService.GetData(10, 1, ref PageNum, SetWhere(), ""));
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
            if (!string.IsNullOrWhiteSpace(MTB_FundID.Text))
                Where = "ID=" + MTB_FundID.Text;
            if (!string.IsNullOrWhiteSpace(MTB_FundName.Text))
            {
                if (!string.IsNullOrWhiteSpace(Where))
                    Where = Where + " and FundName like'%" + MTB_FundName.Text + "%'";
                else
                    Where = " FundName like'%" + MTB_FundName.Text + "%'";
            }
            if (!string.IsNullOrWhiteSpace(Com_FundCompany.Text))
            {
                if (!string.IsNullOrWhiteSpace(Where))
                    Where = Where + " and CompanyName like'%" + Com_FundCompany.Text + "%'";
                else
                    Where = " CompanyName like'%" + Com_FundCompany.Text + "%'";
            }
            if (!string.IsNullOrWhiteSpace(Where))
                return "Where " + Where;
            else
                return "";
        }
        private void BT_Search_Click(object sender, EventArgs e)
        {
            int PageNum = 0, PageCount = 0;
            dataGridView1.DataSource = new BindingList<V_FundName>(V_FundNameService.GetData(int.Parse(COM_Page.Text), 1, ref PageNum, SetWhere(), ""));
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

        private void BT_Clear_Click(object sender, EventArgs e)
        {
            MTB_FundID.Text = "";
            MTB_FundName.Text = "";
            Com_FundCompany.Text = "";
            int PageNum = 0, PageCount = 0;
            dataGridView1.DataSource = new BindingList<V_FundName>(V_FundNameService.GetData(int.Parse(COM_Page.Text), 1, ref PageNum, SetWhere(), ""));
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

        private void COM_Page_TextChanged(object sender, EventArgs e)
        {
            int PageNum = 0, PageCount = 0;
            dataGridView1.DataSource = new BindingList<V_FundName>(V_FundNameService.GetData(int.Parse(COM_Page.Text), 1, ref PageNum, SetWhere(), ""));
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

        private void BT_HomePage_Click(object sender, EventArgs e)
        {
            int PageNum = 0, PageCount = 0;
            if (DataCount == 0)
                DataCount = V_FundNameService.GetCount(SetWhere());
            int Mod = DataCount % int.Parse(COM_Page.Text);
            if (DataTotalPages == 0)
            {
                DataTotalPages = DataCount / int.Parse(COM_Page.Text);
                if (Mod != 0)
                    DataTotalPages += 1;
            }
            dataGridView1.DataSource = new BindingList<V_FundName>(V_FundNameService.GetData(int.Parse(COM_Page.Text), 1, ref PageNum, SetWhere(), ""));
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

        private void BT_UpPage_Click(object sender, EventArgs e)
        {
            int PageNum = 0, PageCount = 0;
            if (DataCount == 0)
                DataCount = V_FundNameService.GetCount(SetWhere());
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
                dataGridView1.DataSource = new BindingList<V_FundName>(V_FundNameService.GetData(int.Parse(COM_Page.Text), page, ref PageNum, SetWhere(), ""));
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

        private void BT_Skip_Click(object sender, EventArgs e)
        {
            int PageNum = 0, PageCount = 0;
            if (DataCount == 0)
                DataCount = V_FundNameService.GetCount(SetWhere());
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
                dataGridView1.DataSource = new BindingList<V_FundName>(V_FundNameService.GetData(int.Parse(COM_Page.Text), int.Parse(COM_Skip.Text), ref PageNum, SetWhere(), ""));
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
                DataCount = V_FundNameService.GetCount(SetWhere());
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
                dataGridView1.DataSource = new BindingList<V_FundName>(V_FundNameService.GetData(int.Parse(COM_Page.Text), page, ref PageNum, SetWhere(), ""));
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

        private void BT_TrailerPage_Click(object sender, EventArgs e)
        {
            int PageNum = 0, PageCount = 0;
            if (DataCount == 0)
                DataCount = V_FundNameService.GetCount(SetWhere());
            if (DataTotalPages == 0)
            {
                DataTotalPages = DataCount / int.Parse(COM_Page.Text);
                int Mod = DataCount % int.Parse(COM_Page.Text);
                if (Mod != 0)
                    DataTotalPages += 1;
            }
            dataGridView1.DataSource = new BindingList<V_FundName>(V_FundNameService.GetData(int.Parse(COM_Page.Text), DataTotalPages, ref PageNum, SetWhere(), ""));
            List<int> data = new List<int>();
            int started = DataTotalPages - 5;
            if (started < 1)
                started = 1;
            for (int i = started; i <= DataTotalPages; i++)
                data.Add(i);
            COM_Skip.DataSource = new BindingList<int>(data);
            COM_Skip.Text = DataTotalPages.ToString();
        }

        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
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

            }catch(Exception ex)
            {
                
            }
        }

        /// <summary>
        /// 模糊搜索
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Com_FundCompany_TextUpdate(object sender, EventArgs e)
        {
            string Data = Com_FundCompany.Text;
            IList<Fund_Company> LFCBat = new List<Fund_Company>();
            if (!string.IsNullOrWhiteSpace(Data))
            {
                LFCBat = LFC.Where(m => m.CompanyName.IndexOf(Data) >= 0 || m.CompanyName == Data).ToList();
                Com_FundCompany.DataSource = LFCBat;

            }
            else
                Com_FundCompany.DataSource = LFC;
            Com_FundCompany.DisplayMember = "CompanyName";
            Com_FundCompany.ValueMember = "ID";
            Com_FundCompany.SelectedIndex = -1;
            Com_FundCompany.Text = Data;
        }

        private void 删除ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void Delete()
        {
            int index = dataGridView1.CurrentRow.Index;
            int Id = int.Parse(dataGridView1.Rows[index].Cells[0].Value.ToString());
            if (FundNameSV.Delete(Id))
            {
                int Mod = DataCount % int.Parse(COM_Page.Text);
                DataTotalPages = DataCount / int.Parse(COM_Page.Text);
                if (Mod != 0)
                    DataTotalPages += 1;
                int PageNum = 0, PageCount = 0;
                int page = int.Parse(COM_Skip.Text);
                dataGridView1.DataSource = new BindingList<V_FundName>(V_FundNameService.GetData(int.Parse(COM_Page.Text), int.Parse(COM_Skip.Text), ref PageNum, SetWhere(), ""));
            }
            else
            {
                MessageBox.Show("请重试！");
            }
        }

        private void 添加ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Create();
        }

        private void 修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Edit();
        }

        private void Edit()
        {
            Fund_Name FN = new Fund_Name();
            Fund_Company FC = new Fund_Company();

            int index = dataGridView1.CurrentRow.Index;
            string Where = " Id=";
            Where+= int.Parse(dataGridView1.Rows[index].Cells[0].Value.ToString());
            IList<Fund_Name> LFN = FundNameSV.GetData(Where);
            FN.CompanyID = LFN[0].CompanyID;
            FN.FundName = LFN[0].FundName;
            FN.ID= LFN[0].ID;
            FM_FNEdit FCE = new FM_FNEdit(FN);
            if (FCE.ShowDialog() == DialogResult.OK)
            {
                int Mod = DataCount % int.Parse(COM_Page.Text);
                DataTotalPages = DataCount / int.Parse(COM_Page.Text);
                if (Mod != 0)
                    DataTotalPages += 1;
                int PageNum = 0, PageCount = 0;
                int page = int.Parse(COM_Skip.Text);
                dataGridView1.DataSource = new BindingList<V_FundName>(V_FundNameService.GetData(int.Parse(COM_Page.Text), int.Parse(COM_Skip.Text), ref PageNum, SetWhere(), ""));
            }
        }

        private void 添加ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Create();
        }

        private void 修改ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Edit();
        }

        private void Create()
        {
            FM_FNEdit FCE = new FM_FNEdit();
            if (FCE.ShowDialog() == DialogResult.OK)
            {
                int Mod = DataCount % int.Parse(COM_Page.Text);
                DataTotalPages = DataCount / int.Parse(COM_Page.Text);
                if (Mod != 0)
                    DataTotalPages += 1;
                int PageNum = 0, PageCount = 0;
                int page = int.Parse(COM_Skip.Text);
                dataGridView1.DataSource = new BindingList<V_FundName>(V_FundNameService.GetData(int.Parse(COM_Page.Text), 1, ref PageNum, SetWhere(), ""));
            }

        }
    }
}
