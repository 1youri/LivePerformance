using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Live_Performance.Models;
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
            lvHuurContracten.Items.Clear();
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

        private void lvHuurContracten_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvHuurContracten.SelectedItems.Count > 0)
            {
                btnExport.Visible = true;

                int index = lvHuurContracten.SelectedItems[0].Index;
                HuurContract currentContract =
                    Logic.HuurContract.GetHuurContract(Data.HuurContracten[index].HuurContractID);

                lblNaam.Text = "Naam Huurder: " + currentContract.Huurder.Naam;
                lblDatumVan.Text = "Vanaf Datum: " + currentContract.BeginDatum.ToShortDateString();
                lblDatumTot.Text = "Tot Datum: " + currentContract.EindDatum.ToShortDateString();
                lbBoten.Items.Clear();

                foreach (var b in currentContract.Boten)
                {
                    string messagestring = b.Naam + " - " + b.Type + " " + b.SoortBeschrijving;
                    if (Data.MotorBoten.Contains(Data.MotorBoten.Find(x => x.Naam == b.Naam)))
                        messagestring += " Actieradius(Km):" + Data.MotorBoten.Find(x => x.Naam == b.Naam).ActieRadius;
                    lbBoten.Items.Add(messagestring);
                }
            }
            else
            {
                btnExport.Visible = false;
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            

        }
    }
}
