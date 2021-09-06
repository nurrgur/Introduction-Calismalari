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
    public partial class Form3 : Form
    {
        Bolum[] gelenBulumler;
        Doktor[] gelenDoktorlar;
        public Form3(Bolum[] girilmisBolumler, Doktor[] girilmisDoktorlar) : this(7)
        {
            this.gelenBulumler = girilmisBolumler;
            this.gelenDoktorlar = girilmisDoktorlar;
            //InitializeComponent();
            //combobox ve listeyi doldur.
            foreach (Bolum blm in girilmisBolumler)
            {
                cmbBolum.Items.Add(blm);
            }
            foreach (Doktor dktr in girilmisDoktorlar)
            {
                lstDoktor.Items.Add(dktr);
            }

        }
        public Form3(int i)
        {
            InitializeComponent();
        }
        const int hede = 5;
        public Form3() : this(hede)
        {

        }


        private void btnAra_Click(object sender, EventArgs e)
        {

        }
        // Doktor secilenDoktor = null;
        private void cmbBolum_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstDoktor.Items.Clear();
            foreach (var item in gelenDoktorlar)
            {
                if (item.DoktorunBolumu == cmbBolum.SelectedItem)
                {
                    lstDoktor.Items.Add(item);
                }
            }

        }
        Randevu[] randevular = new Randevu[0];
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (cmbBolum.SelectedItem == null || lstDoktor.SelectedItem == null)
            {
                MessageBox.Show("Lütfen Bölüm ve Doktor seçimi yaptığınızdan emin olun..");
            }
            else if (txtHastaAdi.Text == string.Empty || dateTimePicker1.Value == null || txtnot.Text == string.Empty || mskdSaat.MaskFull == false)
            {
                MessageBox.Show("Lütfen bilgilerinizi eksiksiz doldurun..");
            }
            else
            {
                Randevu randevu = new Randevu();
                randevu.RandevuBolum = cmbBolum.SelectedItem as Bolum;
                randevu.RandevuDoktor = lstDoktor.SelectedItem as Doktor;
                randevu.HastaAdi = txtHastaAdi.Text;
                randevu.RandevuTarihi = dateTimePicker1.Value.ToString("dd-MM-yyyy");
                randevu.RandevuSaati = mskdSaat.Text;
                randevu.Not = txtnot.Text;
                Array.Resize(ref randevular, randevular.Length + 1);
                randevular[randevular.Length - 1] = randevu;

                MessageBox.Show("Randevunuz eklendi...");
                btnGunSonu.Enabled = true;
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            lblTarih.Text = DateTime.Now.ToLongDateString();
        }

        private void txtDrAra_TextChanged(object sender, EventArgs e)
        {
            lstDoktor.Items.Clear();

            foreach (Doktor doktor in gelenDoktorlar)
            {
                if (doktor.AdSoyad.StartsWith(txtDrAra.Text.ToUpper()) || (doktor.AdSoyad.StartsWith("") && (txtDrAra.Text == "")))
                {
                    lstDoktor.Items.Add(doktor);
                }
            }





        }
        private void btnGunSonu_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4(randevular);
            f.Show();
        }
    }
}
