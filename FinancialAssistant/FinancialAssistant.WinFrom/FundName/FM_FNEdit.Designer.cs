namespace FinancialAssistant.WinFrom.FundName
{
    partial class FM_FNEdit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BT_ESC = new System.Windows.Forms.Button();
            this.BT_Save = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.markTextBox1 = new FinancialAssistant.Widget.Text.MarkTextBox();
            this.ComBox_Company = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.markTextBox2 = new FinancialAssistant.Widget.Text.MarkTextBox();
            this.SuspendLayout();
            // 
            // BT_ESC
            // 
            this.BT_ESC.Location = new System.Drawing.Point(159, 95);
            this.BT_ESC.Name = "BT_ESC";
            this.BT_ESC.Size = new System.Drawing.Size(75, 23);
            this.BT_ESC.TabIndex = 11;
            this.BT_ESC.Text = "取消";
            this.BT_ESC.UseVisualStyleBackColor = true;
            this.BT_ESC.Click += new System.EventHandler(this.BT_ESC_Click);
            // 
            // BT_Save
            // 
            this.BT_Save.Location = new System.Drawing.Point(50, 95);
            this.BT_Save.Name = "BT_Save";
            this.BT_Save.Size = new System.Drawing.Size(75, 23);
            this.BT_Save.TabIndex = 10;
            this.BT_Save.Text = "确定";
            this.BT_Save.UseVisualStyleBackColor = true;
            this.BT_Save.Click += new System.EventHandler(this.BT_Save_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "基金公司：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "基金名：";
            // 
            // markTextBox1
            // 
            this.markTextBox1.Location = new System.Drawing.Point(71, 42);
            this.markTextBox1.Name = "markTextBox1";
            this.markTextBox1.Size = new System.Drawing.Size(201, 21);
            this.markTextBox1.TabIndex = 7;
            this.markTextBox1.WaterText = "请输入基金名";
            // 
            // ComBox_Company
            // 
            this.ComBox_Company.FormattingEnabled = true;
            this.ComBox_Company.Location = new System.Drawing.Point(83, 69);
            this.ComBox_Company.Name = "ComBox_Company";
            this.ComBox_Company.Size = new System.Drawing.Size(189, 20);
            this.ComBox_Company.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 13;
            this.label3.Text = "基金号：";
            // 
            // markTextBox2
            // 
            this.markTextBox2.Location = new System.Drawing.Point(71, 15);
            this.markTextBox2.Name = "markTextBox2";
            this.markTextBox2.Size = new System.Drawing.Size(201, 21);
            this.markTextBox2.TabIndex = 12;
            this.markTextBox2.WaterText = "请输入基金号";
            // 
            // FM_FNEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 122);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.markTextBox2);
            this.Controls.Add(this.BT_ESC);
            this.Controls.Add(this.BT_Save);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.markTextBox1);
            this.Controls.Add(this.ComBox_Company);
            this.Name = "FM_FNEdit";
            this.Text = "FM_FNEdit";
            this.Load += new System.EventHandler(this.FM_FNEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BT_ESC;
        private System.Windows.Forms.Button BT_Save;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Widget.Text.MarkTextBox markTextBox1;
        private System.Windows.Forms.ComboBox ComBox_Company;
        private System.Windows.Forms.Label label3;
        private Widget.Text.MarkTextBox markTextBox2;
    }
}