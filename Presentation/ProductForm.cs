using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;

namespace Presentation
{
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();
        }

        private BL_Product_Class bL_Product_Class = new BL_Product_Class();

        private void SelectProduct()
        {
            dataGridView1.DataSource = bL_Product_Class.SelectProduct();
            if (dataGridView1.Columns.Count >= 1)
                dataGridView1.Columns[1].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            ResetFormInputs();
            SelectProduct();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            bool status = Convert.ToBoolean(cmbBoxStatus.SelectedIndex);
            bL_Product_Class.InsertProduct(txtBoxProductCode.Text,txtBoxProductName.Text,status);
            SelectProduct();
            ResetFormInputs();
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            bL_Product_Class.DeleteProduct(txtBoxProductCode.Text);
            SelectProduct();
            ResetFormInputs();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            txtBoxProductCode.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txtBoxProductName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            cmbBoxStatus.SelectedIndex =Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[2].Value);
        }
        private void ResetFormInputs()
        {
            txtBoxProductCode.Text = "";
            txtBoxProductName.Text = "";
            cmbBoxStatus.SelectedIndex = 1;
            txtBoxProductCode.Focus();
        }
    }
}
