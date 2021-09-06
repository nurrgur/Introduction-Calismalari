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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Temizle()
        {
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel2.Controls.Clear();

            foreach (Button item in flowLayoutPanel3.Controls)
            {
                item.Visible = false;
            }
        }

        private void btnBasla_Click(object sender, EventArgs e)
        {   //Baslaya basıldığında temizleme,kelime secme ve harf getirme işlemleri olmalı.
            Temizle();
            AlfabeyiOlustur();
            kelimeSec();

        }

        private void kelimeSec()
        {
            //random kelime seç
            //Random rdn = new Random();
            //int index = rdn.Next(0, 2);
            //string kelime = kelimelerim[index];

            foreach (char karakter in kelimelerim[new Random().Next(0, 5)])
            {
                flowLayoutPanel2.Controls.Add(
                    new Label()
                    {
                        Text = "_",
                        Tag = karakter.ToString(), //Tag text gibi ama kullanıcı göremiyor(arka cep)
                        Width = 30,
                        Height = 30
                    }
                    );
            }

        }

        private void AlfabeyiOlustur()
        {
            //ascii a dan z ye 65-90 aralığındadır.
            for (int i = 65; i < 65 + 26; i++)
            {
                Button btn = new Button();
                btn.Text = (Convert.ToChar(i)).ToString();
                btn.Width = btn.Height = 30;
                btn.BackColor = Color.Yellow;
                btn.Click += Btn_Click1; //+= tab tab yapınca otomatik btn_click1 methodu açılıyor.
                flowLayoutPanel1.Controls.Add(btn);
            }
        }
        int hak = 0;
        private void Btn_Click1(object sender, EventArgs e) //sender olayın meydana geldiği nesne. Event meydana gelen olay(örn: buton,click)
        {
            //Basılan butonu tıklanan buton olarak işaretliyor ve textini arananharfe eşitliyor. 
            Button tiklananbuton = sender as Button;
            string arananharf = tiklananbuton.Text;
            tiklananbuton.Enabled = false;
            bool varmi = false;

            foreach (Label lbl in flowLayoutPanel2.Controls)
            {
                if (lbl.Tag.ToString() == arananharf)
                {
                    lbl.Text = arananharf;
                    lbl.BackColor = Color.BlueViolet;
                    varmi = true;
                }
            }
            if (varmi != true)
            {
                ++hak;
                foreach (Button btn in flowLayoutPanel3.Controls)
                {
                    if (btn.Visible == false)
                    {
                        btn.Visible = true;
                        break;
                    }
                }

                if (hak == 6)
                {
                    MessageBox.Show("Oyunu Kaybettiniz.");
                }
            }
            kontrol = false;
            foreach (Label lbl in flowLayoutPanel2.Controls)
            {
                if (lbl.Text == "_")
                {
                    kontrol = true;
                }
            }
            if (kontrol==false)
            {
                MessageBox.Show("TEBRİKLER OYUNU KAZANDINIZ :)");
            }
            
        }
        bool kontrol = false;
        string[] kelimelerim = { "MASA", "SANDALYE", "BARDAK", "KALEM", "AYNA" };

        private void Form3_Load(object sender, EventArgs e)
        {
            //kelime Dizisini oluştur.
            /* kelimelerim[0] = "MASA";
             kelimelerim[1] = "AYNA";
             kelimelerim[2] = "SANDALYE";
             kelimelerim[3] = "BARDAK";
             kelimelerim[4] = "KALEM";*/
        }


    }

}
