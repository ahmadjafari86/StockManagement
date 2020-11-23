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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBoxUser.Clear();
            txtBoxPass.Clear();
            txtBoxUser.Focus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //To-Do: Check login username and password.
            BL_Login_Class checkLogin = new BL_Login_Class();
            if (checkLogin.LoginValidation(txtBoxUser.Text, txtBoxPass.Text))
            {
                this.Hide();
                MainForm mainApp = new MainForm();
                mainApp.Show();
            }
            else
            {
                MessageBox.Show("Invalid username and password..!", "Notice",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                btnClear_Click(null,null);
            }
        }
    }
}
