using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro.Satis.SatisFormu
{
    public class Kategori
    {
        public string KategorAdi { get; set; }
        //alt kategori
        public Kategori Kategorisi { get; set; }
        public bool UstKategoriMi { get; set; }
        public override string ToString()
        {
            return KategorAdi;
        }

    }
}
