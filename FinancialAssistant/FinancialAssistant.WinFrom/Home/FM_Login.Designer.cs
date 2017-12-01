namespace FinancialAssistant.WinFrom
{
    partial class FM_Login
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
            this.MTB_UserName = new FinancialAssistant.Widget.Text.MarkTextBox();
            this.MTB_PWD = new FinancialAssistant.Widget.Text.MarkTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BT_Save = new System.Windows.Forms.Button();
            this.BT_ESC = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MTB_UserName
            // 
            this.MTB_UserName.Location = new System.Drawing.Point(71, 12);
            this.MTB_UserName.Name = "MTB_UserName";
            this.MTB_UserName.Size = new System.Drawing.Size(244, 21);
            this.MTB_UserName.TabIndex = 0;
            this.MTB_UserName.WaterText = "请输入用户名";
            // 
            // MTB_PWD
            // 
            this.MTB_PWD.Location = new System.Drawing.Point(71, 39);
            this.MTB_PWD.Name = "MTB_PWD";
            this.MTB_PWD.PasswordChar = '❉';
            this.MTB_PWD.Size = new System.Drawing.Size(244, 21);
            this.MTB_PWD.TabIndex = 1;
            this.MTB_PWD.WaterText = "请输入密码";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "用户名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "密  码：";
            // 
            // BT_Save
            // 
            this.BT_Save.Location = new System.Drawing.Point(42, 99);
            this.BT_Save.Name = "BT_Save";
            this.BT_Save.Size = new System.Drawing.Size(75, 23);
            this.BT_Save.TabIndex = 4;
            this.BT_Save.Text = "登录";
            this.BT_Save.UseVisualStyleBackColor = true;
            this.BT_Save.Click += new System.EventHandler(this.button1_Click);
            // 
            // BT_ESC
            // 
            this.BT_ESC.Location = new System.Drawing.Point(207, 99);
            this.BT_ESC.Name = "BT_ESC";
            this.BT_ESC.Size = new System.Drawing.Size(75, 23);
            this.BT_ESC.TabIndex = 5;
            this.BT_ESC.Text = "取消";
            this.BT_ESC.UseVisualStyleBackColor = true;
            this.BT_ESC.Click += new System.EventHandler(this.BT_ESC_Click);
            // 
            // FM_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 154);
            this.Controls.Add(this.BT_ESC);
            this.Controls.Add(this.BT_Save);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MTB_PWD);
            this.Controls.Add(this.MTB_UserName);
            this.Name = "FM_Login";
            this.Text = "FM_Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Widget.Text.MarkTextBox MTB_UserName;
        private Widget.Text.MarkTextBox MTB_PWD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BT_Save;
        private System.Windows.Forms.Button BT_ESC;
    }
}