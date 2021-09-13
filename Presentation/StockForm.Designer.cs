
namespace Presentation
{
    partial class StockForm
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
            this.btnCheckInternetStatus = new System.Windows.Forms.Button();
            this.labInternetStatus = new System.Windows.Forms.Label();
            this.txtDataSource = new System.Windows.Forms.TextBox();
            this.btnGetStockData = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbStockList = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCurrentPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.grid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCheckInternetStatus
            // 
            this.btnCheckInternetStatus.Location = new System.Drawing.Point(384, 135);
            this.btnCheckInternetStatus.Name = "btnCheckInternetStatus";
            this.btnCheckInternetStatus.Size = new System.Drawing.Size(150, 40);
            this.btnCheckInternetStatus.TabIndex = 1;
            this.btnCheckInternetStatus.Text = "Check internet status";
            this.btnCheckInternetStatus.UseVisualStyleBackColor = true;
            this.btnCheckInternetStatus.Click += new System.EventHandler(this.btnCheckInternetStatus_Click);
            // 
            // labInternetStatus
            // 
            this.labInternetStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labInternetStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labInternetStatus.Location = new System.Drawing.Point(169, 135);
            this.labInternetStatus.Name = "labInternetStatus";
            this.labInternetStatus.Size = new System.Drawing.Size(209, 40);
            this.labInternetStatus.TabIndex = 2;
            this.labInternetStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDataSource
            // 
            this.txtDataSource.Location = new System.Drawing.Point(116, 29);
            this.txtDataSource.Multiline = true;
            this.txtDataSource.Name = "txtDataSource";
            this.txtDataSource.Size = new System.Drawing.Size(386, 21);
            this.txtDataSource.TabIndex = 3;
            // 
            // btnGetStockData
            // 
            this.btnGetStockData.Location = new System.Drawing.Point(13, 135);
            this.btnGetStockData.Name = "btnGetStockData";
            this.btnGetStockData.Size = new System.Drawing.Size(150, 40);
            this.btnGetStockData.TabIndex = 4;
            this.btnGetStockData.Text = "Get stock price";
            this.btnGetStockData.UseVisualStyleBackColor = true;
            this.btnGetStockData.Click += new System.EventHandler(this.btnGetStockData_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Select stock:";
            // 
            // cmbStockList
            // 
            this.cmbStockList.FormattingEnabled = true;
            this.cmbStockList.Items.AddRange(new object[] {
            "AAPL",
            "AMZN",
            "FB",
            "GOOG",
            "TSLA",
            "TWTR"});
            this.cmbStockList.Location = new System.Drawing.Point(116, 79);
            this.cmbStockList.Name = "cmbStockList";
            this.cmbStockList.Size = new System.Drawing.Size(121, 21);
            this.cmbStockList.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Data source:";
            // 
            // txtCurrentPrice
            // 
            this.txtCurrentPrice.Location = new System.Drawing.Point(384, 79);
            this.txtCurrentPrice.Name = "txtCurrentPrice";
            this.txtCurrentPrice.Size = new System.Drawing.Size(118, 20);
            this.txtCurrentPrice.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(308, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Current price:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 198);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 45);
            this.button1.TabIndex = 13;
            this.button1.Text = "Call Rapid API";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_ClickAsync);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(550, 29);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(365, 146);
            this.textBox1.TabIndex = 14;
            // 
            // grid
            // 
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Location = new System.Drawing.Point(169, 198);
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(746, 286);
            this.grid.TabIndex = 15;
            // 
            // StockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 496);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCurrentPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbStockList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGetStockData);
            this.Controls.Add(this.txtDataSource);
            this.Controls.Add(this.btnCheckInternetStatus);
            this.Controls.Add(this.labInternetStatus);
            this.Name = "StockForm";
            this.Text = "Stock";
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCheckInternetStatus;
        private System.Windows.Forms.Label labInternetStatus;
        private System.Windows.Forms.TextBox txtDataSource;
        private System.Windows.Forms.Button btnGetStockData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbStockList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCurrentPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView grid;
    }
}