using System;
using System.CodeDom;
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
        /// <summary>
        /// Handig exceptionform, roep aan en geef de exception mee en call .Show()
        /// </summary>
        private Exception thrownexeption;
        public ExceptionForm(Exception e)
        {
            thrownexeption = e;
            InitializeComponent();
            tbException.Text = e.ToString();
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

        private void button1_Click(object sender, EventArgs e)
        {
            throw thrownexeption;
        }
    }
}
