using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İntro.HastaneOtomasyonu.CommonTools
{
    public class Randevu
    {
        public Bolum RandevuBolum { get; set; }
        public Doktor RandevuDoktor { get; set; }
        public string HastaAdi { get; set; }
        public string RandevuTarihi { get; set; }
        public string RandevuSaati { get; set; }
        public string Not { get; set; }

    }
}
