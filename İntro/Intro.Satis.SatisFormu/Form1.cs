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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //checkbox true ise ana kategoridir o yüzden alttaki textbox ve label false yapılır.
            lblKategori.Visible = cmbKategoriler.Visible = checkBox1.Checked == true ? false : true;
        }

        List<Kategori> KategoriLİstem = new List<Kategori>();
        private void btnEkle_Click(object sender, EventArgs e)
        {
            #region OlmasıGerekenler
            //validation textbox dolu mu 
            //listview de goster
            //ana kategori ise comboda göster
            //override ve formu temizleme ve gerekli mesajları ver 
            #endregion

            //Aynı isimde kategoriler eklenemez.
            foreach (Kategori item in KategoriLİstem)
            {
                if(item.KategorAdi==txtkategoriAdi.Text)
                {
                    MessageBox.Show("Bu kategori zaten var...");
                        return;
                }
            }

            //txtkategori adı  hiçbir zaman boş olmamalı.
            if (string.IsNullOrWhiteSpace(txtkategoriAdi.Text))
            {
                MessageBox.Show("Kategori adı boş bırakılamaz..");
            }

            //Eğer checkbox false ise bir üst kategori seçmek zorunludur.
            else if(checkBox1.Checked==false && cmbKategoriler.SelectedItem == null)
            {
                MessageBox.Show("Lütfen bir üst kategori seçiniz..");
            }

            else
            {
                //Kategori sınıfından her ekle denildiğinde bir kategori nesnesi üretilir ve listede tutulur.
                Kategori k = new Kategori();
                k.KategorAdi = txtkategoriAdi.Text;
                k.Kategorisi = checkBox1.Checked == false ? cmbKategoriler.SelectedItem as Kategori : null;
                k.UstKategoriMi = checkBox1.Checked;

                KategoriLİstem.Add(k);
                if (checkBox1.Checked)
                {
                    cmbKategoriler.Items.Add(k);
                }
                ListViewItem li = new ListViewItem();
                li.Text = k.KategorAdi;
                li.SubItems.Add((k.UstKategoriMi == false) ? k.Kategorisi.KategorAdi : "-");
                li.Tag = k; //diğer forma gönderirken boş kalmaması için
                listView1.Items.Add(li);
                Temizle();
                btnGec.Enabled = true;
            }
        }

        private void btnGec_Click(object sender, EventArgs e)
        {
            //List<Kategori> deger = new List<Kategori>();
            //foreach (ListViewItem item in listView1.Items)
            //{
            //    deger.Add(item.Tag as Kategori);
            //}
            FrmUrunGirisi giris = new FrmUrunGirisi(KategoriLİstem);
            giris.Show();
        }

        public void Temizle()
        {
            txtkategoriAdi.Text = "";
            cmbKategoriler.SelectedItem = null;
        }
    }
}
