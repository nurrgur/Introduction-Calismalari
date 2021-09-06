using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro.WindUygulama
{
    class Personel
    {
        public string Ad { get; set; }
        public string Soyad 
        {
            get
            {
                return _soyad;
            }
            set
            {
                string ekVeri = "123";
                _soyad = value;
                _soyad = _soyad + ekVeri;
            }
        }
        
        string _soyad;
        string _tc = "";
        public string TcKimlik
        {
            get { return _tc; }
            set
            {
                _tc = value;

                if (_tc[0]== '0')
                {
                    //Hata
                    throw new Exception("Tc 0 ile başlayamaz..");
                }
                //11 haneli kontrolü-------------------------------------
                HaneKontrolu(_tc);

                //Son hane çift olmalı
                sonHaneCiftMi(_tc);
                if (sonHaneCiftMi(_tc) == false)
                {
                    throw new Exception("Son hane çift sayi olmalı..");
                }

                //hepsi numara mı?--------------------------------------
                if (sonHaneCiftMi(_tc) == true)
                {
                    bool numaraMi = hepsiNumaraMi(_tc);
                    if (numaraMi != true)
                    {
                        throw new Exception("Yanlış karakter kullanıldı..");
                    }

                }
                else
                {
                    throw new Exception("hata var");
                }

            }
        }
        public int HaneKontrolu(string tc)
        {
            if (tc.Length == 11)
            {
                return 11;
            }
            else throw new Exception("11 haneli değil...");
        }

        public bool sonHaneCiftMi(string tcKimlik)
        {
            if ((tcKimlik[10] % 2) == 0)
            {
                return true;
            }
            else return false;
        }
        public bool hepsiNumaraMi(string tc)
        {
            return true;
        }

    }


}
