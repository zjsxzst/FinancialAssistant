using FinancialAssistant.Text;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string PWD = "", VID = "";
            PWD = MTB_PWD.Text;
            VID = MTB_VID.Text;
            if (!string.IsNullOrWhiteSpace(MTB_Original.Text) && !string.IsNullOrWhiteSpace(PWD))
            {
                //if (string.IsNullOrWhiteSpace(VID))
                //    VID = PWD;
                //VID=Encryption.GetAESsIV();
                MTB_ContentCode.Text = Encryption.AESEncrypt(MTB_Original.Text, PWD);
                    /* Encryption.AESEncrypt(MTB_Original.Text, MTB_PWD.Text, VID);*/
                MTB_VID.Text = VID;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string PWD = "", VID = "";
            PWD = MTB_PWD.Text;
            VID = MTB_VID.Text;
            if (!string.IsNullOrWhiteSpace(MTB_Original.Text) && !string.IsNullOrWhiteSpace(PWD))
            {
                if (string.IsNullOrWhiteSpace(VID))
                    VID = PWD;
                MTB_ContentCode.Text = Encryption.TransformationMD5(MTB_Original.Text);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string PWD = "", VID = "";
            PWD = MTB_PWD.Text;
            VID = MTB_VID.Text;
            if (!string.IsNullOrWhiteSpace(MTB_ContentCode.Text) && !string.IsNullOrWhiteSpace(PWD))
            {
                if (string.IsNullOrWhiteSpace(VID))
                    VID = PWD;
                MTB_ContentCode.Text = 
                MTB_Original.Text = Encryption.AESDecrypt(MTB_ContentCode.Text, PWD);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string PWD = "", VID = "";
            PWD = MTB_PWD.Text;
            VID = MTB_VID.Text;
            if (!string.IsNullOrWhiteSpace(MTB_ContentCode.Text) && !string.IsNullOrWhiteSpace(PWD))
            {
                if (string.IsNullOrWhiteSpace(VID))
                    VID = PWD;
                Random ran = new Random();
                MTB_Original.Text= ran.Next(100, 999).ToString()+DataTimes.StrConvertDateTimeToInt(DateTime.Now);
            }
        }

        private void MTB_PWD_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Text = "请选择加密方式";
        }
    }
}
