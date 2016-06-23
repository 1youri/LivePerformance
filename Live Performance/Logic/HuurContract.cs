using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Live_Performance.Models;
using Live_Performance.Models.Boot;
using Live_Performance.Repositories;
using System.IO;
using Live_Performance.Views;

namespace Live_Performance.Logic
{
    public class HuurContract
    {
        public List<IBoot> Boten { get; set; }
        public List<ExtraArtikel> ExtraArtikelen { get; set; }

        /// <summary>
        /// Contructor
        /// </summary>
        public HuurContract()
        {
            Boten = new List<IBoot>();
            ExtraArtikelen = new List<ExtraArtikel>();
        }

        /// <summary>
        /// Updates alle data van Huurcontract
        /// </summary>
        public static void UpdateData()
        {
            HuurContractRepo.UpdateData();
        }

        /// <summary>
        /// Get een Huurcontract, inclusief boten en bijkomende artikelen
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static Models.HuurContract GetHuurContract(int id)
        {
            Models.HuurContract returnContract = HuurContractRepo.GetHuurContract(id);
            returnContract.Boten = BootRepo.GetRelaventBoten(id);
            returnContract.BijkomendeArtikelen = BijkomendeArtRepo.GetRelevantArtik(id);

            return returnContract;

        }

        /// <summary>
        /// Insert ene huurcontract in de database, inclusief boten en bijkomende artikelen
        /// </summary>
        /// <param name="toInsert"></param>
        public void AanmakenHuurcontract(Models.HuurContract toInsert)
        {
            toInsert.HuurContractID = HuurContractRepo.InsertHuurContract(toInsert);

            foreach (var b in toInsert.Boten)
            {
                HuurContractRepo.InsertHuurContractBoten(b.Naam, toInsert.HuurContractID);
            }
            foreach (var b in toInsert.BijkomendeArtikelen)
            {
                HuurContractRepo.InsertHuurContractArtikels(b.ArtikelID, toInsert.HuurContractID, b.Count);
            }
        }

        /// <summary>
        /// Berekend hoeveel meren bevaren kunnen worden met het gegeven budget en gegeven keuzes voor huren.
        /// </summary>
        /// <param name="cost"></param>
        /// <param name="budget"></param>
        /// <returns></returns>
        public string PrijsBerekening(double cost, double budget)
        {
            if (budget < cost)
                return "Uw budget is lager dan de kosten van uw huur!";
            else
            {
                if (Math.Floor(budget - cost) == 0)
                    return "Uw budget is niet hoog genoeg om een meer te bevaren!";
                if (Math.Floor(budget - cost) >= 1 && Math.Floor(budget - cost) <= 5)
                    return "U kunt met dit budget " + Math.Floor(budget - cost) + " meren bevaren.";
                if ((budget - cost) > 5 && (budget - cost) < 6.5)
                    return "U kunt met dit budget 5 meren bevaren.";
                if ((budget - cost - 5) > 1.5 && (budget - cost - 5) <= 10.5)
                    return "U kunt met dit budget " + (Math.Floor((budget - cost - 5) / 1.5) + 5) + " meren bevaren.";
                if ((budget - cost - 5) > 10.5)
                    return "U kunt met dit budget alle meren bevaren!";
            }

            return "";
        }

        /// <summary>
        /// Exporteerd naar een txt bestand naar de gekozen locatie
        /// </summary>
        /// <param name="toExport"></param>
        /// <returns></returns>
        public bool Export(Models.HuurContract toExport)
        {
            try
            {
                FolderBrowserDialog fbd = new FolderBrowserDialog();
                DialogResult result = fbd.ShowDialog();
                if (result == DialogResult.OK)
                {
                    List<string> toWrite = new List<string>
                {
                    "Naam Huurder: " + toExport.Huurder.Naam,
                    "Vanaf Datum: " + toExport.BeginDatum.ToShortDateString(),
                    "Tot Datum: " + toExport.EindDatum.ToShortDateString()
                };

                    string filepath = fbd.SelectedPath;
                    File.WriteAllLines(Path.Combine(filepath, "Export.txt"), toWrite);
                    return true;
                }
            }
            catch (Exception e)
            {
                ExceptionForm frm = new ExceptionForm(e);
                frm.Show(); 
            }
            
                return false;

        }
    }
}
