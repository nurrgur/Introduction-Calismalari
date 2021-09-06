using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro.Satis.SatisFormu
{
    public class SatisDetay
    {
       
        public Urun  Urun{ get; set; }
        public int Adet { get; set; }

        public override string ToString()
        {
            //fiyat +adet
            //Urun.Ad + " " + Adet;
            // return Urun.Fiyat * Adet;
            return string.Format("urun adi: {0} , adet:{1} olan urunun fiyatı={2}", Urun.Ad, Adet, (Urun.Fiyat * Adet)); //String olmayan veriler string olarak gözüküyor.
        }
    }
}
