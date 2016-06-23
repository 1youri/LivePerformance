using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Live_Performance.Logic;

namespace Live_Performance.Views
{
    public partial class LoginForm : Form
    {
        private bool shouldClose;
        public LoginForm()
        {
            shouldClose = false;
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (Login.LoginUser(tbUsername.Text, tbPassword.Text))
            {
                shouldClose = true;
                MainForm frm = new MainForm();
                frm.Show();
                this.Close();
                
            }
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!shouldClose)
            {
                Application.Exit();
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterForm frm = new RegisterForm(tbUsername.Text);
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }
    }
}
