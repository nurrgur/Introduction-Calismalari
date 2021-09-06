using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro.WindUygulama
{
    /// <summary>
    /// kisi bilgilerini tutar
    /// </summary>
    public class Kisi
    {
        public Kisi()
        {
            Hobileri = new string[0];
        }
       public string ADSoyad { get; set; }
        public string TC { get; set; }
        public string[] Hobileri { get; set; }
        public bool Cinsiyet { get; set; }

        //Override işlemi ile listeye ad yazdırmayı yapıyoruz. Bu olmazsa veriler çekilemiyor ve yolu listede gözüküyor.
        public override string ToString()
        {
            return ADSoyad ;
        }
    }
}
