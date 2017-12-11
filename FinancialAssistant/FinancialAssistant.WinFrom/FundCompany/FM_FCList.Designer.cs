namespace FinancialAssistant.WinFrom.FundCompany
{
    partial class FM_FCList
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BT_TextClone = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.markTextBox2 = new FinancialAssistant.Widget.Text.MarkTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.markTextBox1 = new FinancialAssistant.Widget.Text.MarkTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompanyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COM_Page = new System.Windows.Forms.ComboBox();
            this.BT_UpPage = new System.Windows.Forms.Button();
            this.COM_Skip = new System.Windows.Forms.ComboBox();
            this.BT_Skip = new System.Windows.Forms.Button();
            this.BT_NextPage = new System.Windows.Forms.Button();
            this.BT_TrailerPage = new System.Windows.Forms.Button();
            this.BT_HomePage = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.添加ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.LISTStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.添加ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.修改ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.LISTStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BT_TextClone);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.markTextBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.markTextBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(611, 74);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "高级搜索";
            // 
            // BT_TextClone
            // 
            this.BT_TextClone.Location = new System.Drawing.Point(491, 27);
            this.BT_TextClone.Name = "BT_TextClone";
            this.BT_TextClone.Size = new System.Drawing.Size(75, 23);
            this.BT_TextClone.TabIndex = 5;
            this.BT_TextClone.Text = "清空";
            this.BT_TextClone.UseVisualStyleBackColor = true;
            this.BT_TextClone.Click += new System.EventHandler(this.BT_TextClone_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(380, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "搜索";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // markTextBox2
            // 
            this.markTextBox2.Location = new System.Drawing.Point(74, 29);
            this.markTextBox2.Name = "markTextBox2";
            this.markTextBox2.Size = new System.Drawing.Size(100, 21);
            this.markTextBox2.TabIndex = 3;
            this.markTextBox2.WaterText = "请输入ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID：";
            // 
            // markTextBox1
            // 
            this.markTextBox1.Location = new System.Drawing.Point(258, 29);
            this.markTextBox1.Name = "markTextBox1";
            this.markTextBox1.Size = new System.Drawing.Size(100, 21);
            this.markTextBox1.TabIndex = 1;
            this.markTextBox1.WaterText = "请输入公司名";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(211, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "公司名：";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.CompanyName});
            this.dataGridView1.Location = new System.Drawing.Point(-1, 107);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(611, 297);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDown);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // CompanyName
            // 
            this.CompanyName.DataPropertyName = "CompanyName";
            this.CompanyName.HeaderText = "公司名";
            this.CompanyName.Name = "CompanyName";
            this.CompanyName.ReadOnly = true;
            // 
            // COM_Page
            // 
            this.COM_Page.FormattingEnabled = true;
            this.COM_Page.Items.AddRange(new object[] {
            "10",
            "25",
            "50",
            "100"});
            this.COM_Page.Location = new System.Drawing.Point(18, 411);
            this.COM_Page.Name = "COM_Page";
            this.COM_Page.Size = new System.Drawing.Size(85, 20);
            this.COM_Page.TabIndex = 3;
            this.COM_Page.TextChanged += new System.EventHandler(this.COM_Page_TextChanged);
            // 
            // BT_UpPage
            // 
            this.BT_UpPage.Location = new System.Drawing.Point(188, 410);
            this.BT_UpPage.Name = "BT_UpPage";
            this.BT_UpPage.Size = new System.Drawing.Size(75, 23);
            this.BT_UpPage.TabIndex = 4;
            this.BT_UpPage.Text = "上一页";
            this.BT_UpPage.UseVisualStyleBackColor = true;
            this.BT_UpPage.Click += new System.EventHandler(this.BT_UpPage_Click);
            // 
            // COM_Skip
            // 
            this.COM_Skip.FormattingEnabled = true;
            this.COM_Skip.Location = new System.Drawing.Point(268, 411);
            this.COM_Skip.Name = "COM_Skip";
            this.COM_Skip.Size = new System.Drawing.Size(79, 20);
            this.COM_Skip.TabIndex = 5;
            // 
            // BT_Skip
            // 
            this.BT_Skip.Location = new System.Drawing.Point(352, 410);
            this.BT_Skip.Name = "BT_Skip";
            this.BT_Skip.Size = new System.Drawing.Size(75, 23);
            this.BT_Skip.TabIndex = 6;
            this.BT_Skip.Text = "跳转";
            this.BT_Skip.UseVisualStyleBackColor = true;
            this.BT_Skip.Click += new System.EventHandler(this.BT_Skip_Click);
            // 
            // BT_NextPage
            // 
            this.BT_NextPage.Location = new System.Drawing.Point(432, 410);
            this.BT_NextPage.Name = "BT_NextPage";
            this.BT_NextPage.Size = new System.Drawing.Size(75, 23);
            this.BT_NextPage.TabIndex = 7;
            this.BT_NextPage.Text = "下一页";
            this.BT_NextPage.UseVisualStyleBackColor = true;
            this.BT_NextPage.Click += new System.EventHandler(this.BT_NextPage_Click);
            // 
            // BT_TrailerPage
            // 
            this.BT_TrailerPage.Location = new System.Drawing.Point(512, 410);
            this.BT_TrailerPage.Name = "BT_TrailerPage";
            this.BT_TrailerPage.Size = new System.Drawing.Size(75, 23);
            this.BT_TrailerPage.TabIndex = 8;
            this.BT_TrailerPage.Text = "尾页";
            this.BT_TrailerPage.UseVisualStyleBackColor = true;
            this.BT_TrailerPage.Click += new System.EventHandler(this.BT_TrailerPage_Click);
            // 
            // BT_HomePage
            // 
            this.BT_HomePage.Location = new System.Drawing.Point(108, 411);
            this.BT_HomePage.Name = "BT_HomePage";
            this.BT_HomePage.Size = new System.Drawing.Size(75, 23);
            this.BT_HomePage.TabIndex = 9;
            this.BT_HomePage.Text = "首页";
            this.BT_HomePage.UseVisualStyleBackColor = true;
            this.BT_HomePage.Click += new System.EventHandler(this.BT_HomePage_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加ToolStripMenuItem,
            this.修改ToolStripMenuItem,
            this.删除ToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(609, 25);
            this.menuStrip1.TabIndex = 10;
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
            // 删除ToolStripMenuItem1
            // 
            this.删除ToolStripMenuItem1.Name = "删除ToolStripMenuItem1";
            this.删除ToolStripMenuItem1.Size = new System.Drawing.Size(44, 21);
            this.删除ToolStripMenuItem1.Text = "删除";
            this.删除ToolStripMenuItem1.Click += new System.EventHandler(this.删除ToolStripMenuItem1_Click);
            // 
            // LISTStrip
            // 
            this.LISTStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加ToolStripMenuItem1,
            this.修改ToolStripMenuItem1,
            this.删除ToolStripMenuItem});
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
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            this.删除ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.删除ToolStripMenuItem.Text = "删除";
            this.删除ToolStripMenuItem.Click += new System.EventHandler(this.删除ToolStripMenuItem_Click);
            // 
            // FM_FCList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 440);
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
            this.Name = "FM_FCList";
            this.Text = "FM_FCList";
            this.Load += new System.EventHandler(this.FM_FCList_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.LISTStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private Widget.Text.MarkTextBox markTextBox2;
        private System.Windows.Forms.Label label2;
        private Widget.Text.MarkTextBox markTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompanyName;
        private System.Windows.Forms.ComboBox COM_Page;
        private System.Windows.Forms.Button BT_UpPage;
        private System.Windows.Forms.ComboBox COM_Skip;
        private System.Windows.Forms.Button BT_Skip;
        private System.Windows.Forms.Button BT_NextPage;
        private System.Windows.Forms.Button BT_TrailerPage;
        private System.Windows.Forms.Button BT_HomePage;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 添加ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改ToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip LISTStrip;
        private System.Windows.Forms.ToolStripMenuItem 添加ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 修改ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem1;
        private System.Windows.Forms.Button BT_TextClone;
    }
}