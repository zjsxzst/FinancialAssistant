using FinancialAssistant.Data;
using FinancialAssistant.DoMain.Virtual;
using FinancialAssistant.Files;
using FinancialAssistant.Services.Sys;
using FinancialAssistant.Text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialAssistant.WinFrom
{
    public partial class FM_Login : Form
    {
        private UserServices UserServices = new UserServices();
        public FM_Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(UserServices.VerifyUser(MTB_UserName.Text.Trim(), MTB_PWD.Text.Trim()))
            {
                FM_Body FB = new FM_Body();
                this.Hide();
                FB.ShowDialog();
                this.Close();
                
            }
            else
            {
                MessageBox.Show("用户名或密码错误！", "提示",MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }



        private void BT_ESC_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
