using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneRandevuSistemi.Classes
{
    public class Doktor
    {
        public int DoktorId { get; set; }
        public string DoktorAdi { get; set; }
        public string DoktorSoyadi { get; set; }

        public int BransId { get; set; }

        public string TamAdi => $"{DoktorAdi} {DoktorSoyadi}";


    }
}
