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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGec_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            Bolum bolum = new Bolum();
            //DegerOlustur();
            //form.cmbBolumler.DataSource=DegerOlustur();
            foreach (Bolum item in DegerOlustur())
            {
                f.cmbBolumler.Items.Add(item);
            }
            //2.yontem
            //foreach(Bolum b in lstBolum.Items)
            //{
            //    f.cmbBolumler.Items.Add(b);
            //}
            //f.cmbBolumler.Items.Add("");
            f.Show();
        }

        private Bolum[] DegerOlustur()
        {
            //List ile de yap
            Bolum[] bolumlerim = new Bolum[0];
            foreach (Bolum item in lstBolum.Items)
            {
                Array.Resize(ref bolumlerim, bolumlerim.Length + 1);
                bolumlerim[bolumlerim.Length - 1] = item;
            }
            return bolumlerim;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            bool kontrol = false;
            //doğru verileri al //eksik girerse uyar.(bizde) 
            //listboxa bolum tipinde yaz 
            //lst de ad bilgisi görünecek şekilde ayarla 
            //doğru şekilde eklersen ya da ekleyemezsen kullanıcıya bilgi ver
            //>> butona tıkladığında listboxtaki tüm verilerle birlikte form2 ye git.
            //Sil güncelle ekle!!!!!!

            if (txtBolum.Text == string.Empty || txtAcıklama.Text == string.Empty)
            {
                MessageBox.Show("Lütfen istenen yerleri doldurunuz..");
                kontrol = true;
            }
            if (kontrol == false)
            {
                try
                {
                    Bolum bolum = new Bolum();
                    bolum.BolumAdi = txtBolum.Text;
                    bolum.Acıklama = txtAcıklama.Text;
                    lstBolum.Items.Add(bolum);
                    MessageBox.Show(bolum.BolumAdi + "  Bölümü başarılı bir şekilde eklendi"); //burası kbb eklendi .. eklendi şeklinde olucak.
                    btnGec.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("hata verdi");
                }
                finally
                {
                    Temizle();//her zaman çalışıcak.
                }
            }
        }

        private void Temizle()
        {
            txtBolum.Text = txtAcıklama.Text = "";
        }
        Bolum secilmisBolum = null;
        private void lstBolum_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            secilmisBolum = (Bolum)lstBolum.SelectedItem;
            if (secilmisBolum == null) return;

            txtBolum.Text = secilmisBolum.BolumAdi;
            txtAcıklama.Text = secilmisBolum.Acıklama;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lstBolum.SelectedItem == null)
            {
                MessageBox.Show("İşleminizi lütfen kontrol edin..");
            }
            else
            {
                int silinecekSatir = lstBolum.SelectedIndex;
                lstBolum.Items.RemoveAt(silinecekSatir);
                Temizle();
            }
        }
        Bolum guncelBolum = null;
        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            if (lstBolum.SelectedItem == null)
            {
                MessageBox.Show("Lütfen güncellemek istediğiniz satırı seçin..");
            }
            else
            {
                guncelBolum = (Bolum)lstBolum.SelectedItem;
                guncelBolum.BolumAdi = txtBolum.Text;
                guncelBolum.Acıklama = txtAcıklama.Text;
                lstBolum.Items.Add(guncelBolum);
                lstBolum.Items.RemoveAt(lstBolum.SelectedIndex);
                Temizle();
            }
        }
    }
}
