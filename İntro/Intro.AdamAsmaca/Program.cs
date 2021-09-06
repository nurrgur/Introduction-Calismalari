using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Intro.AdamAsmaca
{
    class Program
    {
        static void Main(string[] args)
        {
            char c;
            int hak = 0;
            Console.WriteLine("----------------Adam Asmaca Oyunu---------");
            string[] kelime = { "kalem", "kitap", "silgi", "defter" };

            Random rastgele = new Random();
            int sec = rastgele.Next(0, 3);
            int secilenUzunluk = kelime[sec].Length;
            string secilen = kelime[sec];
            //Console.WriteLine(secilen);
            int sayac = 0;

            for (int j = 0; j < secilenUzunluk; j++)
            {
                Console.WriteLine("Harf Giriniz..");
                c = Convert.ToChar(Console.ReadLine());
                int s = 0;

                for (int i = 0; i < secilenUzunluk; i++)
                {
                    if (c == secilen[i])
                    {
                        Console.WriteLine("Harf Bulundu : " + secilen[i]);
                        break;
                    }
                    s++;
                }
                if (s >= secilenUzunluk)
                {
                    Console.WriteLine("Yanlış Harf Girildi..");
                    hak += 1;
                    Console.WriteLine(hak + ". Hakkınızı kullandınız (Toplam hak sayınız 6)");
                    j--;
                }

                if (hak >= 6)
                {
                    Console.WriteLine("Oyunu Kaybettiniz..");
                    Thread.Sleep(2000);
                    Environment.Exit(0);
                }
                sayac++;
            }

            if (sayac >= secilenUzunluk && hak < 6)
            {
                Console.WriteLine("Oyunu kazandınız...");
                Console.WriteLine("Doğru Kelime: " + secilen);
                Thread.Sleep(2000);
                Environment.Exit(0);
            }

            Console.ReadLine();

        }
    }
}
