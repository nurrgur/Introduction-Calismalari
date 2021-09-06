using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Intro.WindUygulama
{
    public partial class FrmKisiKaydetme : Form
    {
        public FrmKisiKaydetme()
        {
            InitializeComponent();
        }

        private void FrmKisiKaydetme_Load(object sender, EventArgs e)
        {
            object o = 0;
            cmbhobi.Items.Add("yüzme");
            cmbhobi.Items.Add("satranç");
            cmbhobi.Items.Add("kitap okuma");
        }
        /// <summary>
        /// kişinin bilgilerinin doğruluğunu kontrol et..
        /// </summary>
        private void btnKisiKaydet_Click(object sender, EventArgs e)
        {
            //kontrol (veriler gelmiş mi)
            //Kisi olustur.

            string mesaj = "";

            if (string.IsNullOrWhiteSpace(txtAdSoyad.Text))
            {
                mesaj = mesaj + "adınızı soyadınızı giriniz.";
            }
            if (msTCkimlik.Text.Length != 11)
            {
                mesaj = mesaj + "Lütfen 11 haneli TC Kimlik numaranızı giriniz..";
            }
            if (kisininHobileri.Length == 0)
            {
                mesaj = mesaj + "Lütfen hobi giriniz.";
            }
            if (mesaj == "")
            {
                Kisi k = new Kisi();
                k.Cinsiyet = rdpkadin.Checked;
                k.ADSoyad = txtAdSoyad.Text;
                k.TC = msTCkimlik.Text;
                k.Hobileri = kisininHobileri;
                lstKisilerim.Items.Add(k);
                Temizle();
            }
            else
            {
                MessageBox.Show(mesaj);
            }
        }

        private void Temizle()
        {
            kisininHobileri = new string[0];
            txtAdSoyad.Text = msTCkimlik.Text = string.Empty; //empty ile textlerin içleri boşaltılıyor.
            rdpkadin.Checked = true;
            cmbhobi.SelectedText = "";
            label1.Text = "";
        }

        string[] kisininHobileri = new string[0];
        private void btnHobiEkle_Click(object sender, EventArgs e)
        {
            //seçimi kontrol et
            //aynı hobiyi seçmediğini kontrol et
            if (!kisininHobileri.Contains(cmbhobi.SelectedItem.ToString()))
            {
                Array.Resize(ref kisininHobileri, kisininHobileri.Length + 1);
                kisininHobileri[kisininHobileri.Length - 1] = cmbhobi.SelectedItem.ToString();
                MessageBox.Show(cmbhobi.SelectedItem.ToString() + " hobilerinize eklendi");
            }
            else
            {
                MessageBox.Show(cmbhobi.SelectedItem.ToString() + " hobilerinizde zaten ekli");
            }
        }
        Kisi secilmiskisi = null;
        private void lstKisilerim_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstHobiler.Items.Clear(); //Her tıklamada eski veriler silinecek hobi listesinden
            //adına tıkladığımızda özellikleri çıkacak
            secilmiskisi = (Kisi)lstKisilerim.SelectedItem;
            if (secilmiskisi == null)
                return;
            Listele(secilmiskisi);
        }

        private void Listele(Kisi secilmisKisi)
        {
            txtAdSoyad.Text = secilmiskisi.ADSoyad;
            msTCkimlik.Text = secilmiskisi.TC;
            if (secilmiskisi.Cinsiyet == true)
            {
                rdpkadin.Checked = true;
            }
            else
            {
                rdpErkek.Checked = true;
            }

            string cinsiyet = (secilmiskisi.Cinsiyet == true) ? "Kadın" : "Erkek";
            string hobiler = "";
            foreach (var item in secilmiskisi.Hobileri)
            {
                hobiler += item + " ";
                lstHobiler.Items.Add(item);// hobiler ayrı listeye ekleniyor
            }
            //labelda göster 
            label1.Text = secilmiskisi.ADSoyad + "\n" + secilmiskisi.TC + "\n" + hobiler + "\n" + cinsiyet;
        }

        bool kontrolEt()
        {
            return true; // true yerine yukardaki kontrolün ifi yazılıcak
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            Kisi secilenKisi= (Kisi)lstKisilerim.SelectedItem;
            int secilenHobi = lstHobiler.SelectedIndex;

            if (secilenKisi !=null &&secilenHobi!=-1)
            {
                lstHobiler.Items.RemoveAt(secilenHobi);
                string hobiler = "";
                foreach (var item in lstHobiler.Items)
                {
                    hobiler += (" " + item.ToString());
                }
                label1.Text = "";
                label1.Text = ("Ad Soyad: "+txtAdSoyad.Text+"\nTc: "+msTCkimlik.Text+"\nHobiler: "+hobiler);

            }
            else
            {
                MessageBox.Show("Seçim Yapın!");
            }

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            //ekledeki kontroller burda da çalışmalı
            //boş güncelleyememeli 
            secilmiskisi.ADSoyad = txtAdSoyad.Text;
            secilmiskisi.Cinsiyet = rdpkadin.Checked;

            //lstKisilerim.Items[lstKisilerim.SelectedIndex] = secilmiskisi;


        }
    }
    
}
