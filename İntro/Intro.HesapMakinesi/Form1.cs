using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Intro.HesapMakinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        //Islem islm = new Islem();
        double sayi1 = 0;
        double sayi2 = 0;
        string secim;
        Islem i1 = new Islem();
        private void btn1_Click(object sender, EventArgs e)
        {
            textBox1.Text += btn1.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            textBox1.Text += btn2.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            textBox1.Text += btn3.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            textBox1.Text += btn4.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            textBox1.Text += btn5.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            textBox1.Text += btn6.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            textBox1.Text += btn7.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            textBox1.Text += btn8.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            textBox1.Text += btn9.Text;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            textBox1.Text += btn0.Text;
        }

        private void btnTopla_Click(object sender, EventArgs e)
        {
            lblIslem.Text = "";
            sayi1 = double.Parse(textBox1.Text);
            lblIslem.Text = lblIslem.Text + textBox1.Text + btnTopla.Text;
            secim = "+";
            textBox1.Text = "";

        }

        private void btnBol_Click(object sender, EventArgs e)
        {
            lblIslem.Text = "";
            sayi1 = double.Parse(textBox1.Text);
            lblIslem.Text = lblIslem.Text + textBox1.Text + btnBol.Text;
            secim = "/";
            textBox1.Text = "";
        }

        private void btnCikarma_Click(object sender, EventArgs e)
        {
            lblIslem.Text = "";
            sayi1 = double.Parse(textBox1.Text);
            lblIslem.Text = lblIslem.Text + textBox1.Text + btnCikarma.Text;
            secim = "-";
            textBox1.Text = "";
        }

        private void btnCarp_Click(object sender, EventArgs e)
        {
            lblIslem.Text = "";
            sayi1 = double.Parse(textBox1.Text);
            lblIslem.Text = lblIslem.Text + textBox1.Text + btnCarp.Text;
            secim = "*";
            textBox1.Text = "";
        }

        private void btnKaresi_Click(object sender, EventArgs e)
        {
            lblIslem.Text = "";
            sayi1 = double.Parse(textBox1.Text);
            lblIslem.Text = lblIslem.Text + textBox1.Text + "^2";
            //secim = "karesi";
            textBox1.Text = (i1.KareAlma(sayi1)).ToString();
        }

        private void btnKüpü_Click(object sender, EventArgs e)
        {
            lblIslem.Text = "";
            sayi1 = double.Parse(textBox1.Text);
            lblIslem.Text = lblIslem.Text + textBox1.Text + "^3";
            //secim = "kupu";
            textBox1.Text = (i1.KupAlma(sayi1)).ToString();
        }

        private void btnKuvvet_Click(object sender, EventArgs e)
        {
            lblIslem.Text = "";
            sayi1 = double.Parse(textBox1.Text);
            lblIslem.Text = "2^" + textBox1.Text;
            textBox1.Text = (i1.KuvvetAlma(sayi1)).ToString();
        }

        private void btnEsittir_Click(object sender, EventArgs e)
        {
            sayi2 = double.Parse(textBox1.Text);
            lblIslem.Text = lblIslem.Text + textBox1.Text + btnEsittir.Text;
            switch (secim)
            {
                case "+":
                    textBox1.Text = i1.Toplama(sayi1, sayi2).ToString();
                    break;
                case "-":
                    textBox1.Text = i1.Cikarma(sayi1, sayi2).ToString();
                    break;
                case "/":
                    textBox1.Text = i1.Bolme(sayi1, sayi2).ToString();
                    break;
                case "*":
                    textBox1.Text = i1.Carpma(sayi1, sayi2).ToString();
                    break;
                default: break;
            }

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int uzunluk = textBox1.Text.Length;
            string ytext = null;
            for (int i = 0; i < uzunluk - 1; i++)
            {
                ytext += textBox1.Text[i].ToString();
            }
            textBox1.Text = ytext;
        }

        private void btnVirgül_Click(object sender, EventArgs e)
        {
            textBox1.Text += btnVirgül.Text;
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            lblIslem.Text = "";
        }

    }
}

