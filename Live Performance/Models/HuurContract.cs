using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Live_Performance.Models
{
    class HuurContract
    {
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

    }
}
