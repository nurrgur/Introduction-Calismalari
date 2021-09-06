using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Intro.CommonTools;
namespace Intro.WindUygulama
{
    public partial class Form1 : Form
    {
        int hak = 3;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            try
            {
                Personel p = new Personel();
                p.Ad = "nur";
                p.Soyad = "gür";
                p.TcKimlik = "12345678900";
            }

            catch (Exception ex)
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // tc ve sifre bilgisi textlerden alındı
            string TcBilgisi = txtTc.Text;
            string SifreBilgisi = TxtSifre.Text;

            Sorgula(SifreBilgisi, TcBilgisi, hak);
            //MessageBox.Show((TcBilgisi == "12345") && (SifreBilgisi == "abc") ? "Hoşgeldiniz" : "Hatalı giriş");

            #region Kütüphanede ki methodu kullanma 
            //StringControls s = new StringControls();
            //string deneme = "deneme";
            //s.ToUpper(deneme);  
            #endregion

        }

        public void Sorgula(string sifre, string tc, int hakk)
        {
            if (sifre == "abc" && tc == "12345")
            {
                MessageBox.Show("Giriş Yapıldı..");
            }
            else if (sifre != "abc" || tc != "12345")
            {
                MessageBox.Show("Hatalı giriş..");
                hak = hakk - 1;
                Console.WriteLine(hak);
                if (hak == 0)
                {
                    MessageBox.Show("3 kere hatalı giriş yapıldı..");
                }
            }

        }
    }
}
