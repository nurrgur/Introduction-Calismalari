
namespace Intro.WindUygulama
{
    partial class FrmKisiKaydetme
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnKisiKaydet = new System.Windows.Forms.Button();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.cmbhobi = new System.Windows.Forms.ComboBox();
            this.rdpkadin = new System.Windows.Forms.RadioButton();
            this.lstKisilerim = new System.Windows.Forms.ListBox();
            this.lblTc = new System.Windows.Forms.Label();
            this.rdpErkek = new System.Windows.Forms.RadioButton();
            this.btnHobiEkle = new System.Windows.Forms.Button();
            this.msTCkimlik = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.lstHobiler = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnKisiKaydet
            // 
            this.btnKisiKaydet.Location = new System.Drawing.Point(50, 254);
            this.btnKisiKaydet.Name = "btnKisiKaydet";
            this.btnKisiKaydet.Size = new System.Drawing.Size(323, 48);
            this.btnKisiKaydet.TabIndex = 0;
            this.btnKisiKaydet.Text = "Ekle";
            this.btnKisiKaydet.UseVisualStyleBackColor = true;
            this.btnKisiKaydet.Click += new System.EventHandler(this.btnKisiKaydet_Click);
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(102, 54);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(159, 26);
            this.txtAdSoyad.TabIndex = 1;
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Location = new System.Drawing.Point(7, 54);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(74, 20);
            this.lblAdSoyad.TabIndex = 2;
            this.lblAdSoyad.Text = "AdSoyad";
            // 
            // cmbhobi
            // 
            this.cmbhobi.FormattingEnabled = true;
            this.cmbhobi.Location = new System.Drawing.Point(102, 214);
            this.cmbhobi.Name = "cmbhobi";
            this.cmbhobi.Size = new System.Drawing.Size(159, 28);
            this.cmbhobi.TabIndex = 3;
            // 
            // rdpkadin
            // 
            this.rdpkadin.AutoSize = true;
            this.rdpkadin.Checked = true;
            this.rdpkadin.Location = new System.Drawing.Point(102, 162);
            this.rdpkadin.Name = "rdpkadin";
            this.rdpkadin.Size = new System.Drawing.Size(74, 24);
            this.rdpkadin.TabIndex = 4;
            this.rdpkadin.TabStop = true;
            this.rdpkadin.Text = "Kadın";
            this.rdpkadin.UseVisualStyleBackColor = true;
            // 
            // lstKisilerim
            // 
            this.lstKisilerim.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lstKisilerim.FormattingEnabled = true;
            this.lstKisilerim.ItemHeight = 20;
            this.lstKisilerim.Location = new System.Drawing.Point(0, 366);
            this.lstKisilerim.Name = "lstKisilerim";
            this.lstKisilerim.Size = new System.Drawing.Size(840, 84);
            this.lstKisilerim.TabIndex = 5;
            this.lstKisilerim.SelectedIndexChanged += new System.EventHandler(this.lstKisilerim_SelectedIndexChanged);
            // 
            // lblTc
            // 
            this.lblTc.AutoSize = true;
            this.lblTc.Location = new System.Drawing.Point(7, 108);
            this.lblTc.Name = "lblTc";
            this.lblTc.Size = new System.Drawing.Size(26, 20);
            this.lblTc.TabIndex = 6;
            this.lblTc.Text = "Tc";
            // 
            // rdpErkek
            // 
            this.rdpErkek.AutoSize = true;
            this.rdpErkek.Location = new System.Drawing.Point(186, 162);
            this.rdpErkek.Name = "rdpErkek";
            this.rdpErkek.Size = new System.Drawing.Size(75, 24);
            this.rdpErkek.TabIndex = 7;
            this.rdpErkek.Text = "Erkek";
            this.rdpErkek.UseVisualStyleBackColor = true;
            // 
            // btnHobiEkle
            // 
            this.btnHobiEkle.Location = new System.Drawing.Point(281, 206);
            this.btnHobiEkle.Name = "btnHobiEkle";
            this.btnHobiEkle.Size = new System.Drawing.Size(92, 42);
            this.btnHobiEkle.TabIndex = 8;
            this.btnHobiEkle.Text = "+";
            this.btnHobiEkle.UseVisualStyleBackColor = true;
            this.btnHobiEkle.Click += new System.EventHandler(this.btnHobiEkle_Click);
            // 
            // msTCkimlik
            // 
            this.msTCkimlik.Location = new System.Drawing.Point(102, 108);
            this.msTCkimlik.Mask = "00000000000";
            this.msTCkimlik.Name = "msTCkimlik";
            this.msTCkimlik.Size = new System.Drawing.Size(159, 26);
            this.msTCkimlik.TabIndex = 9;
            this.msTCkimlik.ValidatingType = typeof(int);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(406, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 170);
            this.label1.TabIndex = 10;
            this.label1.Text = "Seçilen Kişi Yok";
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.LightCoral;
            this.btnSil.Location = new System.Drawing.Point(719, 280);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(98, 41);
            this.btnSil.TabIndex = 11;
            this.btnSil.Text = "Hobi Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // lstHobiler
            // 
            this.lstHobiler.FormattingEnabled = true;
            this.lstHobiler.ItemHeight = 20;
            this.lstHobiler.Location = new System.Drawing.Point(632, 101);
            this.lstHobiler.Name = "lstHobiler";
            this.lstHobiler.Size = new System.Drawing.Size(185, 164);
            this.lstHobiler.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(405, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Secilen Kisi";
            // 
            // FrmKisiKaydetme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstHobiler);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.msTCkimlik);
            this.Controls.Add(this.btnHobiEkle);
            this.Controls.Add(this.rdpErkek);
            this.Controls.Add(this.lblTc);
            this.Controls.Add(this.lstKisilerim);
            this.Controls.Add(this.rdpkadin);
            this.Controls.Add(this.cmbhobi);
            this.Controls.Add(this.lblAdSoyad);
            this.Controls.Add(this.txtAdSoyad);
            this.Controls.Add(this.btnKisiKaydet);
            this.Name = "FrmKisiKaydetme";
            this.Text = "FrmKisiKaydetme";
            this.Load += new System.EventHandler(this.FrmKisiKaydetme_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKisiKaydet;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.ComboBox cmbhobi;
        private System.Windows.Forms.RadioButton rdpkadin;
        private System.Windows.Forms.ListBox lstKisilerim;
        private System.Windows.Forms.Label lblTc;
        private System.Windows.Forms.RadioButton rdpErkek;
        private System.Windows.Forms.Button btnHobiEkle;
        private System.Windows.Forms.MaskedTextBox msTCkimlik;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.ListBox lstHobiler;
        private System.Windows.Forms.Label label2;
    }
}