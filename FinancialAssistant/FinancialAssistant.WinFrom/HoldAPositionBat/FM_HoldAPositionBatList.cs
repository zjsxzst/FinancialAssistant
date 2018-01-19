using FinancialAssistant.Data;
using FinancialAssistant.DoMain.Fund;
using FinancialAssistant.DoMain.V;
using FinancialAssistant.Services.V;
using FinancialAssistant.WinFrom.APP;
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

namespace FinancialAssistant.WinFrom.HoldAPositionBat
{
    public partial class FM_HoldAPositionBatList : Form
    {
        private int DataCount = 0, DataTotalPages = 0;
        V_HoldAPositionBatService Service = new V_HoldAPositionBatService();
        public FM_HoldAPositionBatList()
        {
            InitializeComponent();
        }

        private void FM_HoldAPositionBatList_Load(object sender, EventArgs e)
        {
            COM_Page.Text = "10";
            int PageNum = 0, PageCount = 0;
            dataGridView1.DataSource = new BindingList<V_HoldAPositionBat>(Service.GetData(10, 1, ref PageNum, ""));
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
                DataCount = Service.GetCount();
            int Mod = DataCount % int.Parse(COM_Page.Text);
            if (DataTotalPages == 0)
            {
                DataTotalPages = DataCount / int.Parse(COM_Page.Text);
                if (Mod != 0)
                    DataTotalPages += 1;
            }
            PagingHelp<V_HoldAPositionBat>.HomePage(DataCount, COM_Page, COM_Skip, dataGridView1, Service.GetData(int.Parse(COM_Page.Text), 1, ref PageNum, ""));
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
                PagingHelp<V_HoldAPositionBat>.PageSkip(DataCount, COM_Page, COM_Skip, dataGridView1, Service.GetData(int.Parse(COM_Page.Text), page, ref PageNum, ""));
            }
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
            PagingHelp<V_HoldAPositionBat>.NextPage(DataCount, COM_Page, COM_Skip, dataGridView1, Service.GetData(int.Parse(COM_Page.Text), page, ref PageNum, ""));
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
            PagingHelp<V_HoldAPositionBat>.TrailerPage(DataCount, COM_Page, COM_Skip, dataGridView1, Service.GetData(int.Parse(COM_Page.Text), DataTotalPages, ref PageNum, ""));
        }

        private void COM_Page_TextUpdate(object sender, EventArgs e)
        {
            int PageNum = 0, PageCount = 0;
            dataGridView1.DataSource = new BindingList<V_HoldAPositionBat>(Service.GetData(int.Parse(COM_Page.Text), 1, ref PageNum, ""));
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

        private void 修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Edit();
        }
        private void Edit()
        {
            int index = dataGridView1.CurrentRow.Index;
            string Where = "OrderNumber='{0}'";
            string ON = dataGridView1.Rows[index].Cells["OrderNumber"].Value.ToString();
            string sql = GroupSQL.Select(new Fund_HoldAPositionBat(), string.Format(Where,ON));
            IList<Fund_HoldAPositionBat> List=SqlProcessing<Fund_HoldAPositionBat>.ExeQuerys(sql);
            if(List.Count>0)
            {
                FM_HoldAPositionEdit FE = new FM_HoldAPositionEdit(List[0], dataGridView1.Rows[index].Cells["FundName"].Value.ToString());
                FE.Show();
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
            PagingHelp<V_HoldAPositionBat>.PageUp(DataCount, COM_Page, COM_Skip, dataGridView1, Service.GetData(int.Parse(COM_Page.Text), page, ref PageNum, ""));
        }
    }
}
