using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro.Satis.SatisFormu
{
   public  class Siparis
    {
        public Musteri MusteriBilgileri { get; set; }
        public List<SatisDetay> SiparisDetaylari { get; set; }
        public DateTime Tarih { get; set; }

        public decimal SiparisinTutari
        {//set olmak zorunda değil get olmak zorunda
            get
            {
                decimal toplam = 0;
                foreach (var item in SiparisDetaylari)
                {
                    toplam += item.Adet * item.Urun.Fiyat;
                }
                return toplam;
            }

        }
    }
}
