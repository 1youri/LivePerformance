using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Live_Performance.Models.Boot;

namespace Live_Performance.Models
{
    public class HuurContract
    {
        public HuurContract()
        {
        }

        public HuurContract(int huurContractID, Account huurder, DateTime beginDatum, DateTime eindDatum)
        {
            HuurContractID = huurContractID;
            Huurder = huurder;
            BeginDatum = beginDatum;
            EindDatum = eindDatum;
        }

        public int HuurContractID { get; set; }
        public Account Huurder { get; set; }
        public DateTime BeginDatum { get; set; }
        public DateTime EindDatum { get; set; }
        public List<IBoot> Boten { get; set; }
        public List<ExtraArtikel> BijkomendeArtikelen { get; set; }

    }
}
