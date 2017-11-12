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
                if (string.IsNullOrWhiteSpace(VID))
                    VID = PWD;
                switch(comboBox1.Text)
                {
                    case "DES":
                        MTB_ContentCode.Text = Encryption.DESEncrypt(MTB_Original.Text, PWD, VID);
                        MTB_VID.Text = VID;
                        break;
                    case "AES":
                        MTB_ContentCode.Text = Encryption.AESEncrypt(MTB_Original.Text, PWD);
                        break;
                    case "MD5":
                        MTB_ContentCode.Text = Encryption.TransformationMD5(MTB_Original.Text);
                        break;
                }
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
                switch (comboBox1.Text)
                {
                    case "DES":
                        
                        MTB_ContentCode.Text = Encryption.SuperEncrypt(MTB_Original.Text, PWD, VID);
                        MTB_VID.Text = VID;
                        break;
                    case "AES":
                        MTB_ContentCode.Text = Encryption.SuperAESEncrypt(MTB_Original.Text, PWD);
                        break;
                    default:
                        MessageBox.Show("该方法没有高级加密方式！");
                        break;
                }
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
                switch (comboBox1.Text)
                {
                    case "DES":
                        MTB_Original.Text = Encryption.DesDecrypt(MTB_ContentCode.Text, PWD, VID);
                        MTB_VID.Text = VID;
                        break;
                    case "AES":
                        MTB_Original.Text = Encryption.AESDecrypt(MTB_ContentCode.Text, PWD);
                        break;
                    default:
                        MessageBox.Show("该方法没有解密方式！");
                        break;
                }
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
                switch (comboBox1.Text)
                {
                    case "DES":
                        MTB_Original.Text = Encryption.SuperDesDecrypt(MTB_ContentCode.Text, PWD, VID);
                        MTB_VID.Text = VID;
                        break;
                    case "AES":
                        MTB_Original.Text = Encryption.SuperAESDecrypt(MTB_ContentCode.Text, PWD);
                        break;
                    default:
                        MessageBox.Show("该方法没有解密方式！");
                        break;
                }
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
