namespace FinancialAssistant.WinFrom.HoldAPositionBat
{
    partial class FM_HoldAPositionBatList
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.修改ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompanyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FundName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monetary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArrivalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InputDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Residue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InVain = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InVainName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.修改ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(783, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
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
            this.groupBox1.Size = new System.Drawing.Size(781, 77);
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
            this.CompanyName,
            this.FundName,
            this.UnitPrice,
            this.Quantity,
            this.Monetary,
            this.ArrivalAmount,
            this.InputDate,
            this.Residue,
            this.OrderNumber,
            this.Type,
            this.InVain,
            this.TypeName,
            this.InVainName});
            this.dataGridView1.Location = new System.Drawing.Point(0, 111);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(781, 290);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(685, 412);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 12);
            this.label1.TabIndex = 25;
            this.label1.Text = "N/A";
            // 
            // BT_HomePage
            // 
            this.BT_HomePage.Location = new System.Drawing.Point(158, 408);
            this.BT_HomePage.Name = "BT_HomePage";
            this.BT_HomePage.Size = new System.Drawing.Size(75, 23);
            this.BT_HomePage.TabIndex = 24;
            this.BT_HomePage.Text = "首页";
            this.BT_HomePage.UseVisualStyleBackColor = true;
            this.BT_HomePage.Click += new System.EventHandler(this.BT_HomePage_Click);
            // 
            // BT_TrailerPage
            // 
            this.BT_TrailerPage.Location = new System.Drawing.Point(562, 407);
            this.BT_TrailerPage.Name = "BT_TrailerPage";
            this.BT_TrailerPage.Size = new System.Drawing.Size(75, 23);
            this.BT_TrailerPage.TabIndex = 23;
            this.BT_TrailerPage.Text = "尾页";
            this.BT_TrailerPage.UseVisualStyleBackColor = true;
            this.BT_TrailerPage.Click += new System.EventHandler(this.BT_TrailerPage_Click);
            // 
            // BT_NextPage
            // 
            this.BT_NextPage.Location = new System.Drawing.Point(482, 407);
            this.BT_NextPage.Name = "BT_NextPage";
            this.BT_NextPage.Size = new System.Drawing.Size(75, 23);
            this.BT_NextPage.TabIndex = 22;
            this.BT_NextPage.Text = "下一页";
            this.BT_NextPage.UseVisualStyleBackColor = true;
            this.BT_NextPage.Click += new System.EventHandler(this.BT_NextPage_Click);
            // 
            // BT_Skip
            // 
            this.BT_Skip.Location = new System.Drawing.Point(402, 407);
            this.BT_Skip.Name = "BT_Skip";
            this.BT_Skip.Size = new System.Drawing.Size(75, 23);
            this.BT_Skip.TabIndex = 21;
            this.BT_Skip.Text = "跳转";
            this.BT_Skip.UseVisualStyleBackColor = true;
            this.BT_Skip.Click += new System.EventHandler(this.BT_Skip_Click);
            // 
            // COM_Skip
            // 
            this.COM_Skip.FormattingEnabled = true;
            this.COM_Skip.Location = new System.Drawing.Point(318, 408);
            this.COM_Skip.Name = "COM_Skip";
            this.COM_Skip.Size = new System.Drawing.Size(79, 20);
            this.COM_Skip.TabIndex = 20;
            // 
            // BT_UpPage
            // 
            this.BT_UpPage.Location = new System.Drawing.Point(238, 407);
            this.BT_UpPage.Name = "BT_UpPage";
            this.BT_UpPage.Size = new System.Drawing.Size(75, 23);
            this.BT_UpPage.TabIndex = 19;
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
            this.COM_Page.Location = new System.Drawing.Point(68, 408);
            this.COM_Page.Name = "COM_Page";
            this.COM_Page.Size = new System.Drawing.Size(85, 20);
            this.COM_Page.TabIndex = 18;
            this.COM_Page.TextUpdate += new System.EventHandler(this.COM_Page_TextUpdate);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.修改ToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(101, 26);
            // 
            // 修改ToolStripMenuItem1
            // 
            this.修改ToolStripMenuItem1.Name = "修改ToolStripMenuItem1";
            this.修改ToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.修改ToolStripMenuItem1.Text = "修改";
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "基金号";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // CompanyName
            // 
            this.CompanyName.DataPropertyName = "CompanyName";
            this.CompanyName.HeaderText = "管理公司";
            this.CompanyName.Name = "CompanyName";
            this.CompanyName.ReadOnly = true;
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
            this.Quantity.HeaderText = "持有数量";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // Monetary
            // 
            this.Monetary.DataPropertyName = "Monetary";
            this.Monetary.HeaderText = "操作金额";
            this.Monetary.Name = "Monetary";
            this.Monetary.ReadOnly = true;
            // 
            // ArrivalAmount
            // 
            this.ArrivalAmount.DataPropertyName = "ArrivalAmount";
            this.ArrivalAmount.HeaderText = "实际金额";
            this.ArrivalAmount.Name = "ArrivalAmount";
            this.ArrivalAmount.ReadOnly = true;
            // 
            // InputDate
            // 
            this.InputDate.DataPropertyName = "InputDate";
            this.InputDate.HeaderText = "操作日期";
            this.InputDate.Name = "InputDate";
            this.InputDate.ReadOnly = true;
            // 
            // Residue
            // 
            this.Residue.DataPropertyName = "Residue";
            this.Residue.HeaderText = "持有金额";
            this.Residue.Name = "Residue";
            this.Residue.ReadOnly = true;
            // 
            // OrderNumber
            // 
            this.OrderNumber.DataPropertyName = "OrderNumber";
            this.OrderNumber.HeaderText = "订单号";
            this.OrderNumber.Name = "OrderNumber";
            this.OrderNumber.ReadOnly = true;
            // 
            // Type
            // 
            this.Type.DataPropertyName = "Type";
            this.Type.HeaderText = "类型";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            this.Type.Visible = false;
            // 
            // InVain
            // 
            this.InVain.DataPropertyName = "InVain";
            this.InVain.HeaderText = "是否作废";
            this.InVain.Name = "InVain";
            this.InVain.ReadOnly = true;
            this.InVain.Visible = false;
            // 
            // TypeName
            // 
            this.TypeName.DataPropertyName = "TypeName";
            this.TypeName.HeaderText = "类型";
            this.TypeName.Name = "TypeName";
            this.TypeName.ReadOnly = true;
            // 
            // InVainName
            // 
            this.InVainName.DataPropertyName = "InVainName";
            this.InVainName.HeaderText = "是否作废";
            this.InVainName.Name = "InVainName";
            this.InVainName.ReadOnly = true;
            // 
            // FM_HoldAPositionBatList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 440);
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
            this.Name = "FM_HoldAPositionBatList";
            this.Text = "FM_HoldAPositionBatList";
            this.Load += new System.EventHandler(this.FM_HoldAPositionBatList_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
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
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 修改ToolStripMenuItem1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompanyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FundName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monetary;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArrivalAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn InputDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Residue;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn InVain;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn InVainName;
    }
}