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
using Live_Performance.Repositories;

namespace Live_Performance.Views
{
    public partial class RegisterForm : Form
    {
        public RegisterForm(string username = "")
        {
            InitializeComponent();
            tbUsername.Text = username;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            AccountRepo.Check check = Login.CheckAvailable(tbUsername.Text, tbPassword.Text);
            if (check == AccountRepo.Check.BothUsed)
            {
                lblEmailUsed.Visible = true;
                lblUsername.Visible = true;
            }
            if (check == AccountRepo.Check.EmailUsed)
            {
                lblEmailUsed.Visible = true;
                lblUsername.Visible = false;
            }
            if (check == AccountRepo.Check.UsernameUsed)
            {
                lblEmailUsed.Visible = false;
                lblUsername.Visible = true;
            }
            if (check == AccountRepo.Check.Available)
            {
                lblEmailUsed.Visible = false;
                lblUsername.Visible = false;

                if (Login.RegisterUser(tbLastName.Text + ", " + tbFirstName.Text,
                    tbEmail.Text, tbUsername.Text, tbPasswordCheck.Text))
                {
                    MessageBox.Show("Registratie Succesvol! U kunt nu inloggen met het geregistreerde account.","Succesvol",MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                

            }


            tbPassword.Text = "";
            tbPasswordCheck.Text = "";
        }

        private void tbPasswordCheck_TextChanged(object sender, EventArgs e)
        {
            if (tbPassword.Text != tbPasswordCheck.Text)
            {
                lblUsernameUsed.Text = "Wachtwoorden niet gelijk!";
                lblUsernameUsed.Visible = true;
                btnRegister.Enabled = false;
            }
            else
            {
                lblUsernameUsed.Text = "Gebruikersnaam is al in gebruik!";
                lblUsernameUsed.Visible = false;
                btnRegister.Enabled = true;
            }
        }
    }
}
