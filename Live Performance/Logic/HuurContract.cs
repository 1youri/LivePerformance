using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Live_Performance.Models;
using Live_Performance.Models.Boot;
using Live_Performance.Repositories;

namespace Live_Performance.Logic
{
    class HuurContract
    {
        public List<IBoot> Boten { get; set; }
        public List<ExtraArtikel> ExtraArtikelen { get; set; }

        public HuurContract()
        {
            Boten = new List<IBoot>();
            ExtraArtikelen = new List<ExtraArtikel>();
        }

        public static void UpdateData()
        {
            HuurContractRepo.UpdateData();
        }

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
    }
}
