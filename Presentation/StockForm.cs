using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;

namespace Presentation
{
    public partial class StockForm : Form
    {
        
        public StockForm()
        {
            InitializeComponent();
        }
        private readonly BL_Stock_Class bLStockClass = new BL_Stock_Class();

        
        public bool taskValue = false;
        public async Task Main()
        { 
            await Task.Run(() =>
            {
                taskValue = bLStockClass.InternetStatus();
                
            });
            setLabelData();
        }
        private void btnCheckInternetStatus_Click(object sender, EventArgs e)
        {
            Main();
        }

        private void setLabelData()
        {
            if (taskValue)
            {
                labInternetStatus.Text = "Internet access";
                labInternetStatus.BackColor = System.Drawing.Color.Green;
                MessageBox.Show(" true");
            }
            else
            {
                labInternetStatus.Text = "Not connected";
                labInternetStatus.BackColor = System.Drawing.Color.Red;
                MessageBox.Show(" false");
            }

        }

        private void btnScraper_Click(object sender, EventArgs e)
        {
            //if (bLStockClass.InternetStatus())
            //    txtScraperContext.Text = bLStockClass.WebScraping(txtUrl.Text);
            //else MessageBox.Show("Check your internet connection...");
        }
    }
}
