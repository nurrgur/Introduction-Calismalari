using İntro.HastaneOtomasyonu.CommonTools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Intro.HastaneOtomasyonu
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnGec_Click(object sender, EventArgs e)
        {


            Bolum[] bolum = new Bolum[0];
            foreach (Bolum item in cmbBolumler.Items)
            {
                Array.Resize(ref bolum, bolum.Length + 1);
                bolum[bolum.Length - 1] = item;
            }
            Doktor[] doktorlarim = new Doktor[0];
            foreach (Doktor item in lstDoktor.Items)
            {
                Array.Resize(ref doktorlarim, doktorlarim.Length + 1);
                doktorlarim[doktorlarim.Length - 1] = item;
            }


            Form3 randevuEkrani = new Form3(bolum, doktorlarim);

            randevuEkrani.Show();
        }
        //geç butonuna tıklandığı zaman form1 deki bölümleri ve form 2 deki doktorları form3 e gönder.
        private void btnEkle_Click(object sender, EventArgs e)
        {
            //kontrol et doğru mu eksiksiz mi veriler, bolumu seçilmiş mi seçilmediyse kaydetme
            //Doktoru kaydet-> bilgi ver
            //ortamı temizle
            if (txtAdSoyad.Text == string.Empty )
            {
                MessageBox.Show("Ad Soyad kısmı boş geçilemez..");
            }
            else if(cmbBolumler.SelectedItem == null)
            {
                MessageBox.Show("Bölüm alanı boş bırakılamaz");
            }
            else if (mskdTel.MaskFull == false)
            {
                MessageBox.Show("Lütfen telefon numaranızı tam giriniz..");
            }
            else if (txtmail.Text.Contains("@") == false)
            {
                MessageBox.Show("Lütfe mail adresinizi tam girin..");
            }
            else
            {
                lstDoktor.Items.Add(
                    new Doktor()
                    {
                        AdSoyad = txtAdSoyad.Text.ToUpper(),
                        Mail = txtmail.Text,
                        CepTel = mskdTel.Text,
                        DoktorunBolumu = cmbBolumler.SelectedItem as Bolum

                    }
                    );
                MessageBox.Show(txtAdSoyad.Text+" isimli doktor "+cmbBolumler.Text+" bölümüne eklendi.."); //Yanlış çalışırsa hata demeli try catch
                btnGec.Enabled = true;
                Temizle();
            }
        }

        private void Temizle()
        {
            txtmail.Text = txtAdSoyad.Text = mskdTel.Text = string.Empty;
            //combobox ı seçilmemiş gibi yap 
            cmbBolumler.SelectedItem = null;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lstDoktor.SelectedItem == null) return;
            else
            {
                lstDoktor.Items.RemoveAt(lstDoktor.SelectedIndex);
                Temizle();
                MessageBox.Show("Silme işlemi tamamlandı");
            }
            
        }
        Doktor secilendoktor = null;
        private void lstDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstDoktor.SelectedItem == null) return;
            else
            {
                secilendoktor = (Doktor)lstDoktor.SelectedItem;
                txtAdSoyad.Text = secilendoktor.AdSoyad;
                cmbBolumler.Text = secilendoktor.DoktorunBolumu.BolumAdi;
                mskdTel.Text = secilendoktor.CepTel;
                txtmail.Text = secilendoktor.Mail;
                
            }
        }
        Doktor guncellenenDoktor = null;
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (lstDoktor.SelectedItem == null) return;
            else
            {
                guncellenenDoktor = (Doktor)lstDoktor.SelectedItem;
                guncellenenDoktor.AdSoyad = txtAdSoyad.Text;
                guncellenenDoktor.CepTel = mskdTel.Text;
                guncellenenDoktor.DoktorunBolumu.BolumAdi = cmbBolumler.SelectedItem.ToString();
                lstDoktor.Items.Add(guncellenenDoktor);
                lstDoktor.Items.RemoveAt(lstDoktor.SelectedIndex);
                Temizle();
                MessageBox.Show("Güncelleme gerçekleştirildi..");
            }
        }
    }
}
