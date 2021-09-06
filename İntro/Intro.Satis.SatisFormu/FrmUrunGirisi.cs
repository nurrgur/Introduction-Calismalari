using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Intro.Satis.SatisFormu
{
    public partial class FrmUrunGirisi : Form
    {
        List<Kategori> gelenKategoriListesi;

        public FrmUrunGirisi(List<Kategori> kategoriLİstem)
        {
            gelenKategoriListesi = kategoriLİstem;
            InitializeComponent();
        }

        private void FrmUrunGirisi_Load(object sender, EventArgs e)
        {
            cmbAltKategori.Enabled = false;
            Doldur();
        }
        //alt ve ana kategorileri ekle
        private void Doldur()
        {
            // cmbAnaKategori.DataSource = gelenKategoriListesi;
            foreach (Kategori item in gelenKategoriListesi)
            {
                if (item.UstKategoriMi)
                {
                    cmbAnaKategori.Items.Add(item);
                }

            }
        }

        private void cmbAnaKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbAltKategori.Items.Clear();
            cmbAltKategori.Enabled = true;
            //var hede = cmbAnaKategori.SelectedItem as Kategori; //Kategori as olmazsa alt satırda bilgiler çekilemez.
            var secilenKategori = cmbAnaKategori.SelectedItem as Kategori;
            foreach (var item in gelenKategoriListesi)
            {
                if (item.Kategorisi != null)
                {
                    if (item.Kategorisi.KategorAdi == secilenKategori.KategorAdi)
                    {
                        //alt kategori
                        cmbAltKategori.Items.Add(item);
                    }
                }
            }
        }
        List<Urun> urunListem = null;
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtUrunAdi.Text))
            {
                //dolu
                errorProvider1.Clear();

                if (urunListem == null)
                {
                    urunListem = new List<Urun>();
                }

                if (cmbAnaKategori.SelectedItem == null || cmbAltKategori.SelectedItem == null)
                {
                    MessageBox.Show("Lütfen kategori seçimlerini yapınız...");
                }
                else if (numericUpDown1.Value <= 0) MessageBox.Show("Stok değeri 0 dan büyük olmalı..");

                else if (string.IsNullOrWhiteSpace(txtFiyat.Text)) MessageBox.Show("Fiyat boş bırakılamaz...");

                else if (Convert.ToDecimal(txtFiyat.Text) <= 0) MessageBox.Show("Fiyat 0 dan büyük girilmeli..");
                else
                {
                    veriEkle();
                    Temizle();
                }
                //temizle
                //eklendi..
            }
            else
            {
                //boş
                errorProvider1.SetError(txtUrunAdi, "boş geçilemez");
            }

            #region Olması gereken özellikler
            // Fiyat ve stok 0 olmamalı ve numara olmalı
            //Kategoriler seçilmeden kayıt alınmamalı
            //temizle
            //validation
            //eklendi bilgisi 
            #endregion
        }
        private void veriEkle()
        {
            urunListem.Add(new Urun()
            {
                Ad = txtUrunAdi.Text,
                Fiyat = decimal.Parse(txtFiyat.Text),
                Stok = Convert.ToInt32(numericUpDown1.Value),
                Kategorisi = cmbAltKategori.SelectedItem as Kategori
            });
            MessageBox.Show(txtUrunAdi.Text+" Başarıyla eklendi..");
        }

        private void btnGec_Click(object sender, EventArgs e)
        {
            FrmSiparis siparis = new FrmSiparis(urunListem, gelenKategoriListesi);
            siparis.Show();
        }

        private void Temizle()
        {
            txtUrunAdi.Text = "";
            txtFiyat.Text = "";
            numericUpDown1.Value = 1;
        }

    }
}
