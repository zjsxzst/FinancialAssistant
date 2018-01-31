namespace FinancialAssistant.WinFrom.HistoricalPrice
{
    partial class FM_HistoricalPriceList
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
            this.新增ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.BT_HomePage = new System.Windows.Forms.Button();
            this.BT_TrailerPage = new System.Windows.Forms.Button();
            this.BT_NextPage = new System.Windows.Forms.Button();
            this.BT_Skip = new System.Windows.Forms.Button();
            this.COM_Skip = new System.Windows.Forms.ComboBox();
            this.BT_UpPage = new System.Windows.Forms.Button();
            this.COM_Page = new System.Windows.Forms.ComboBox();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FundName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InputDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FundID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompanyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InVain = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sources = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.新增ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.修改ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新增ToolStripMenuItem,
            this.修改ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(747, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 新增ToolStripMenuItem
            // 
            this.新增ToolStripMenuItem.Name = "新增ToolStripMenuItem";
            this.新增ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.新增ToolStripMenuItem.Text = "新增";
            this.新增ToolStripMenuItem.Click += new System.EventHandler(this.新增ToolStripMenuItem_Click);
            // 
            // 修改ToolStripMenuItem
            // 
            this.修改ToolStripMenuItem.Name = "修改ToolStripMenuItem";
            this.修改ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.修改ToolStripMenuItem.Text = "修改";
            this.修改ToolStripMenuItem.Click += new System.EventHandler(this.修改ToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(747, 94);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "高级查询";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.UnitPrice,
            this.FundName,
            this.InputDate,
            this.FundID,
            this.CompanyName,
            this.InVain,
            this.Remark,
            this.Sources});
            this.dataGridView1.Location = new System.Drawing.Point(0, 128);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(747, 261);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(673, 408);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 12);
            this.label1.TabIndex = 33;
            this.label1.Text = "N/A";
            // 
            // BT_HomePage
            // 
            this.BT_HomePage.Location = new System.Drawing.Point(146, 404);
            this.BT_HomePage.Name = "BT_HomePage";
            this.BT_HomePage.Size = new System.Drawing.Size(75, 23);
            this.BT_HomePage.TabIndex = 32;
            this.BT_HomePage.Text = "首页";
            this.BT_HomePage.UseVisualStyleBackColor = true;
            this.BT_HomePage.Click += new System.EventHandler(this.BT_HomePage_Click);
            // 
            // BT_TrailerPage
            // 
            this.BT_TrailerPage.Location = new System.Drawing.Point(550, 403);
            this.BT_TrailerPage.Name = "BT_TrailerPage";
            this.BT_TrailerPage.Size = new System.Drawing.Size(75, 23);
            this.BT_TrailerPage.TabIndex = 31;
            this.BT_TrailerPage.Text = "尾页";
            this.BT_TrailerPage.UseVisualStyleBackColor = true;
            this.BT_TrailerPage.Click += new System.EventHandler(this.BT_TrailerPage_Click);
            // 
            // BT_NextPage
            // 
            this.BT_NextPage.Location = new System.Drawing.Point(470, 403);
            this.BT_NextPage.Name = "BT_NextPage";
            this.BT_NextPage.Size = new System.Drawing.Size(75, 23);
            this.BT_NextPage.TabIndex = 30;
            this.BT_NextPage.Text = "下一页";
            this.BT_NextPage.UseVisualStyleBackColor = true;
            this.BT_NextPage.Click += new System.EventHandler(this.BT_NextPage_Click);
            // 
            // BT_Skip
            // 
            this.BT_Skip.Location = new System.Drawing.Point(390, 403);
            this.BT_Skip.Name = "BT_Skip";
            this.BT_Skip.Size = new System.Drawing.Size(75, 23);
            this.BT_Skip.TabIndex = 29;
            this.BT_Skip.Text = "跳转";
            this.BT_Skip.UseVisualStyleBackColor = true;
            this.BT_Skip.Click += new System.EventHandler(this.BT_Skip_Click);
            // 
            // COM_Skip
            // 
            this.COM_Skip.FormattingEnabled = true;
            this.COM_Skip.Location = new System.Drawing.Point(306, 404);
            this.COM_Skip.Name = "COM_Skip";
            this.COM_Skip.Size = new System.Drawing.Size(79, 20);
            this.COM_Skip.TabIndex = 28;
            // 
            // BT_UpPage
            // 
            this.BT_UpPage.Location = new System.Drawing.Point(226, 403);
            this.BT_UpPage.Name = "BT_UpPage";
            this.BT_UpPage.Size = new System.Drawing.Size(75, 23);
            this.BT_UpPage.TabIndex = 27;
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
            this.COM_Page.Location = new System.Drawing.Point(56, 404);
            this.COM_Page.Name = "COM_Page";
            this.COM_Page.Size = new System.Drawing.Size(85, 20);
            this.COM_Page.TabIndex = 26;
            this.COM_Page.TextUpdate += new System.EventHandler(this.COM_Page_TextUpdate);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "唯一号";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // UnitPrice
            // 
            this.UnitPrice.DataPropertyName = "UnitPrice";
            this.UnitPrice.HeaderText = "单价";
            this.UnitPrice.Name = "UnitPrice";
            this.UnitPrice.ReadOnly = true;
            // 
            // FundName
            // 
            this.FundName.DataPropertyName = "FundName";
            this.FundName.HeaderText = "基金名";
            this.FundName.Name = "FundName";
            this.FundName.ReadOnly = true;
            // 
            // InputDate
            // 
            this.InputDate.DataPropertyName = "InputDate";
            this.InputDate.HeaderText = "日期";
            this.InputDate.Name = "InputDate";
            this.InputDate.ReadOnly = true;
            // 
            // FundID
            // 
            this.FundID.DataPropertyName = "FundID";
            this.FundID.HeaderText = "基金号";
            this.FundID.Name = "FundID";
            this.FundID.ReadOnly = true;
            // 
            // CompanyName
            // 
            this.CompanyName.DataPropertyName = "CompanyName";
            this.CompanyName.HeaderText = "基金公司";
            this.CompanyName.Name = "CompanyName";
            this.CompanyName.ReadOnly = true;
            // 
            // InVain
            // 
            this.InVain.DataPropertyName = "InVain";
            this.InVain.HeaderText = "状态";
            this.InVain.Name = "InVain";
            this.InVain.ReadOnly = true;
            // 
            // Remark
            // 
            this.Remark.DataPropertyName = "Remark";
            this.Remark.HeaderText = "备注";
            this.Remark.Name = "Remark";
            this.Remark.ReadOnly = true;
            // 
            // Sources
            // 
            this.Sources.DataPropertyName = "Sources";
            this.Sources.HeaderText = "来源";
            this.Sources.Name = "Sources";
            this.Sources.ReadOnly = true;
            this.Sources.Visible = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新增ToolStripMenuItem1,
            this.修改ToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(101, 48);
            // 
            // 新增ToolStripMenuItem1
            // 
            this.新增ToolStripMenuItem1.Name = "新增ToolStripMenuItem1";
            this.新增ToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.新增ToolStripMenuItem1.Text = "新增";
            this.新增ToolStripMenuItem1.Click += new System.EventHandler(this.新增ToolStripMenuItem1_Click);
            // 
            // 修改ToolStripMenuItem1
            // 
            this.修改ToolStripMenuItem1.Name = "修改ToolStripMenuItem1";
            this.修改ToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.修改ToolStripMenuItem1.Text = "修改";
            this.修改ToolStripMenuItem1.Click += new System.EventHandler(this.修改ToolStripMenuItem1_Click);
            // 
            // FM_HistoricalPriceList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 438);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BT_HomePage);
            this.Controls.Add(this.BT_TrailerPage);
            this.Controls.Add(this.BT_NextPage);
            this.Controls.Add(this.BT_Skip);
            this.Controls.Add(this.COM_Skip);
            this.Controls.Add(this.BT_UpPage);
            this.Controls.Add(this.COM_Page);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FM_HistoricalPriceList";
            this.Text = "FM_HistoricalPriceList";
            this.Load += new System.EventHandler(this.FM_HistoricalPriceList_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 新增ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改ToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BT_HomePage;
        private System.Windows.Forms.Button BT_TrailerPage;
        private System.Windows.Forms.Button BT_NextPage;
        private System.Windows.Forms.Button BT_Skip;
        private System.Windows.Forms.ComboBox COM_Skip;
        private System.Windows.Forms.Button BT_UpPage;
        private System.Windows.Forms.ComboBox COM_Page;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn FundName;
        private System.Windows.Forms.DataGridViewTextBoxColumn InputDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn FundID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompanyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn InVain;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remark;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sources;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 新增ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 修改ToolStripMenuItem1;
    }
}