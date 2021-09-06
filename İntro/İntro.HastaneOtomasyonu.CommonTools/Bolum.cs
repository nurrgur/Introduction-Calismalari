using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İntro.HastaneOtomasyonu.CommonTools
{
    public class Bolum
    {
        public string BolumAdi { get; set; }
        public string Acıklama { get; set; }

        public override string ToString()
        {
            return BolumAdi;
        }
    }
}
