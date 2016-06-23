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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            UpdateList();
        }

        private void btnNewHuurContract_Click(object sender, EventArgs e)
        {
            CreateContractForm frm = new CreateContractForm();
            frm.ShowDialog();
            Data.UpdateAllData();
            UpdateList();

        }

        private void UpdateList()
        {
            foreach (var Hc in Data.HuurContracten)
            {
                ListViewItem lvi = new ListViewItem(Hc.HuurContractID.ToString());
                lvi.SubItems.Add(Hc.Huurder.Naam);
                lvi.SubItems.Add(Hc.BeginDatum.ToShortDateString());
                lvi.SubItems.Add(Hc.EindDatum.ToShortDateString());
                lvHuurContracten.Items.Add(lvi);
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
