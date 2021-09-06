using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İntro.HastaneOtomasyonu.CommonTools
{
    public class Doktor
    {
        public string AdSoyad { get; set; }
        public string CepTel { get; set; }
        public string Mail { get; set; }
        public Bolum DoktorunBolumu { get; set; }

        public override string ToString()
        {
            return AdSoyad + " " + DoktorunBolumu;
        }


    }
}
