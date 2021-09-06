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
    /// <summary>
    /// Bugüne kadar yaptığım ciro (ne kadar satış yapıldı)
    /// hangi ürünleri satmışım
    /// satılmayan ürünler raporu
    /// kalan stok miktarları
    /// şahıs olarak müşterilerim kaç tane
    /// en çok (para olarak) siparis veren müşteri
    /// Bana hiç sipariş vermeyen müşteriler
    /// hangi kategoriden kaç adet satış yapıldı örn (teknolojiden 22)
    /// </summary>
    public partial class FrmRapor : Form
    {
        private List<Siparis> siparislerim;
        private List<Urun> urunListem1;
        private List<Kategori> gelenKategoriListesi1;

        public FrmRapor()
        {
            InitializeComponent();
        }

        public FrmRapor(List<Siparis> siparislerim, List<Urun> urunListem1, List<Kategori> gelenKategoriListesi1) : this()
        {
            this.siparislerim = siparislerim;
            this.urunListem1 = urunListem1;
            this.gelenKategoriListesi1 = gelenKategoriListesi1;
        }

        private void FrmRapor_Load(object sender, EventArgs e)
        {
            // 1) ciro yu hesapla

            decimal toplamCiro = 0;
            foreach (var item in this.siparislerim)
            {
                toplamCiro += item.SiparisinTutari;
            }

            lblCiro.Text = string.Format("Toplam Ciromuz {0}", toplamCiro);


            //2)Hangi ürünleri satmışım
            List<Urun> satılanUrunler = new List<Urun>();
            foreach (Siparis siparis in siparislerim)
            {
                foreach (var detay in siparis.SiparisDetaylari)
                {
                    satılanUrunler.Add(detay.Urun);

                    ListViewItem li = new ListViewItem();
                    li.Text = detay.Urun.Ad;
                    li.SubItems.Add(detay.Adet.ToString());
                    lstSatilanUrunler.Items.Add(li);
                }
            }
            // 3)Satılmayan Ürünler (Hiç satılmayanları listeliyor.)
            //Ürün Listemden satılan ürünleri bulup çıkarıyorum
            bool kontrol = false;
            foreach (Urun urun in urunListem1)
            {
                foreach (Urun item in satılanUrunler)
                {
                    if (item.Ad == urun.Ad)
                    {
                        kontrol = true;
                        break;
                    }

                }
                if (kontrol == false)
                {
                    ListViewItem li = new ListViewItem();
                    li.Text = urun.Ad;
                    li.SubItems.Add(urun.Stok.ToString());
                    li.SubItems.Add(urun.Fiyat.ToString());
                    lstSatilmayanlar.Items.Add(li);
                }
                kontrol = false;
            }

            //4) Kalan Stoklar

            //Satılan ürünlerin detayları alındı (Stok takibi için adet bilgileri gerekliydi) ve 5.soru için müşteri bilg. alındı.
            List<SatisDetay> detaylar = new List<SatisDetay>();
            List<Musteri> musteri = new List<Musteri>();

            foreach (Siparis item in siparislerim)
            {

                foreach (SatisDetay item2 in item.SiparisDetaylari)
                {
                    detaylar.Add(item2);
                }
                musteri.Add(item.MusteriBilgileri);

            }

            //Listeden satılan ürünlerin adetleri kadar stoktan azaltılıyor 
            foreach (Urun item in urunListem1)
            {
                foreach (SatisDetay satılan in detaylar)
                {
                    if (item.Ad == satılan.Urun.Ad)
                    {
                        item.Stok = item.Stok - (satılan.Adet);
                        break;
                    }
                }

                ListViewItem li3 = new ListViewItem();
                li3.Text = item.Ad;
                li3.SubItems.Add(item.Stok.ToString());
                li3.SubItems.Add(item.Fiyat.ToString());
                lstKalanStok.Items.Add(li3);
            }

            //5) Şahıs olarak müşteriler
            foreach (Musteri item in musteri)
            {
                if (item.SahisMi == true)
                {
                    ListViewItem li = new ListViewItem();
                    li.Text = item.MusteriAdi;
                    li.SubItems.Add(item.TcvergiNo.ToString());
                    lstSahislar.Items.Add(li);
                }
            }

            // 6) En çok sipariş veren Müşteri
            decimal enCok = 0;
            string kisi = "";
            foreach (Siparis item in siparislerim)
            {
                if (enCok < item.SiparisinTutari)
                {
                    enCok = item.SiparisinTutari;
                    kisi = item.MusteriBilgileri.MusteriAdi;
                }
            }
            ListViewItem li2 = new ListViewItem();
            li2.Text = kisi;
            li2.SubItems.Add(enCok.ToString());
            lstEnCok.Items.Add(li2);

        }

    }


}

