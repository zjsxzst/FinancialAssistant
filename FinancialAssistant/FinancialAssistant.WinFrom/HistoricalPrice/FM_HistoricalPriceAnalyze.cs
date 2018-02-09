using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialAssistant.WinFrom.HistoricalPrice
{
    public partial class FM_HistoricalPriceAnalyze : Form
    {
        public FM_HistoricalPriceAnalyze()
        {
            InitializeComponent();
            int count = this.Controls.Count * 2 + 2;
            float[] factor = new float[count];
            int i = 0;
            factor[i++] = Size.Width;
            factor[i++] = Size.Height;
            foreach (Control ctrl in this.Controls)
            {
                factor[i++] = ctrl.Location.X / (float)Size.Width;
                factor[i++] = ctrl.Location.Y / (float)Size.Height;
                ctrl.Tag = ctrl.Size;//!!!
            }
            Tag = factor;
        }

        private void FM_HistoricalPriceAnalyze_Load(object sender, EventArgs e)
        {
            string[] x = new string[] { "南山大队", "福田大队", "罗湖大队", "宝安大队", "指挥处", "大帝科技", "南山大队", "福田大队", "罗湖大队", "宝安大队", "指挥处", "大帝科技" };
            double[] y = new double[] { 541, 574, 345, 854, 684, 257, 541, 574, 345, 854, 684, 257 };
            string[] z = new string[] { "", "", "", "", "", "", "", "", "", "", "", "" };

            string[] a = new string[] { "南山大队", "福田大队", "罗湖大队", "宝安大队", "指挥处", };
            double[] b = new double[] { 541, 574, 345, 854, 257 };
            chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = true;
            chart1 .ChartAreas[0].AxisY.MajorGrid.LineColor = ColorTranslator.FromHtml("#2c4c6d");
            chart1.Series[0].Points.DataBindXY(x, y);
            chart1.Series[0].Points[0].Color = Color.White;
            //chart1.Series[0].Palette = ChartColorPalette.Bright;
        }

        private void FM_HistoricalPriceAnalyze_Resize(object sender, EventArgs e)
        {
            float[] scale = (float[])Tag;
            int i = 2;

            foreach (Control ctrl in this.Controls)
            {
                ctrl.Left = (int)(Size.Width * scale[i++]);
                ctrl.Top = (int)(Size.Height * scale[i++]);
                ctrl.Width = (int)(Size.Width / (float)scale[0] * ((Size)ctrl.Tag).Width);//!!!
                ctrl.Height = (int)(Size.Height / (float)scale[1] * ((Size)ctrl.Tag).Height);//!!!

                //每次使用的都是最初始的控件大小，保证准确无误。
            }
        }
    }
}
