using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Live_Performance.Repositories;

namespace Live_Performance.Views
{
    public partial class ExceptionForm : Form
    {
        public ExceptionForm(string ExceptionString)
        {
            throw new Exception();
            InitializeComponent();
            tbException.Text = ExceptionString;
            Data.ShownError = true;

            this.Height = 125;
            tbException.Visible = false;
        }

        private void cbDetails_CheckedChanged(object sender, EventArgs e)
        {
            if (cbDetails.Checked)
            {
                this.Height = 320;
                tbException.Visible = true;
            }
            else
            {
                this.Height = 125;
                tbException.Visible = false;
            }
        }

        private void ExceptionForm_Load(object sender, EventArgs e)
        {

        }
    }
}
