namespace FinancialAssistant.WinFrom.FundCompany
{
    partial class FM_FCEdit
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
            this.label1 = new System.Windows.Forms.Label();
            this.BT_ESC = new System.Windows.Forms.Button();
            this.BT_Save = new System.Windows.Forms.Button();
            this.markTextBox1 = new FinancialAssistant.Widget.Text.MarkTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "公司名称：";
            // 
            // BT_ESC
            // 
            this.BT_ESC.Location = new System.Drawing.Point(129, 33);
            this.BT_ESC.Name = "BT_ESC";
            this.BT_ESC.Size = new System.Drawing.Size(75, 23);
            this.BT_ESC.TabIndex = 6;
            this.BT_ESC.Text = "取消";
            this.BT_ESC.UseVisualStyleBackColor = true;
            this.BT_ESC.Click += new System.EventHandler(this.BT_ESC_Click);
            // 
            // BT_Save
            // 
            this.BT_Save.Location = new System.Drawing.Point(30, 33);
            this.BT_Save.Name = "BT_Save";
            this.BT_Save.Size = new System.Drawing.Size(75, 23);
            this.BT_Save.TabIndex = 5;
            this.BT_Save.Text = "确定";
            this.BT_Save.UseVisualStyleBackColor = true;
            this.BT_Save.Click += new System.EventHandler(this.BT_Save_Click);
            // 
            // markTextBox1
            // 
            this.markTextBox1.Location = new System.Drawing.Point(80, 6);
            this.markTextBox1.Name = "markTextBox1";
            this.markTextBox1.Size = new System.Drawing.Size(142, 21);
            this.markTextBox1.TabIndex = 4;
            this.markTextBox1.WaterText = "请输入公司名称";
            // 
            // FM_FCEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 66);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BT_ESC);
            this.Controls.Add(this.BT_Save);
            this.Controls.Add(this.markTextBox1);
            this.Name = "FM_FCEdit";
            this.Text = "FM_FCEdit";
            this.Load += new System.EventHandler(this.FM_FCEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BT_ESC;
        private System.Windows.Forms.Button BT_Save;
        private Widget.Text.MarkTextBox markTextBox1;
    }
}