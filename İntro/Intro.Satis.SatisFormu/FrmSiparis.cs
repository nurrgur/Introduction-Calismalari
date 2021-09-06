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
    public partial class FrmSiparis : Form
    {
        private List<Urun> urunListem1;
        private List<Kategori> gelenKategoriListesi1;

        public FrmSiparis()
        {

        }

        public FrmSiparis(List<Urun> urunListem, List<Kategori> gelenKategoriListesi) //: this()
        {
            this.urunListem1 = urunListem;
            this.gelenKategoriListesi1 = gelenKategoriListesi;
            InitializeComponent();
        }

        private void FrmSiparis_Load(object sender, EventArgs e)
        {
            cmbAltKategori.Enabled = false;
            foreach (var item in urunListem1)
            {
                lstUrunler.Items.Add(item);
            }

            foreach (Kategori k in gelenKategoriListesi1)
            {
                if (k.UstKategoriMi)
                {
                    cmbAnaKategori.Items.Add(k);
                }
            }
            //urunler
            //lstUrunler.DataSource = urunListem1;
            //cmbAnaKategori.DataSource = gelenKategoriListesi1;

        }

        private void cmbAnaKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbAltKategori.Enabled = true;
            cmbAltKategori.Items.Clear();
            foreach (var item in gelenKategoriListesi1)
            {
                if (item.UstKategoriMi == false && item.Kategorisi != null)
                {
                    if (item.Kategorisi.KategorAdi == (cmbAnaKategori.SelectedItem as Kategori).KategorAdi)
                    {
                        cmbAltKategori.Items.Add(item);
                    }

                }
            }
        }

        private void cmbAltKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstUrunler.Items.Clear();

            foreach (Urun item in urunListem1)
            {
                if (item.Kategorisi.KategorAdi == (cmbAltKategori.SelectedItem as Kategori).KategorAdi)
                {
                    lstUrunler.Items.Add(item);
                }
            }
        }

        private void lstUrunler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstUrunler.SelectedItem == null) return;

            var secilenUrun = lstUrunler.SelectedItem as Urun;
            // lblStokBilgisi.Text = secilenUrun.Stok > 0 ? secilenUrun.Stok + "adet ile ürün stokta var" : "stok yok";
            if (secilenUrun.Stok > 0)
            {
                lblStokBilgisi.Text = secilenUrun.Stok + "adet ile ürün stokta var";
                numericUpDown1.Maximum = secilenUrun.Stok;
                lblFiyat.Text = secilenUrun.Fiyat.ToString();
            }
            else
            {
                lblStokBilgisi.Text = "stokta yok";
                // btnSepeteAt.Enabled = numericUpDown1.Enabled = false;
            }
            btnSepeteAt.Enabled = numericUpDown1.Enabled = (secilenUrun.Stok > 0);
        }

        private void btnSepeteAt_Click(object sender, EventArgs e)
        {
            if (lstUrunler.SelectedItem != null && (numericUpDown1.Enabled))
            {
                if ((lstUrunler.SelectedItem as Urun).Stok < numericUpDown1.Value)
                {
                    MessageBox.Show("stoktan fazla ürün girdiniz.." + (lstUrunler.SelectedItem as Urun).Stok + "adet stok var. ");
                    return;
                }
                else
                {
                    lstSepetim.Items.Add(
                        new SatisDetay()
                        {
                            Adet = Convert.ToInt32(numericUpDown1.Value),
                            Urun = lstUrunler.SelectedItem as Urun
                        }
                        );
                }
            }
            else
            {
                //seçimler düzgün değil.
                MessageBox.Show("Urun ve adet bilgisi giriniz. ");
            }

        }
        List<Siparis> siparislerim = new List<Siparis>();
        private void btnSiparisiTamamla_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMusteri.Text))
            {
                if (checkBox1.Checked)
                {
                    //sahis
                    if (mskdTC.MaskFull == false)
                    {
                        MessageBox.Show("Lütfen Tc kimlik numaranızı tam giriniz..");
                        return;
                    }

                }
                else
                {
                    //firma
                    if (mskdVergiNo.MaskFull == false)
                    {
                        MessageBox.Show("Lütfen Vergi numaranızı tam giriniz..");
                        return;
                    }

                }
                //siparis tamamla
                //Siparis s = new Siparis();

                siparislerim.Add(
                    new Siparis()
                    {
                        MusteriBilgileri = new Musteri()
                        {
                            MusteriAdi = txtMusteri.Text,
                            SahisMi = checkBox1.Checked,
                            TcvergiNo = checkBox1.Checked == true ? mskdTC.Text : mskdVergiNo.Text
                        },
                        SiparisDetaylari = SiparisDetaylariAl(),
                        Tarih = DateTime.Now
                    }
                    );
                MessageBox.Show("Siparişiniz Tamamlandı....");
                Temizle();
            }
            else MessageBox.Show("Lütfen Müşteri adını doldurunuz..");
        }

        private void Temizle()
        {
            txtMusteri.Text = "";
            checkBox1.Checked = true;
            mskdTC.Text = null;
            mskdVergiNo.Text = null;
            lstSepetim.Items.Clear();
        }

        private List<SatisDetay> SiparisDetaylariAl()
        {
            List<SatisDetay> sepetim = new List<SatisDetay>();
            foreach (SatisDetay item in lstSepetim.Items)
            {
                sepetim.Add(item);
            }
            return sepetim;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                lblTc.Visible = mskdTC.Visible = true;
                lblVergi.Visible = mskdVergiNo.Visible = false;
            }
            else
            {
                lblVergi.Visible = mskdVergiNo.Visible = true;
                lblTc.Visible = mskdTC.Visible = false;
            }
        }

        private void btnGec_Click(object sender, EventArgs e)
        {
            FrmRapor frm = new FrmRapor(siparislerim, urunListem1, gelenKategoriListesi1);
            frm.Show();

        }
    }
}
