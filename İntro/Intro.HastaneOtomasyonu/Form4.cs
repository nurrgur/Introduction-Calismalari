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
    public partial class Form4 : Form
    {
        private Randevu[] randevular;

        public Form4(Randevu[] r)
        {
            InitializeComponent();
            randevular = r;
            
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            lblTarih.Text = DateTime.Now.ToLongDateString();
            foreach (Randevu randevu in randevular)
            {
                ListViewItem li = new ListViewItem();
                li.Text = randevu.RandevuBolum.BolumAdi;
                li.SubItems.Add(randevu.RandevuDoktor.AdSoyad);
                li.SubItems.Add(randevu.HastaAdi);
                li.SubItems.Add(randevu.RandevuTarihi.ToString());
                li.SubItems.Add(randevu.RandevuSaati);
                li.SubItems.Add(randevu.Not);
                lstRandevu.Items.Add(li);
            }
            int sayac = 0;
            foreach (Randevu item in randevular)
            {
                sayac++;
            }
            lblRandevuSayisi.Text = sayac.ToString();

        }

    }
}
