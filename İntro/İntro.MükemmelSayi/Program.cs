using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İntro.MükemmelSayi
{
    class Program
    {
        static void Main(string[] args)
        {
            int toplam = 0;
            int sayi;


            Console.WriteLine("Bir sayı giriniz..");
            sayi = Convert.ToInt32(Console.ReadLine());
            while (true)
            {
                if (sayi <= 0)
                {
                    Console.WriteLine("Hatalı giriş... Lütfen pozitif bir sayı giriniz..");
                    sayi = Convert.ToInt32(Console.ReadLine());
                }
                else break;
            }

            for (int i = 1; i < sayi; i++)
            {
                if (sayi % i == 0) toplam = toplam + i;
            }

            if (toplam == sayi) Console.WriteLine(sayi + " sayısı Mükemmel Sayıdır");

            else Console.WriteLine(sayi + " sayısı Mükemmel Sayı Değildir");

            Console.ReadLine();

        }
    }
}
