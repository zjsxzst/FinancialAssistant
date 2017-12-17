namespace FinancialAssistant.WinFrom.FundName
{
    partial class FM_FNList
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.添加ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BT_Clear = new System.Windows.Forms.Button();
            this.BT_Search = new System.Windows.Forms.Button();
            this.Com_FundCompany = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MTB_FundName = new FinancialAssistant.Widget.Text.MarkTextBox();
            this.MTB_FundID = new FinancialAssistant.Widget.Text.MarkTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FundName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Company = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BT_Skip = new System.Windows.Forms.Button();
            this.COM_Skip = new System.Windows.Forms.ComboBox();
            this.BT_TrailerPage = new System.Windows.Forms.Button();
            this.BT_HomePage = new System.Windows.Forms.Button();
            this.BT_NextPage = new System.Windows.Forms.Button();
            this.BT_UpPage = new System.Windows.Forms.Button();
            this.COM_Page = new System.Windows.Forms.ComboBox();
            this.LISTStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.添加ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.修改ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.删除ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.LISTStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加ToolStripMenuItem,
            this.修改ToolStripMenuItem,
            this.删除ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(672, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 添加ToolStripMenuItem
            // 
            this.添加ToolStripMenuItem.Name = "添加ToolStripMenuItem";
            this.添加ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.添加ToolStripMenuItem.Text = "添加";
            this.添加ToolStripMenuItem.Click += new System.EventHandler(this.添加ToolStripMenuItem_Click);
            // 
            // 修改ToolStripMenuItem
            // 
            this.修改ToolStripMenuItem.Name = "修改ToolStripMenuItem";
            this.修改ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.修改ToolStripMenuItem.Text = "修改";
            this.修改ToolStripMenuItem.Click += new System.EventHandler(this.修改ToolStripMenuItem_Click);
            // 
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            this.删除ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.删除ToolStripMenuItem.Text = "删除";
            this.删除ToolStripMenuItem.Click += new System.EventHandler(this.删除ToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BT_Clear);
            this.groupBox1.Controls.Add(this.BT_Search);
            this.groupBox1.Controls.Add(this.Com_FundCompany);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.MTB_FundName);
            this.groupBox1.Controls.Add(this.MTB_FundID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(672, 104);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "高级搜索";
            // 
            // BT_Clear
            // 
            this.BT_Clear.Location = new System.Drawing.Point(427, 66);
            this.BT_Clear.Name = "BT_Clear";
            this.BT_Clear.Size = new System.Drawing.Size(75, 23);
            this.BT_Clear.TabIndex = 7;
            this.BT_Clear.Text = "清空";
            this.BT_Clear.UseVisualStyleBackColor = true;
            this.BT_Clear.Click += new System.EventHandler(this.BT_Clear_Click);
            // 
            // BT_Search
            // 
            this.BT_Search.Location = new System.Drawing.Point(323, 66);
            this.BT_Search.Name = "BT_Search";
            this.BT_Search.Size = new System.Drawing.Size(75, 23);
            this.BT_Search.TabIndex = 6;
            this.BT_Search.Text = "搜索";
            this.BT_Search.UseVisualStyleBackColor = true;
            this.BT_Search.Click += new System.EventHandler(this.BT_Search_Click);
            // 
            // Com_FundCompany
            // 
            this.Com_FundCompany.FormattingEnabled = true;
            this.Com_FundCompany.Location = new System.Drawing.Point(86, 68);
            this.Com_FundCompany.Name = "Com_FundCompany";
            this.Com_FundCompany.Size = new System.Drawing.Size(185, 20);
            this.Com_FundCompany.TabIndex = 5;
            this.Com_FundCompany.TextUpdate += new System.EventHandler(this.Com_FundCompany_TextUpdate);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "基金公司：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(321, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "基金名：";
            // 
            // MTB_FundName
            // 
            this.MTB_FundName.Location = new System.Drawing.Point(380, 29);
            this.MTB_FundName.Name = "MTB_FundName";
            this.MTB_FundName.Size = new System.Drawing.Size(280, 21);
            this.MTB_FundName.TabIndex = 2;
            this.MTB_FundName.Tag = "";
            this.MTB_FundName.WaterText = "请输入基金名称";
            // 
            // MTB_FundID
            // 
            this.MTB_FundID.Location = new System.Drawing.Point(86, 29);
            this.MTB_FundID.Name = "MTB_FundID";
            this.MTB_FundID.Size = new System.Drawing.Size(185, 21);
            this.MTB_FundID.TabIndex = 1;
            this.MTB_FundID.WaterText = "请输入基金号";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "基金号：";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.FundName,
            this.Company});
            this.dataGridView1.Location = new System.Drawing.Point(0, 138);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(672, 296);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDown);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "基金号";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // FundName
            // 
            this.FundName.DataPropertyName = "FundName";
            this.FundName.HeaderText = "基金名";
            this.FundName.Name = "FundName";
            this.FundName.ReadOnly = true;
            // 
            // Company
            // 
            this.Company.DataPropertyName = "CompanyName";
            this.Company.HeaderText = "基金公司";
            this.Company.Name = "Company";
            this.Company.ReadOnly = true;
            // 
            // BT_Skip
            // 
            this.BT_Skip.Location = new System.Drawing.Point(368, 444);
            this.BT_Skip.Name = "BT_Skip";
            this.BT_Skip.Size = new System.Drawing.Size(75, 23);
            this.BT_Skip.TabIndex = 15;
            this.BT_Skip.Text = "跳转";
            this.BT_Skip.UseVisualStyleBackColor = true;
            this.BT_Skip.Click += new System.EventHandler(this.BT_Skip_Click);
            // 
            // COM_Skip
            // 
            this.COM_Skip.FormattingEnabled = true;
            this.COM_Skip.Location = new System.Drawing.Point(277, 447);
            this.COM_Skip.MaxDropDownItems = 10;
            this.COM_Skip.Name = "COM_Skip";
            this.COM_Skip.Size = new System.Drawing.Size(85, 20);
            this.COM_Skip.TabIndex = 14;
            // 
            // BT_TrailerPage
            // 
            this.BT_TrailerPage.Location = new System.Drawing.Point(530, 444);
            this.BT_TrailerPage.Name = "BT_TrailerPage";
            this.BT_TrailerPage.Size = new System.Drawing.Size(75, 23);
            this.BT_TrailerPage.TabIndex = 13;
            this.BT_TrailerPage.Text = "尾页";
            this.BT_TrailerPage.UseVisualStyleBackColor = true;
            this.BT_TrailerPage.Click += new System.EventHandler(this.BT_TrailerPage_Click);
            // 
            // BT_HomePage
            // 
            this.BT_HomePage.Location = new System.Drawing.Point(115, 444);
            this.BT_HomePage.Name = "BT_HomePage";
            this.BT_HomePage.Size = new System.Drawing.Size(75, 23);
            this.BT_HomePage.TabIndex = 12;
            this.BT_HomePage.Text = "首页";
            this.BT_HomePage.UseVisualStyleBackColor = true;
            this.BT_HomePage.Click += new System.EventHandler(this.BT_HomePage_Click);
            // 
            // BT_NextPage
            // 
            this.BT_NextPage.Location = new System.Drawing.Point(449, 444);
            this.BT_NextPage.Name = "BT_NextPage";
            this.BT_NextPage.Size = new System.Drawing.Size(75, 23);
            this.BT_NextPage.TabIndex = 11;
            this.BT_NextPage.Text = "下一页";
            this.BT_NextPage.UseVisualStyleBackColor = true;
            this.BT_NextPage.Click += new System.EventHandler(this.BT_NextPage_Click);
            // 
            // BT_UpPage
            // 
            this.BT_UpPage.Location = new System.Drawing.Point(196, 444);
            this.BT_UpPage.Name = "BT_UpPage";
            this.BT_UpPage.Size = new System.Drawing.Size(75, 23);
            this.BT_UpPage.TabIndex = 10;
            this.BT_UpPage.Text = "上一页";
            this.BT_UpPage.UseVisualStyleBackColor = true;
            this.BT_UpPage.Click += new System.EventHandler(this.BT_UpPage_Click);
            // 
            // COM_Page
            // 
            this.COM_Page.FormattingEnabled = true;
            this.COM_Page.Items.AddRange(new object[] {
            "10",
            "25",
            "50",
            "100"});
            this.COM_Page.Location = new System.Drawing.Point(9, 447);
            this.COM_Page.Name = "COM_Page";
            this.COM_Page.Size = new System.Drawing.Size(85, 20);
            this.COM_Page.TabIndex = 9;
            this.COM_Page.TextChanged += new System.EventHandler(this.COM_Page_TextChanged);
            // 
            // LISTStrip
            // 
            this.LISTStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加ToolStripMenuItem1,
            this.修改ToolStripMenuItem1,
            this.删除ToolStripMenuItem1});
            this.LISTStrip.Name = "LISTStrip";
            this.LISTStrip.Size = new System.Drawing.Size(101, 70);
            // 
            // 添加ToolStripMenuItem1
            // 
            this.添加ToolStripMenuItem1.Name = "添加ToolStripMenuItem1";
            this.添加ToolStripMenuItem1.Size = new System.Drawing.Size(100, 22);
            this.添加ToolStripMenuItem1.Text = "添加";
            this.添加ToolStripMenuItem1.Click += new System.EventHandler(this.添加ToolStripMenuItem1_Click);
            // 
            // 修改ToolStripMenuItem1
            // 
            this.修改ToolStripMenuItem1.Name = "修改ToolStripMenuItem1";
            this.修改ToolStripMenuItem1.Size = new System.Drawing.Size(100, 22);
            this.修改ToolStripMenuItem1.Text = "修改";
            this.修改ToolStripMenuItem1.Click += new System.EventHandler(this.修改ToolStripMenuItem1_Click);
            // 
            // 删除ToolStripMenuItem1
            // 
            this.删除ToolStripMenuItem1.Name = "删除ToolStripMenuItem1";
            this.删除ToolStripMenuItem1.Size = new System.Drawing.Size(100, 22);
            this.删除ToolStripMenuItem1.Text = "删除";
            this.删除ToolStripMenuItem1.Click += new System.EventHandler(this.删除ToolStripMenuItem1_Click);
            // 
            // FM_FNList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 476);
            this.Controls.Add(this.BT_Skip);
            this.Controls.Add(this.COM_Skip);
            this.Controls.Add(this.BT_TrailerPage);
            this.Controls.Add(this.BT_HomePage);
            this.Controls.Add(this.BT_NextPage);
            this.Controls.Add(this.BT_UpPage);
            this.Controls.Add(this.COM_Page);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FM_FNList";
            this.Text = "FM_FNList";
            this.Load += new System.EventHandler(this.FM_FNList_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.LISTStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 添加ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BT_Skip;
        private System.Windows.Forms.ComboBox COM_Skip;
        private System.Windows.Forms.Button BT_TrailerPage;
        private System.Windows.Forms.Button BT_HomePage;
        private System.Windows.Forms.Button BT_NextPage;
        private System.Windows.Forms.Button BT_UpPage;
        private System.Windows.Forms.ComboBox COM_Page;
        private System.Windows.Forms.Button BT_Clear;
        private System.Windows.Forms.Button BT_Search;
        private System.Windows.Forms.ComboBox Com_FundCompany;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Widget.Text.MarkTextBox MTB_FundName;
        private Widget.Text.MarkTextBox MTB_FundID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FundName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Company;
        private System.Windows.Forms.ContextMenuStrip LISTStrip;
        private System.Windows.Forms.ToolStripMenuItem 添加ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 修改ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem1;
    }
}