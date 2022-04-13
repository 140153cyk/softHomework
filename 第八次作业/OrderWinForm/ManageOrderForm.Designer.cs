
namespace OrderWinForm
{
    partial class ManageOrderForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.detailDeleteButton = new System.Windows.Forms.Button();
            this.detailAddButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.productComboBox = new System.Windows.Forms.ComboBox();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.guestBox = new System.Windows.Forms.ComboBox();
            this.guestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.confirmButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.productDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guestBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.detailDeleteButton);
            this.panel1.Controls.Add(this.detailAddButton);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.quantityTextBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.productComboBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 291);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(674, 161);
            this.panel1.TabIndex = 0;
            // 
            // detailDeleteButton
            // 
            this.detailDeleteButton.Location = new System.Drawing.Point(253, 18);
            this.detailDeleteButton.Margin = new System.Windows.Forms.Padding(2);
            this.detailDeleteButton.Name = "detailDeleteButton";
            this.detailDeleteButton.Size = new System.Drawing.Size(65, 25);
            this.detailDeleteButton.TabIndex = 5;
            this.detailDeleteButton.Text = "删除明细";
            this.detailDeleteButton.UseVisualStyleBackColor = true;
            this.detailDeleteButton.Click += new System.EventHandler(this.detailDeleteButton_Click);
            // 
            // detailAddButton
            // 
            this.detailAddButton.Location = new System.Drawing.Point(164, 18);
            this.detailAddButton.Margin = new System.Windows.Forms.Padding(2);
            this.detailAddButton.Name = "detailAddButton";
            this.detailAddButton.Size = new System.Drawing.Size(65, 25);
            this.detailAddButton.TabIndex = 4;
            this.detailAddButton.Text = "添加明细";
            this.detailAddButton.UseVisualStyleBackColor = true;
            this.detailAddButton.Click += new System.EventHandler(this.detailAddButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 44);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "数量";
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(52, 42);
            this.quantityTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(72, 21);
            this.quantityTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "产品";
            // 
            // productComboBox
            // 
            this.productComboBox.DataSource = this.productBindingSource;
            this.productComboBox.DisplayMember = "name";
            this.productComboBox.FormattingEnabled = true;
            this.productComboBox.Location = new System.Drawing.Point(52, 8);
            this.productComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.productComboBox.Name = "productComboBox";
            this.productComboBox.Size = new System.Drawing.Size(72, 20);
            this.productComboBox.TabIndex = 0;
            this.productComboBox.ValueMember = "Id";
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(OrderPro.Product);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10);
            this.panel2.Size = new System.Drawing.Size(674, 294);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.guestBox);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.confirmButton);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(10, 10);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(10);
            this.panel3.Size = new System.Drawing.Size(654, 44);
            this.panel3.TabIndex = 2;
            // 
            // guestBox
            // 
            this.guestBox.DataSource = this.guestBindingSource;
            this.guestBox.FormattingEnabled = true;
            this.guestBox.Location = new System.Drawing.Point(74, 9);
            this.guestBox.Margin = new System.Windows.Forms.Padding(2);
            this.guestBox.Name = "guestBox";
            this.guestBox.Size = new System.Drawing.Size(96, 20);
            this.guestBox.TabIndex = 4;
            // 
            // guestBindingSource
            // 
            this.guestBindingSource.DataSource = typeof(OrderPro.Guest);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "客户姓名";
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(236, 6);
            this.confirmButton.Margin = new System.Windows.Forms.Padding(2);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(65, 25);
            this.confirmButton.TabIndex = 1;
            this.confirmButton.Text = "确认";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.totalPriceDataGridViewTextBoxColumn});
            this.dataGridView1.DataMember = "detailList";
            this.dataGridView1.DataSource = this.orderBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(10, 54);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 37;
            this.dataGridView1.Size = new System.Drawing.Size(654, 230);
            this.dataGridView1.TabIndex = 0;
            // 
            // productDataGridViewTextBoxColumn
            // 
            this.productDataGridViewTextBoxColumn.DataPropertyName = "product";
            this.productDataGridViewTextBoxColumn.HeaderText = "产品名称";
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
            // orderBindingSource
            // 
            this.orderBindingSource.DataSource = typeof(OrderPro.Order);
            // 
            // ManageOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(674, 452);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ManageOrderForm";
            this.Text = "AddOrderForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guestBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn productDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox productComboBox;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.Button detailDeleteButton;
        private System.Windows.Forms.Button detailAddButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox guestBox;
        private System.Windows.Forms.BindingSource guestBindingSource;
    }
}