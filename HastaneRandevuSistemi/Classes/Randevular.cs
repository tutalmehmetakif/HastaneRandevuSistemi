using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneRandevuSistemi.Classes
{
    public class Randevular
    {
        public int RandevuId { get; set; }
        public string HastaAdi { get; set; }

        public string HastaSoyadi { get; set; }

        public int BransId { get; set; }

        public DateTime Tarih { get; set; }

        public int DoktorId { get;set; }
    }
}
