using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro.HesapMakinesi
{
    public class Islem
    {
        public double Toplama(double sayi1,double sayi2)
        {
            return sayi1 + sayi2;
        }
        public double Cikarma(double sayi1, double sayi2)
        {
            return sayi1 - sayi2;
        }
        public double Bolme(double sayi1, double sayi2)
        {
            return sayi1 / sayi2;
        }
        public double Carpma(double sayi1, double sayi2)
        {
            return sayi1 * sayi2;
        }
        public double KareAlma(double sayi1)
        {
            return sayi1 * sayi1;
        }
        public double KupAlma(double sayi1)
        {
            return sayi1 * sayi1 * sayi1;
        }
        public double KuvvetAlma(double sayi1)
        {
            double toplam = 1;
            for(int i = 1; i <= sayi1; i++)
            {
                toplam *= 2;
            }
            if (sayi1 == 0) toplam = 0;
            return toplam;
        }
    }
}
