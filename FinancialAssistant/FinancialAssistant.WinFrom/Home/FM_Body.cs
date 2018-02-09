using FinancialAssistant.Data;
using FinancialAssistant.DoMain.Fund;
using FinancialAssistant.WinFrom.FundCompany;
using FinancialAssistant.WinFrom.FundName;
using FinancialAssistant.WinFrom.HistoricalPrice;
using FinancialAssistant.WinFrom.HoldAPosition;
using FinancialAssistant.WinFrom.HoldAPositionBat;
using FinancialAssistant.WinFrom.List;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialAssistant.WinFrom
{
    public partial class FM_Body : Form
    {
        public FM_Body()
        {
            InitializeComponent();
        }

        private void 加解密工具ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 F1 = new Form1();
            F1.Show();
        }

        private void 列表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FM_List FL = new FM_List();
            //FL.Show();
            FM_FNList FF = new FM_FNList();
            FF.Show();
        }

        private void FM_Body_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void FM_Body_Load(object sender, EventArgs e)
        {

        }

        private void 持仓ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FM_FCList FC = new FM_FCList();
            FC.Show();
        }

        private void 持仓列表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FM_HoldAPositionList FH = new FM_HoldAPositionList();
            FH.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            test ts = new test();
            ReflectClass.GetElementNameList(ts);
        }

        private void 历史清单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FM_HoldAPositionBatList FH = new FM_HoldAPositionBatList();
            FH.Show();
        }

        private void 每日单价ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FM_HistoricalPriceList FH = new FM_HistoricalPriceList();
            FH.Show();
        }

        private void 数据分析ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FM_HistoricalPriceAnalyze FH = new FM_HistoricalPriceAnalyze();
            FH.Show();
        }
    }
}
