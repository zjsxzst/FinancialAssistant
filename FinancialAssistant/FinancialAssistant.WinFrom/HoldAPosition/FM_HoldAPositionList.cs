using FinancialAssistant.DoMain.V;
using FinancialAssistant.Services.Fund;
using FinancialAssistant.Services.V;
using FinancialAssistant.WinFrom.APP;
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
    public partial class FM_HoldAPositionList : Form
    {
        private int DataCount = 0, DataTotalPages = 0;
        V_HoldAPositionService Service = new V_HoldAPositionService();
        Fund_HoldAPositionServices FHPSercice = new Fund_HoldAPositionServices();
        public FM_HoldAPositionList()
        {
            InitializeComponent();
        }

        private void FM_HoldAPositionList_Load(object sender, EventArgs e)
        {
            COM_Page.Text = "10";
            int PageNum = 0, PageCount = 0;
            dataGridView1.DataSource = new BindingList<V_HoldAPosition>(Service.GetData(10, 1, ref PageNum, ""));
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

        private void COM_Page_TextUpdate(object sender, EventArgs e)
        {
            int PageNum = 0, PageCount = 0;
            dataGridView1.DataSource = new BindingList<V_HoldAPosition>(Service.GetData(int.Parse(COM_Page.Text), 1, ref PageNum, ""));
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

        private void BT_Skip_Click(object sender, EventArgs e)
        {
            int PageNum = 0, PageCount = 0;
            if (DataCount == 0)
                DataCount = Service.GetCount();
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
                PagingHelp<V_HoldAPosition>.PageSkip(DataCount, COM_Page, COM_Skip, dataGridView1, Service.GetData(int.Parse(COM_Page.Text), page, ref PageNum, ""));
            }

        }

        private void BT_UpPage_Click(object sender, EventArgs e)
        {
            int PageNum = 0, PageCount = 0;
            if (DataCount == 0)
                DataCount = Service.GetCount();
            int Mod = DataCount % int.Parse(COM_Page.Text);
            if (DataTotalPages == 0)
            {
                DataTotalPages = DataCount / int.Parse(COM_Page.Text);
                if (Mod != 0)
                    DataTotalPages += 1;
            }
            int page = int.Parse(COM_Skip.Text) - 1;
            if (page < 1)
                page = 1;
            PagingHelp<V_HoldAPosition>.PageUp(DataCount, COM_Page, COM_Skip, dataGridView1, Service.GetData(int.Parse(COM_Page.Text), page, ref PageNum, ""));
        }

        private void BT_NextPage_Click(object sender, EventArgs e)
        {
            int PageNum = 0, PageCount = 0;
            if (DataCount == 0)
                DataCount = Service.GetCount();
            int Mod = DataCount % int.Parse(COM_Page.Text);
            if (DataTotalPages == 0)
            {
                DataTotalPages = DataCount / int.Parse(COM_Page.Text);
                if (Mod != 0)
                    DataTotalPages += 1;
            }
            int page = int.Parse(COM_Skip.Text) + 1;
            if (page > DataTotalPages)
                page = DataTotalPages;
            PagingHelp<V_HoldAPosition>.NextPage(DataCount, COM_Page, COM_Skip, dataGridView1, Service.GetData(int.Parse(COM_Page.Text), page, ref PageNum, ""));
        }

        private void BT_TrailerPage_Click(object sender, EventArgs e)
        {

            int PageNum = 0, PageCount = 0;
            if (DataCount == 0)
                DataCount = Service.GetCount();
            int Mod = DataCount % int.Parse(COM_Page.Text);
            if (DataTotalPages == 0)
            {
                DataTotalPages = DataCount / int.Parse(COM_Page.Text);
                if (Mod != 0)
                    DataTotalPages += 1;
            }
            PagingHelp<V_HoldAPosition>.TrailerPage(DataCount, COM_Page, COM_Skip, dataGridView1, Service.GetData(int.Parse(COM_Page.Text), DataTotalPages, ref PageNum, ""));
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
                        contextMenuStrip1.Show(MousePosition.X, MousePosition.Y);
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void BT_HomePage_Click(object sender, EventArgs e)
        {
            int PageNum = 0, PageCount = 0;
            if (DataCount == 0)
                DataCount = Service.GetCount();
            int Mod = DataCount % int.Parse(COM_Page.Text);
            if (DataTotalPages == 0)
            {
                DataTotalPages = DataCount / int.Parse(COM_Page.Text);
                if (Mod != 0)
                    DataTotalPages += 1;
            }
            PagingHelp<V_HoldAPosition>.HomePage(DataCount, COM_Page, COM_Skip, dataGridView1, Service.GetData(int.Parse(COM_Page.Text), 1, ref PageNum, ""));
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void 新增ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FM_HoldAPositionEdit FN = new FM_HoldAPositionEdit();
            FN.Show();
        }

        private void Delete()
        {
            int index = dataGridView1.CurrentRow.Index;
            string Id = dataGridView1.Rows[index].Cells[0].Value.ToString();
            if (FHPSercice.Delete(Id))
            {
                int Mod = DataCount % int.Parse(COM_Page.Text);
                DataTotalPages = DataCount / int.Parse(COM_Page.Text);
                if (Mod != 0)
                    DataTotalPages += 1;
                int PageNum = 0, PageCount = 0;
                int page = int.Parse(COM_Skip.Text);
                dataGridView1.DataSource = new BindingList<V_HoldAPosition>(Service.GetData(int.Parse(COM_Page.Text), int.Parse(COM_Skip.Text), ref PageNum, ""));
            }
            else
            {
                MessageBox.Show("请重试！");
            }
        }
    }
}
