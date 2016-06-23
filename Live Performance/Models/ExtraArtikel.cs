using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Live_Performance.Models
{
    public class ExtraArtikel
    {
        public ExtraArtikel()
        {
            Count = 1;
        }
        public int ArtikelID { get; set; }
        public string Beschrijving { get; set; }
        public int Count { get; set; }

    }
}
