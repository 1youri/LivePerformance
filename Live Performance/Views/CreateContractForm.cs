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
using Live_Performance.Models.Boot;
using Live_Performance.Repositories;
using HuurContract = Live_Performance.Logic.HuurContract;

namespace Live_Performance.Views
{
    public partial class CreateContractForm : Form
    {
        private List<IBoot> botenLeft;
        private List<IBoot> botenRight;
        private List<ExtraArtikel> artikelenRight;
        private HuurContract logic;
        private double cost;

        public CreateContractForm()
        {
            InitializeComponent();
            logic = new HuurContract();
            botenLeft = new List<IBoot>();
            botenRight = new List<IBoot>();
            artikelenRight = new List<ExtraArtikel>();
            RefreshLists();

            dtpTo.MinDate = dtpFrom.Value;
        }

        private void dtpFrom_ValueChanged(object sender, EventArgs e)
        {
            if (dtpFrom.Value > dtpTo.Value)
                dtpTo.Value = dtpFrom.Value;
            UpdateDates();
        }

        private void dtpTo_ValueChanged(object sender, EventArgs e)
        {
            UpdateDates();

        }

        /// <summary>
        /// Update alle benodigde gegevens wanneer de datas veranderen
        /// </summary>

        private void UpdateDates()
        {
            dtpTo.MinDate = dtpFrom.Value;
            botenLeft.Clear();
            botenRight.Clear();
            botenLeft = BootRepo.GetAvailableBoten(dtpFrom.Value, dtpTo.Value);

            RefreshLists();

        }

        private void RefreshLists()
        {
            lbBotenLinks.Items.Clear();
            lbBotenRechts.Items.Clear();
            foreach (IBoot boot in botenLeft)
            {
                string messagestring = boot.Naam + " - " + boot.Type + " " + boot.SoortBeschrijving;
                if (Data.MotorBoten.Contains(Data.MotorBoten.Find(x => x.Naam == boot.Naam)))
                    messagestring += " Actieradius(Km):" + Data.MotorBoten.Find(x => x.Naam == boot.Naam).ActieRadius;
                lbBotenLinks.Items.Add(messagestring);
            }
            foreach (IBoot boot in botenRight)
            {
                string messagestring = boot.Naam + " - " + boot.Type + " " + boot.SoortBeschrijving;
                if (Data.MotorBoten.Contains(Data.MotorBoten.Find(x => x.Naam == boot.Naam)))
                    messagestring += " - Actieradius(Km):" + Data.MotorBoten.Find(x => x.Naam == boot.Naam).ActieRadius;
                lbBotenRechts.Items.Add(messagestring);
            }

            lbArtLinks.Items.Clear();
            lbArtRechts.Items.Clear();
            foreach (ExtraArtikel art in Data.ExtraArtikelen)
            {
                lbArtLinks.Items.Add(art.Beschrijving);
            }

            foreach (ExtraArtikel art in artikelenRight)
            {
                lbArtRechts.Items.Add(art.Count + "x " + art.Beschrijving);
            }

            cost = 0;
            foreach (var b in botenRight)
            {
                if (Data.MotorBoten.Contains(Data.MotorBoten.Find(x => x.Naam == b.Naam)))
                    cost += 15;
                else if (Data.SpierKrachtBoten.Contains(Data.SpierKrachtBoten.Find(x => x.Naam == b.Naam)))
                    cost += 10;
            }
            foreach (var ex in artikelenRight)
            {
                cost += (ex.Count * 1.25);
            }

            lblCost.Text = "Kosten Huur: €" + cost;

        }

        private void BootToRight()
        {
            botenRight.Add(botenLeft[lbBotenLinks.SelectedIndex]);
            botenLeft.RemoveAt(lbBotenLinks.SelectedIndex);

            RefreshLists();
        }
        private void BootToLeft()
        {
            botenLeft.Add(botenRight[lbBotenRechts.SelectedIndex]);
            botenRight.RemoveAt(lbBotenRechts.SelectedIndex);

            RefreshLists();
        }
        private void ArtToRight()
        {
            if (artikelenRight.Contains(Data.ExtraArtikelen[lbArtLinks.SelectedIndex]))
            {
                artikelenRight.Find(x => x.ArtikelID == Data.ExtraArtikelen[lbArtLinks.SelectedIndex].ArtikelID).Count
                    += 1;
            }
            else
            {
                artikelenRight.Add(Data.ExtraArtikelen[lbArtLinks.SelectedIndex]);
            }

            RefreshLists();
        }
        private void ArtToLeft()
        {
            if (artikelenRight[lbArtRechts.SelectedIndex].Count > 1)
            {
                artikelenRight[lbArtRechts.SelectedIndex].Count--;
            }
            else
            {
                artikelenRight.RemoveAt(lbArtRechts.SelectedIndex);
            }

            RefreshLists();
        }

        private void lbArtLinks_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lbArtLinks.SelectedIndex >= 0)
                ArtToRight();
        }

        private void lbArtRechts_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lbArtRechts.SelectedIndex >= 0)
                ArtToLeft();
        }

        private void lbBotenLinks_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lbBotenLinks.SelectedIndex >= 0)
                BootToRight();
        }

        private void lbBotenRechts_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lbBotenRechts.SelectedIndex >= 0)
                BootToLeft();
        }

        private void btnBootRight_Click(object sender, EventArgs e)
        {
            if (lbBotenLinks.SelectedIndex >= 0)
                BootToRight();
        }

        private void btnArtRight_Click(object sender, EventArgs e)
        {
            if (lbArtLinks.SelectedIndex >= 0)
                ArtToRight();
        }

        private void btnArtLeft_Click(object sender, EventArgs e)
        {
            if (lbArtRechts.SelectedIndex >= 0)
                ArtToLeft();
        }

        private void btnBootLeft_Click_1(object sender, EventArgs e)
        {
            if (lbBotenRechts.SelectedIndex >= 0)
                BootToLeft();

        }

        private void btnAanmaken_Click(object sender, EventArgs e)
        {
            logic.AanmakenHuurcontract(new Models.HuurContract(
                0,
                Data.CurrentAccount,
                dtpFrom.Value.Date,
                dtpTo.Value.Date)
            { BijkomendeArtikelen = artikelenRight, Boten = botenRight });

        }

        private void btnBudgetBerekening_Click(object sender, EventArgs e)
        {
            lblResult.Visible = true;
            double budget = Convert.ToDouble(numbBudget.Value);
            lblResult.Text = logic.PrijsBerekening(cost, budget);
        }
    }
}
