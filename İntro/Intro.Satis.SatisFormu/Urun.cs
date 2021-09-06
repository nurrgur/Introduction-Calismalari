using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro.Satis.SatisFormu
{
    public class Urun
    {
        //public int urunId { get; set; }
        public string Ad { get; set; }
        public Kategori Kategorisi { get; set; }
        public int Stok { get; set; }
        public decimal Fiyat { get; set; }

        public override string ToString()
        {
            return Ad;
        }
    }
}
