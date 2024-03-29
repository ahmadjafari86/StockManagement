﻿using System;
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
using YahooFinanceApi;
//using IronPython.Hosting;
//using Microsoft.Scripting.Hosting;

namespace Presentation
{
    public partial class StockForm : Form
    {
        
        public StockForm()
        {
            InitializeComponent();
        }
        private readonly BL_Stock_Class bLStockClass = new BL_Stock_Class();

        
        public int taskValue = -1;
        public async Task CheckInternetStatus()
        { 
            await Task.Run(() =>
            {
                taskValue =Convert.ToInt32(bLStockClass.InternetStatus());
                
            });
            if (taskValue == 1)
            {
                labInternetStatus.Text = "Internet access";
                labInternetStatus.BackColor = System.Drawing.Color.Green;
            }
            else if (taskValue == 0)
            {
                labInternetStatus.Text = "Not connected";
                labInternetStatus.BackColor = System.Drawing.Color.Red;
            }
        }

        private void btnCheckInternetStatus_Click(object sender, EventArgs e)
        {
            _= CheckInternetStatus();
        }
        public string getPrice = "";

        public async Task GetStockData(string stock,string dataSource)
        {
            await Task.Run(() =>
            {
                getPrice = Convert.ToString(bLStockClass.WebScraping(stock, dataSource));
            });
            if (getPrice.Contains("No internet access!"))
                MessageBox.Show("No internet access!");
            else if (getPrice.Contains("Error!  "))
                MessageBox.Show(getPrice);
            else txtCurrentPrice.Text = getPrice;
        }
        private void btnGetStockData_Click(object sender, EventArgs e)
        {
            _ = GetStockData(cmbStockList.Text, txtDataSource.Text);
        }

        private void button1_ClickAsync(object sender, EventArgs e)
        {
            string result = bLStockClass.GetYahooFinanceData();
            if(result.Contains("No internet access!"))
                MessageBox.Show(result);
            else textBox1.Text = result;
        }
     
    }
}
