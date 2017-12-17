using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialAssistant.WinFrom.APP
{
    public class PagingHelp<T> where T : new()
    {
        /// <summary>
        /// 首页
        /// </summary>
        /// <param name="Count">总列数</param>
        /// <param name="ComboBox">单页显示条数</param>
        /// <param name="Pagination">页数</param>
        /// <param name="dataGridView"></param>
        /// <param name="Data">数据</param>
        public static void HomePage(int Count, ComboBox ComboBox,ComboBox Pagination,DataGridView dataGridView, IList<T> Data)
        {
            //int Count = V_HoldAPositionService.GetCount();
            List<int> data = new List<int>();
            int num = Count / int.Parse(ComboBox.Text) + 1, endnum = 1;
            if (endnum + 5 > num)
                endnum = num;
            else
                endnum += 5;
            for (int i = 1; i <= endnum; i++)
                data.Add(i);
            Pagination.DataSource = new BindingList<int>(data);
            Pagination.Text = "1";
            dataGridView.DataSource = new BindingList<T>(Data);
        }
        /// <summary>
        /// 上一页
        /// </summary>
        /// <param name="Count">总列数</param>
        /// <param name="ComboBox">单页显示条数</param>
        /// <param name="Pagination">页数</param>
        /// <param name="dataGridView"></param>
        /// <param name="Data">数据</param>
        public static void PageUp(int Count, ComboBox ComboBox, ComboBox Pagination, DataGridView dataGridView, IList<T> Data)
        {
            List<int> data = new List<int>();
            int page = int.Parse(Pagination.Text);
            int num = Count / int.Parse(ComboBox.Text) + 1, startnum = int.Parse(Pagination.Text), endnum = int.Parse(Pagination.Text);
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
            int start = int.Parse(ComboBox.Text) * (int.Parse(Pagination.Text) - 2) + 1;
            int end = int.Parse(ComboBox.Text) * (int.Parse(Pagination.Text) - 1);
            if (Data.Count != 0)
            {
                dataGridView.DataSource = new BindingList<T>(Data);
                Pagination.DataSource = new BindingList<int>(data);
                Pagination.Text = (page - 1).ToString();
            }
        }
        /// <summary>
        /// 跳转
        /// </summary>
        /// <param name="Count">总列数</param>
        /// <param name="ComboBox">单页显示条数</param>
        /// <param name="Pagination">页数</param>
        /// <param name="dataGridView"></param>
        /// <param name="Data">数据</param>
        public static void PageSkip(int Count, ComboBox ComboBox, ComboBox Pagination, DataGridView dataGridView, IList<T> Data)
        {
            List<int> data = new List<int>();
            int page = int.Parse(Pagination.Text);
            int num = Count / int.Parse(ComboBox.Text) + 1, startnum = int.Parse(Pagination.Text), endnum = int.Parse(Pagination.Text);
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
                int start = int.Parse(ComboBox.Text) * (int.Parse(Pagination.Text) - 1) + 1;
                int end = int.Parse(ComboBox.Text) * (int.Parse(Pagination.Text));
                if (Data.Count != 0)
                {
                    dataGridView.DataSource = new BindingList<T>(Data);
                    Pagination.DataSource = new BindingList<int>(data);
                    Pagination.Text = (page).ToString();
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
        /// <summary>
        /// 下一页
        /// </summary>
        /// <param name="Count">总列数</param>
        /// <param name="ComboBox">单页显示条数</param>
        /// <param name="Pagination">页数</param>
        /// <param name="dataGridView"></param>
        /// <param name="Data">数据</param>
        public static void NextPage(int Count, ComboBox ComboBox, ComboBox Pagination, DataGridView dataGridView, IList<T> Data)
        {
            List<int> data = new List<int>();
            int page = int.Parse(Pagination.Text);
            int num = Count / int.Parse(ComboBox.Text) + 1, startnum = int.Parse(Pagination.Text), endnum = int.Parse(Pagination.Text);
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
            int start = int.Parse(ComboBox.Text) * (int.Parse(Pagination.Text)) + 1;
            int end = int.Parse(ComboBox.Text) * (int.Parse(Pagination.Text) + 1);
            if (Data.Count != 0)
            {
                dataGridView.DataSource = new BindingList<T>(Data);
                Pagination.DataSource = new BindingList<int>(data);
                Pagination.Text = (page + 1).ToString();
            }
        }
        /// <summary>
        /// 尾页
        /// </summary>
        /// <param name="Count">总列数</param>
        /// <param name="ComboBox">单页显示条数</param>
        /// <param name="Pagination">页数</param>
        /// <param name="dataGridView"></param>
        /// <param name="Data">数据</param>
        public static void TrailerPage(int Count, ComboBox ComboBox, ComboBox Pagination, DataGridView dataGridView, IList<T> Data)
        {
            List<int> data = new List<int>();
            int num = Count / int.Parse(ComboBox.Text) + 1, startnum = int.Parse(Pagination.Text);

            if (startnum - 5 <= 0)
                startnum = 1;
            else
                startnum = startnum - 5;
            for (int i = startnum; i <= num; i++)
                data.Add(i);
            int start = (num - 1) * (int.Parse(ComboBox.Text)) + 1;
            int end = Count;
            if (Data.Count != 0)
                dataGridView.DataSource = new BindingList<T>(Data);
            Pagination.DataSource = new BindingList<int>(data);
            Pagination.Text = (num).ToString();
        }
    }
}
