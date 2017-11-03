﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialAssistant.Widget.Text
{
    /// <summary>
    /// 添加水印的TextBox
    /// WaterText属性为水印文字
    /// </summary>
    public partial class MarkTextBox : TextBox
    {
        private readonly Label lblwaterText = new Label();

        public MarkTextBox()
        {
            InitializeComponent();
            lblwaterText.BorderStyle = BorderStyle.None;
            lblwaterText.Enabled = false;
            lblwaterText.BackColor = Color.White;
            lblwaterText.AutoSize = false;
            lblwaterText.Top = 1;
            lblwaterText.Left = 2;
            lblwaterText.FlatStyle = FlatStyle.System;
            Controls.Add(lblwaterText);
        }

        public string WaterText
        {
            get { return lblwaterText.Text; }
            set { lblwaterText.Text = value; }
        }

        public override string Text
        {
            set
            {
                lblwaterText.Visible = value == string.Empty;
                base.Text = value;
            }
            get
            {
                return base.Text;
            }
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            if (Multiline && (ScrollBars == ScrollBars.Vertical || ScrollBars == ScrollBars.Both))
                lblwaterText.Width = Width - 20;
            else
                lblwaterText.Width = Width;
            lblwaterText.Height = Height - 2;
            base.OnSizeChanged(e);
        }

        protected override void OnTextChanged(EventArgs e)
        {
            lblwaterText.Visible = base.Text == string.Empty;
            base.OnTextChanged(e);
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            lblwaterText.Visible = false;
            base.OnMouseDown(e);
        }

        protected override void OnGotFocus(EventArgs e)
        {
            lblwaterText.Visible = base.Text == string.Empty;
            base.OnGotFocus(e);
        }


        protected override void OnLostFocus(EventArgs e)
        {
            lblwaterText.Visible = base.Text == string.Empty;
            base.OnLostFocus(e);
        }
    }
}
