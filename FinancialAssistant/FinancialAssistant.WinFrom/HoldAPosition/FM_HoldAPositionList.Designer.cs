namespace FinancialAssistant.WinFrom.HoldAPosition
{
    partial class FM_HoldAPositionList
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
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FundName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompanyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BT_HomePage = new System.Windows.Forms.Button();
            this.BT_TrailerPage = new System.Windows.Forms.Button();
            this.BT_NextPage = new System.Windows.Forms.Button();
            this.BT_Skip = new System.Windows.Forms.Button();
            this.COM_Skip = new System.Windows.Forms.ComboBox();
            this.BT_UpPage = new System.Windows.Forms.Button();
            this.COM_Page = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.新建ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.删除ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新增ToolStripMenuItem,
            this.修改ToolStripMenuItem,
            this.删除ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(701, 25);
            this.menuStrip1.TabIndex = 0;
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
            this.groupBox1.Location = new System.Drawing.Point(0, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(701, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "高级搜索";
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
            this.UnitPrice,
            this.Quantity,
            this.CompanyName});
            this.dataGridView1.Location = new System.Drawing.Point(6, 134);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(695, 242);
            this.dataGridView1.TabIndex = 2;
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
            // UnitPrice
            // 
            this.UnitPrice.DataPropertyName = "UnitPrice";
            this.UnitPrice.HeaderText = "单价";
            this.UnitPrice.Name = "UnitPrice";
            this.UnitPrice.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "持有量";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // CompanyName
            // 
            this.CompanyName.DataPropertyName = "CompanyName";
            this.CompanyName.HeaderText = "基金公司";
            this.CompanyName.Name = "CompanyName";
            this.CompanyName.ReadOnly = true;
            // 
            // BT_HomePage
            // 
            this.BT_HomePage.Location = new System.Drawing.Point(102, 389);
            this.BT_HomePage.Name = "BT_HomePage";
            this.BT_HomePage.Size = new System.Drawing.Size(75, 23);
            this.BT_HomePage.TabIndex = 16;
            this.BT_HomePage.Text = "首页";
            this.BT_HomePage.UseVisualStyleBackColor = true;
            this.BT_HomePage.Click += new System.EventHandler(this.BT_HomePage_Click);
            // 
            // BT_TrailerPage
            // 
            this.BT_TrailerPage.Location = new System.Drawing.Point(506, 388);
            this.BT_TrailerPage.Name = "BT_TrailerPage";
            this.BT_TrailerPage.Size = new System.Drawing.Size(75, 23);
            this.BT_TrailerPage.TabIndex = 15;
            this.BT_TrailerPage.Text = "尾页";
            this.BT_TrailerPage.UseVisualStyleBackColor = true;
            this.BT_TrailerPage.Click += new System.EventHandler(this.BT_TrailerPage_Click);
            // 
            // BT_NextPage
            // 
            this.BT_NextPage.Location = new System.Drawing.Point(426, 388);
            this.BT_NextPage.Name = "BT_NextPage";
            this.BT_NextPage.Size = new System.Drawing.Size(75, 23);
            this.BT_NextPage.TabIndex = 14;
            this.BT_NextPage.Text = "下一页";
            this.BT_NextPage.UseVisualStyleBackColor = true;
            this.BT_NextPage.Click += new System.EventHandler(this.BT_NextPage_Click);
            // 
            // BT_Skip
            // 
            this.BT_Skip.Location = new System.Drawing.Point(346, 388);
            this.BT_Skip.Name = "BT_Skip";
            this.BT_Skip.Size = new System.Drawing.Size(75, 23);
            this.BT_Skip.TabIndex = 13;
            this.BT_Skip.Text = "跳转";
            this.BT_Skip.UseVisualStyleBackColor = true;
            this.BT_Skip.Click += new System.EventHandler(this.BT_Skip_Click);
            // 
            // COM_Skip
            // 
            this.COM_Skip.FormattingEnabled = true;
            this.COM_Skip.Location = new System.Drawing.Point(262, 389);
            this.COM_Skip.Name = "COM_Skip";
            this.COM_Skip.Size = new System.Drawing.Size(79, 20);
            this.COM_Skip.TabIndex = 12;
            // 
            // BT_UpPage
            // 
            this.BT_UpPage.Location = new System.Drawing.Point(182, 388);
            this.BT_UpPage.Name = "BT_UpPage";
            this.BT_UpPage.Size = new System.Drawing.Size(75, 23);
            this.BT_UpPage.TabIndex = 11;
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
            this.COM_Page.Location = new System.Drawing.Point(12, 389);
            this.COM_Page.Name = "COM_Page";
            this.COM_Page.Size = new System.Drawing.Size(85, 20);
            this.COM_Page.TabIndex = 10;
            this.COM_Page.TextUpdate += new System.EventHandler(this.COM_Page_TextUpdate);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(629, 393);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 12);
            this.label1.TabIndex = 17;
            this.label1.Text = "N/A";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新建ToolStripMenuItem,
            this.修改ToolStripMenuItem1,
            this.删除ToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(101, 70);
            // 
            // 新建ToolStripMenuItem
            // 
            this.新建ToolStripMenuItem.Name = "新建ToolStripMenuItem";
            this.新建ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.新建ToolStripMenuItem.Text = "新建";
            // 
            // 修改ToolStripMenuItem1
            // 
            this.修改ToolStripMenuItem1.Name = "修改ToolStripMenuItem1";
            this.修改ToolStripMenuItem1.Size = new System.Drawing.Size(100, 22);
            this.修改ToolStripMenuItem1.Text = "修改";
            // 
            // 删除ToolStripMenuItem1
            // 
            this.删除ToolStripMenuItem1.Name = "删除ToolStripMenuItem1";
            this.删除ToolStripMenuItem1.Size = new System.Drawing.Size(100, 22);
            this.删除ToolStripMenuItem1.Text = "删除";
            // 
            // FM_HoldAPositionList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 421);
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
            this.Name = "FM_HoldAPositionList";
            this.Text = "FM_HoldAPositionList";
            this.Load += new System.EventHandler(this.FM_HoldAPositionList_Load);
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
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FundName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompanyName;
        private System.Windows.Forms.Button BT_HomePage;
        private System.Windows.Forms.Button BT_TrailerPage;
        private System.Windows.Forms.Button BT_NextPage;
        private System.Windows.Forms.Button BT_Skip;
        private System.Windows.Forms.ComboBox COM_Skip;
        private System.Windows.Forms.Button BT_UpPage;
        private System.Windows.Forms.ComboBox COM_Page;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 新建ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem1;
    }
}