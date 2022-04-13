
namespace OrderWinForm
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
            this.components = new System.ComponentModel.Container();
            this.panelAll = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelOrder = new System.Windows.Forms.Panel();
            this.orderGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderGuestDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPaymentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelDetail = new System.Windows.Forms.Panel();
            this.detailGridView = new System.Windows.Forms.DataGridView();
            this.productDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelQuery = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.listQueryWay = new System.Windows.Forms.ListBox();
            this.textQuery = new System.Windows.Forms.TextBox();
            this.queryButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelAll.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            this.panelDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detailGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailBindingSource)).BeginInit();
            this.panelQuery.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAll
            // 
            this.panelAll.Controls.Add(this.panel1);
            this.panelAll.Location = new System.Drawing.Point(0, 0);
            this.panelAll.Margin = new System.Windows.Forms.Padding(10);
            this.panelAll.Name = "panelAll";
            this.panelAll.Size = new System.Drawing.Size(686, 468);
            this.panelAll.TabIndex = 0;
            this.panelAll.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDisplay_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelOrder);
            this.panel1.Controls.Add(this.panelDetail);
            this.panel1.Controls.Add(this.panelQuery);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(686, 468);
            this.panel1.TabIndex = 1;
            // 
            // panelOrder
            // 
            this.panelOrder.Controls.Add(this.orderGridView);
            this.panelOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOrder.Location = new System.Drawing.Point(0, 128);
            this.panelOrder.Margin = new System.Windows.Forms.Padding(2);
            this.panelOrder.Name = "panelOrder";
            this.panelOrder.Padding = new System.Windows.Forms.Padding(10);
            this.panelOrder.Size = new System.Drawing.Size(686, 160);
            this.panelOrder.TabIndex = 2;
            // 
            // orderGridView
            // 
            this.orderGridView.AutoGenerateColumns = false;
            this.orderGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.orderGuestDataGridViewTextBoxColumn,
            this.orderTimeDataGridViewTextBoxColumn,
            this.totalPaymentDataGridViewTextBoxColumn});
            this.orderGridView.DataSource = this.orderBindingSource;
            this.orderGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orderGridView.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.orderGridView.Location = new System.Drawing.Point(10, 10);
            this.orderGridView.Margin = new System.Windows.Forms.Padding(2);
            this.orderGridView.Name = "orderGridView";
            this.orderGridView.RowHeadersWidth = 10;
            this.orderGridView.RowTemplate.Height = 37;
            this.orderGridView.Size = new System.Drawing.Size(666, 140);
            this.orderGridView.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 200;
            // 
            // orderGuestDataGridViewTextBoxColumn
            // 
            this.orderGuestDataGridViewTextBoxColumn.DataPropertyName = "OrderGuest";
            this.orderGuestDataGridViewTextBoxColumn.HeaderText = "客户";
            this.orderGuestDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.orderGuestDataGridViewTextBoxColumn.Name = "orderGuestDataGridViewTextBoxColumn";
            this.orderGuestDataGridViewTextBoxColumn.Width = 200;
            // 
            // orderTimeDataGridViewTextBoxColumn
            // 
            this.orderTimeDataGridViewTextBoxColumn.DataPropertyName = "OrderTime";
            this.orderTimeDataGridViewTextBoxColumn.HeaderText = "订单时间";
            this.orderTimeDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.orderTimeDataGridViewTextBoxColumn.Name = "orderTimeDataGridViewTextBoxColumn";
            this.orderTimeDataGridViewTextBoxColumn.Width = 200;
            // 
            // totalPaymentDataGridViewTextBoxColumn
            // 
            this.totalPaymentDataGridViewTextBoxColumn.DataPropertyName = "TotalPayment";
            this.totalPaymentDataGridViewTextBoxColumn.HeaderText = "总金额";
            this.totalPaymentDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.totalPaymentDataGridViewTextBoxColumn.Name = "totalPaymentDataGridViewTextBoxColumn";
            this.totalPaymentDataGridViewTextBoxColumn.Width = 200;
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataSource = typeof(OrderPro.Order);
            // 
            // panelDetail
            // 
            this.panelDetail.Controls.Add(this.detailGridView);
            this.panelDetail.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelDetail.Location = new System.Drawing.Point(0, 288);
            this.panelDetail.Margin = new System.Windows.Forms.Padding(2);
            this.panelDetail.Name = "panelDetail";
            this.panelDetail.Padding = new System.Windows.Forms.Padding(10);
            this.panelDetail.Size = new System.Drawing.Size(686, 180);
            this.panelDetail.TabIndex = 1;
            // 
            // detailGridView
            // 
            this.detailGridView.AutoGenerateColumns = false;
            this.detailGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.detailGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.totalPriceDataGridViewTextBoxColumn});
            this.detailGridView.DataSource = this.orderDetailBindingSource;
            this.detailGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.detailGridView.Location = new System.Drawing.Point(10, 10);
            this.detailGridView.Margin = new System.Windows.Forms.Padding(2);
            this.detailGridView.Name = "detailGridView";
            this.detailGridView.RowHeadersWidth = 10;
            this.detailGridView.RowTemplate.Height = 37;
            this.detailGridView.Size = new System.Drawing.Size(666, 160);
            this.detailGridView.TabIndex = 0;
            // 
            // productDataGridViewTextBoxColumn
            // 
            this.productDataGridViewTextBoxColumn.DataPropertyName = "product";
            this.productDataGridViewTextBoxColumn.HeaderText = "产品";
            this.productDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.productDataGridViewTextBoxColumn.Name = "productDataGridViewTextBoxColumn";
            this.productDataGridViewTextBoxColumn.Width = 200;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "数量";
            this.quantityDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.Width = 200;
            // 
            // totalPriceDataGridViewTextBoxColumn
            // 
            this.totalPriceDataGridViewTextBoxColumn.DataPropertyName = "TotalPrice";
            this.totalPriceDataGridViewTextBoxColumn.HeaderText = "总金额";
            this.totalPriceDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.totalPriceDataGridViewTextBoxColumn.Name = "totalPriceDataGridViewTextBoxColumn";
            this.totalPriceDataGridViewTextBoxColumn.Width = 200;
            // 
            // orderDetailBindingSource
            // 
            this.orderDetailBindingSource.DataMember = "detailList";
            this.orderDetailBindingSource.DataSource = this.orderBindingSource;
            // 
            // panelQuery
            // 
            this.panelQuery.Controls.Add(this.flowLayoutPanel1);
            this.panelQuery.Controls.Add(this.menuStrip1);
            this.panelQuery.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelQuery.Location = new System.Drawing.Point(0, 0);
            this.panelQuery.Margin = new System.Windows.Forms.Padding(2);
            this.panelQuery.Name = "panelQuery";
            this.panelQuery.Padding = new System.Windows.Forms.Padding(15);
            this.panelQuery.Size = new System.Drawing.Size(686, 128);
            this.panelQuery.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.listQueryWay);
            this.flowLayoutPanel1.Controls.Add(this.textQuery);
            this.flowLayoutPanel1.Controls.Add(this.queryButton);
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Controls.Add(this.updateButton);
            this.flowLayoutPanel1.Controls.Add(this.addButton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(15, 40);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(656, 73);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // listQueryWay
            // 
            this.listQueryWay.FormattingEnabled = true;
            this.listQueryWay.ItemHeight = 12;
            this.listQueryWay.Items.AddRange(new object[] {
            "客户姓名",
            "订单编号",
            "货物名称",
            "总金额"});
            this.listQueryWay.Location = new System.Drawing.Point(12, 12);
            this.listQueryWay.Margin = new System.Windows.Forms.Padding(2);
            this.listQueryWay.Name = "listQueryWay";
            this.listQueryWay.Size = new System.Drawing.Size(75, 28);
            this.listQueryWay.TabIndex = 0;
            // 
            // textQuery
            // 
            this.textQuery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textQuery.Location = new System.Drawing.Point(104, 18);
            this.textQuery.Margin = new System.Windows.Forms.Padding(15, 8, 10, 10);
            this.textQuery.Name = "textQuery";
            this.textQuery.Size = new System.Drawing.Size(105, 21);
            this.textQuery.TabIndex = 1;
            // 
            // queryButton
            // 
            this.queryButton.Location = new System.Drawing.Point(224, 15);
            this.queryButton.Margin = new System.Windows.Forms.Padding(5);
            this.queryButton.Name = "queryButton";
            this.queryButton.Size = new System.Drawing.Size(80, 20);
            this.queryButton.TabIndex = 2;
            this.queryButton.Text = "查询订单";
            this.queryButton.UseVisualStyleBackColor = true;
            this.queryButton.Click += new System.EventHandler(this.queryButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(314, 15);
            this.button1.Margin = new System.Windows.Forms.Padding(5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 20);
            this.button1.TabIndex = 3;
            this.button1.Text = "删除订单";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(404, 15);
            this.updateButton.Margin = new System.Windows.Forms.Padding(5);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(80, 20);
            this.updateButton.TabIndex = 4;
            this.updateButton.Text = "修改订单";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(494, 15);
            this.addButton.Margin = new System.Windows.Forms.Padding(5);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(80, 20);
            this.addButton.TabIndex = 5;
            this.addButton.Text = "添加订单";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ioToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(15, 15);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(656, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ioToolStripMenuItem
            // 
            this.ioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importToolStripMenuItem,
            this.exportToolStripMenuItem});
            this.ioToolStripMenuItem.Name = "ioToolStripMenuItem";
            this.ioToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.ioToolStripMenuItem.Text = "导入导出";
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.importToolStripMenuItem.Text = "导入";
            this.importToolStripMenuItem.Click += new System.EventHandler(this.importToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exportToolStripMenuItem.Text = "导出";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.editToolStripMenuItem.Text = "编辑";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(642, 390);
            this.Controls.Add(this.panelAll);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelAll.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panelOrder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.orderGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            this.panelDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.detailGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailBindingSource)).EndInit();
            this.panelQuery.ResumeLayout(false);
            this.panelQuery.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAll;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelOrder;
        private System.Windows.Forms.DataGridView orderGridView;
        private System.Windows.Forms.Panel panelDetail;
        private System.Windows.Forms.Panel panelQuery;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private System.Windows.Forms.DataGridView detailGridView;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ListBox listQueryWay;
        private System.Windows.Forms.TextBox textQuery;
        private System.Windows.Forms.Button queryButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.BindingSource orderDetailBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderGuestDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPaymentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
    }
}

