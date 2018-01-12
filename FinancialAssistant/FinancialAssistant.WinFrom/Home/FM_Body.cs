using FinancialAssistant.Data;
using FinancialAssistant.DoMain.Fund;
using FinancialAssistant.WinFrom.FundCompany;
using FinancialAssistant.WinFrom.FundName;
using FinancialAssistant.WinFrom.HoldAPosition;
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
    }
}
