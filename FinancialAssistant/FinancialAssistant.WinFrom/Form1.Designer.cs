namespace FinancialAssistant.WinFrom
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.MTB_VID = new FinancialAssistant.Widget.Text.MarkTextBox();
            this.MTB_PWD = new FinancialAssistant.Widget.Text.MarkTextBox();
            this.MTB_ContentCode = new FinancialAssistant.Widget.Text.MarkTextBox();
            this.MTB_Original = new FinancialAssistant.Widget.Text.MarkTextBox();
            this.waterMarkTextBox11 = new FinancialAssistant.Widget.Text.MarkTextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(401, 291);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "加密";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(401, 330);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "解密";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(482, 291);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "高级加密";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(482, 330);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "高级解密";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "DES",
            "AES",
            "MD5"});
            this.comboBox1.Location = new System.Drawing.Point(51, 294);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 20);
            this.comboBox1.TabIndex = 10;
            // 
            // MTB_VID
            // 
            this.MTB_VID.Location = new System.Drawing.Point(178, 330);
            this.MTB_VID.Name = "MTB_VID";
            this.MTB_VID.Size = new System.Drawing.Size(189, 21);
            this.MTB_VID.TabIndex = 9;
            this.MTB_VID.WaterText = "请输入偏移量";
            // 
            // MTB_PWD
            // 
            this.MTB_PWD.Location = new System.Drawing.Point(178, 293);
            this.MTB_PWD.Name = "MTB_PWD";
            this.MTB_PWD.Size = new System.Drawing.Size(189, 21);
            this.MTB_PWD.TabIndex = 4;
            this.MTB_PWD.WaterText = "请输入密匙";
            this.MTB_PWD.TextChanged += new System.EventHandler(this.MTB_PWD_TextChanged);
            // 
            // MTB_ContentCode
            // 
            this.MTB_ContentCode.Location = new System.Drawing.Point(373, 1);
            this.MTB_ContentCode.Multiline = true;
            this.MTB_ContentCode.Name = "MTB_ContentCode";
            this.MTB_ContentCode.Size = new System.Drawing.Size(368, 277);
            this.MTB_ContentCode.TabIndex = 3;
            this.MTB_ContentCode.WaterText = "请输入待解密的内容...";
            // 
            // MTB_Original
            // 
            this.MTB_Original.Location = new System.Drawing.Point(-1, 1);
            this.MTB_Original.Multiline = true;
            this.MTB_Original.Name = "MTB_Original";
            this.MTB_Original.Size = new System.Drawing.Size(368, 277);
            this.MTB_Original.TabIndex = 2;
            this.MTB_Original.WaterText = "请输入待加密的内容...";
            // 
            // waterMarkTextBox11
            // 
            this.waterMarkTextBox11.Location = new System.Drawing.Point(12, 12);
            this.waterMarkTextBox11.Multiline = true;
            this.waterMarkTextBox11.Name = "waterMarkTextBox11";
            this.waterMarkTextBox11.Size = new System.Drawing.Size(130, 90);
            this.waterMarkTextBox11.TabIndex = 3;
            this.waterMarkTextBox11.WaterText = "放到";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(563, 291);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 11;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 366);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.MTB_VID);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.MTB_PWD);
            this.Controls.Add(this.MTB_ContentCode);
            this.Controls.Add(this.MTB_Original);
            this.Name = "Form1";
            this.Text = "加解密工具";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Widget.Text.MarkTextBox waterMarkTextBox11;
        private Widget.Text.MarkTextBox MTB_Original;
        private Widget.Text.MarkTextBox MTB_ContentCode;
        private Widget.Text.MarkTextBox MTB_PWD;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private Widget.Text.MarkTextBox MTB_VID;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button5;
    }
}

