
namespace WindowsFormsApp1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.crawl = new System.Windows.Forms.Button();
            this.startUrlBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.infoBox = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.crawl);
            this.panel1.Controls.Add(this.startUrlBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(865, 178);
            this.panel1.TabIndex = 0;
            // 
            // crawl
            // 
            this.crawl.Location = new System.Drawing.Point(542, 65);
            this.crawl.Name = "crawl";
            this.crawl.Size = new System.Drawing.Size(192, 38);
            this.crawl.TabIndex = 1;
            this.crawl.Text = "开始爬取";
            this.crawl.UseVisualStyleBackColor = true;
            this.crawl.Click += new System.EventHandler(this.crawl_Click);
            // 
            // startUrlBox
            // 
            this.startUrlBox.Location = new System.Drawing.Point(39, 68);
            this.startUrlBox.Name = "startUrlBox";
            this.startUrlBox.Size = new System.Drawing.Size(445, 35);
            this.startUrlBox.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.infoBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 178);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(865, 506);
            this.panel2.TabIndex = 1;
            // 
            // infoBox
            // 
            this.infoBox.Location = new System.Drawing.Point(39, 35);
            this.infoBox.Name = "infoBox";
            this.infoBox.Size = new System.Drawing.Size(695, 419);
            this.infoBox.TabIndex = 0;
            this.infoBox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 684);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button crawl;
        private System.Windows.Forms.TextBox startUrlBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox infoBox;
    }
}

