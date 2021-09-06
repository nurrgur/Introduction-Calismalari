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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void ButonLotoOyna_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            foreach (Control item in this.Controls)   //Eğer içindekilerin buton old. emin olsaydık Button item diyebilirdik.
            { //if ile itemin buton olup olmadığı ve hangi butonda olduğu kontrol ediliyor.
                if (item is Button && item.Text != "Loto Oyna" && item.Text!= "Adam Asmaca Oyunu")
                {
                    item.Text = (r.Next(1, 100)).ToString();
                }
            }

            #region UzunYol
            //------Uzun Yol-----------
            //int[] deger = new int[6];
            //Random rdn = new Random();
            //for (int i = 0; i < 6; i++)
            //{
            //    deger[i] = rdn.Next(1, 100);
            //    for (int j = 0; j < i; j++)
            //    {
            //        if (deger[i] == deger[j])
            //        {
            //            i--;
            //        }
            //    }
            //}
            //button1.Text = deger[0].ToString();
            //button2.Text = deger[1].ToString();
            //button3.Text = deger[2].ToString();
            //button4.Text = deger[3].ToString();
            //button5.Text = deger[4].ToString();
            //button6.Text = deger[5].ToString(); 
            #endregion

        }

        private void OyunaGec_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.Show();
        }
    }
}
