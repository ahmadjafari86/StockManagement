
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
            this.txtScraperContext = new System.Windows.Forms.TextBox();
            this.btnScraper = new System.Windows.Forms.Button();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCheckInternetStatus
            // 
            this.btnCheckInternetStatus.Location = new System.Drawing.Point(383, 415);
            this.btnCheckInternetStatus.Name = "btnCheckInternetStatus";
            this.btnCheckInternetStatus.Size = new System.Drawing.Size(150, 23);
            this.btnCheckInternetStatus.TabIndex = 1;
            this.btnCheckInternetStatus.Text = "Check internet status";
            this.btnCheckInternetStatus.UseVisualStyleBackColor = true;
            this.btnCheckInternetStatus.Click += new System.EventHandler(this.btnCheckInternetStatus_Click);
            // 
            // labInternetStatus
            // 
            this.labInternetStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labInternetStatus.Location = new System.Drawing.Point(175, 398);
            this.labInternetStatus.Name = "labInternetStatus";
            this.labInternetStatus.Size = new System.Drawing.Size(195, 48);
            this.labInternetStatus.TabIndex = 2;
            this.labInternetStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtScraperContext
            // 
            this.txtScraperContext.Location = new System.Drawing.Point(12, 12);
            this.txtScraperContext.Multiline = true;
            this.txtScraperContext.Name = "txtScraperContext";
            this.txtScraperContext.Size = new System.Drawing.Size(521, 122);
            this.txtScraperContext.TabIndex = 3;
            // 
            // btnScraper
            // 
            this.btnScraper.Location = new System.Drawing.Point(12, 415);
            this.btnScraper.Name = "btnScraper";
            this.btnScraper.Size = new System.Drawing.Size(150, 23);
            this.btnScraper.TabIndex = 4;
            this.btnScraper.Text = "Internet scraping";
            this.btnScraper.UseVisualStyleBackColor = true;
            this.btnScraper.Click += new System.EventHandler(this.btnScraper_Click);
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(12, 177);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(521, 20);
            this.txtUrl.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "URL..";
            // 
            // StockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 456);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.btnScraper);
            this.Controls.Add(this.txtScraperContext);
            this.Controls.Add(this.btnCheckInternetStatus);
            this.Controls.Add(this.labInternetStatus);
            this.Name = "StockForm";
            this.Text = "Stock";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCheckInternetStatus;
        private System.Windows.Forms.Label labInternetStatus;
        private System.Windows.Forms.TextBox txtScraperContext;
        private System.Windows.Forms.Button btnScraper;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Label label1;
    }
}