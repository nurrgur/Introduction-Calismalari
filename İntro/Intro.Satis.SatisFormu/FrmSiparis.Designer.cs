
namespace Intro.Satis.SatisFormu
{
    partial class FrmSiparis
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFiyat = new System.Windows.Forms.Label();
            this.btnSepeteAt = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.lstSepetim = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblStokBilgisi = new System.Windows.Forms.Label();
            this.lstUrunler = new System.Windows.Forms.ListBox();
            this.cmbAltKategori = new System.Windows.Forms.ComboBox();
            this.cmbAnaKategori = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblVergi = new System.Windows.Forms.Label();
            this.btnGec = new System.Windows.Forms.Button();
            this.btnSiparisiTamamla = new System.Windows.Forms.Button();
            this.mskdVergiNo = new System.Windows.Forms.MaskedTextBox();
            this.lblTc = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mskdTC = new System.Windows.Forms.MaskedTextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.txtMusteri = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblFiyat);
            this.groupBox1.Controls.Add(this.btnSepeteAt);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.lstSepetim);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblStokBilgisi);
            this.groupBox1.Controls.Add(this.lstUrunler);
            this.groupBox1.Controls.Add(this.cmbAltKategori);
            this.groupBox1.Controls.Add(this.cmbAnaKategori);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(504, 551);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Siparis Bilgileri";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(6, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Alt Kategori";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(6, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Üst Kategori";
            // 
            // lblFiyat
            // 
            this.lblFiyat.AutoSize = true;
            this.lblFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFiyat.Location = new System.Drawing.Point(392, 191);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(19, 20);
            this.lblFiyat.TabIndex = 13;
            this.lblFiyat.Text = "0";
            // 
            // btnSepeteAt
            // 
            this.btnSepeteAt.Location = new System.Drawing.Point(348, 280);
            this.btnSepeteAt.Name = "btnSepeteAt";
            this.btnSepeteAt.Size = new System.Drawing.Size(120, 36);
            this.btnSepeteAt.TabIndex = 12;
            this.btnSepeteAt.Text = "Sepete At";
            this.btnSepeteAt.UseVisualStyleBackColor = true;
            this.btnSepeteAt.Click += new System.EventHandler(this.btnSepeteAt_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(396, 227);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(72, 26);
            this.numericUpDown1.TabIndex = 11;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lstSepetim
            // 
            this.lstSepetim.FormattingEnabled = true;
            this.lstSepetim.ItemHeight = 20;
            this.lstSepetim.Location = new System.Drawing.Point(126, 340);
            this.lstSepetim.Name = "lstSepetim";
            this.lstSepetim.Size = new System.Drawing.Size(342, 164);
            this.lstSepetim.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(331, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Adet:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(325, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Fiyat :";
            // 
            // lblStokBilgisi
            // 
            this.lblStokBilgisi.AutoSize = true;
            this.lblStokBilgisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStokBilgisi.Location = new System.Drawing.Point(325, 153);
            this.lblStokBilgisi.Name = "lblStokBilgisi";
            this.lblStokBilgisi.Size = new System.Drawing.Size(124, 20);
            this.lblStokBilgisi.TabIndex = 6;
            this.lblStokBilgisi.Text = "---- Stokta Var";
            // 
            // lstUrunler
            // 
            this.lstUrunler.FormattingEnabled = true;
            this.lstUrunler.ItemHeight = 20;
            this.lstUrunler.Location = new System.Drawing.Point(126, 135);
            this.lstUrunler.Name = "lstUrunler";
            this.lstUrunler.Size = new System.Drawing.Size(172, 184);
            this.lstUrunler.TabIndex = 6;
            this.lstUrunler.SelectedIndexChanged += new System.EventHandler(this.lstUrunler_SelectedIndexChanged);
            // 
            // cmbAltKategori
            // 
            this.cmbAltKategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAltKategori.FormattingEnabled = true;
            this.cmbAltKategori.Location = new System.Drawing.Point(126, 95);
            this.cmbAltKategori.Name = "cmbAltKategori";
            this.cmbAltKategori.Size = new System.Drawing.Size(172, 28);
            this.cmbAltKategori.TabIndex = 7;
            this.cmbAltKategori.SelectedIndexChanged += new System.EventHandler(this.cmbAltKategori_SelectedIndexChanged);
            // 
            // cmbAnaKategori
            // 
            this.cmbAnaKategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAnaKategori.FormattingEnabled = true;
            this.cmbAnaKategori.Location = new System.Drawing.Point(126, 49);
            this.cmbAnaKategori.Name = "cmbAnaKategori";
            this.cmbAnaKategori.Size = new System.Drawing.Size(172, 28);
            this.cmbAnaKategori.TabIndex = 6;
            this.cmbAnaKategori.SelectedIndexChanged += new System.EventHandler(this.cmbAnaKategori_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblVergi);
            this.groupBox2.Controls.Add(this.btnGec);
            this.groupBox2.Controls.Add(this.btnSiparisiTamamla);
            this.groupBox2.Controls.Add(this.mskdVergiNo);
            this.groupBox2.Controls.Add(this.lblTc);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.mskdTC);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Controls.Add(this.txtMusteri);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.Location = new System.Drawing.Point(504, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(457, 551);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Müşteri Bilgileri";
            // 
            // lblVergi
            // 
            this.lblVergi.AutoSize = true;
            this.lblVergi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblVergi.Location = new System.Drawing.Point(91, 226);
            this.lblVergi.Name = "lblVergi";
            this.lblVergi.Size = new System.Drawing.Size(78, 20);
            this.lblVergi.TabIndex = 15;
            this.lblVergi.Text = "Vergi No";
            this.lblVergi.Visible = false;
            // 
            // btnGec
            // 
            this.btnGec.Location = new System.Drawing.Point(351, 462);
            this.btnGec.Name = "btnGec";
            this.btnGec.Size = new System.Drawing.Size(87, 42);
            this.btnGec.TabIndex = 14;
            this.btnGec.Text = ">>>";
            this.btnGec.UseVisualStyleBackColor = true;
            this.btnGec.Click += new System.EventHandler(this.btnGec_Click);
            // 
            // btnSiparisiTamamla
            // 
            this.btnSiparisiTamamla.Location = new System.Drawing.Point(171, 296);
            this.btnSiparisiTamamla.Name = "btnSiparisiTamamla";
            this.btnSiparisiTamamla.Size = new System.Drawing.Size(170, 55);
            this.btnSiparisiTamamla.TabIndex = 13;
            this.btnSiparisiTamamla.Text = "Siparişi Tamamla";
            this.btnSiparisiTamamla.UseVisualStyleBackColor = true;
            this.btnSiparisiTamamla.Click += new System.EventHandler(this.btnSiparisiTamamla_Click);
            // 
            // mskdVergiNo
            // 
            this.mskdVergiNo.Location = new System.Drawing.Point(190, 223);
            this.mskdVergiNo.Mask = "0000000000";
            this.mskdVergiNo.Name = "mskdVergiNo";
            this.mskdVergiNo.Size = new System.Drawing.Size(134, 26);
            this.mskdVergiNo.TabIndex = 5;
            this.mskdVergiNo.ValidatingType = typeof(int);
            this.mskdVergiNo.Visible = false;
            // 
            // lblTc
            // 
            this.lblTc.AutoSize = true;
            this.lblTc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTc.Location = new System.Drawing.Point(132, 167);
            this.lblTc.Name = "lblTc";
            this.lblTc.Size = new System.Drawing.Size(31, 20);
            this.lblTc.TabIndex = 4;
            this.lblTc.Text = "TC";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(100, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Müşteri";
            // 
            // mskdTC
            // 
            this.mskdTC.Location = new System.Drawing.Point(190, 164);
            this.mskdTC.Mask = "00000000000";
            this.mskdTC.Name = "mskdTC";
            this.mskdTC.Size = new System.Drawing.Size(134, 26);
            this.mskdTC.TabIndex = 2;
            this.mskdTC.ValidatingType = typeof(int);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(220, 131);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(104, 24);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Şahıs Mı?";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // txtMusteri
            // 
            this.txtMusteri.Location = new System.Drawing.Point(190, 95);
            this.txtMusteri.Name = "txtMusteri";
            this.txtMusteri.Size = new System.Drawing.Size(134, 26);
            this.txtMusteri.TabIndex = 0;
            // 
            // FrmSiparis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(970, 551);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmSiparis";
            this.Text = "FrmSiparis";
            this.Load += new System.EventHandler(this.FrmSiparis_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSepeteAt;
        private System.Windows.Forms.ListBox lstSepetim;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblStokBilgisi;
        private System.Windows.Forms.ListBox lstUrunler;
        private System.Windows.Forms.ComboBox cmbAltKategori;
        private System.Windows.Forms.ComboBox cmbAnaKategori;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnGec;
        private System.Windows.Forms.Button btnSiparisiTamamla;
        private System.Windows.Forms.MaskedTextBox mskdVergiNo;
        private System.Windows.Forms.Label lblTc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mskdTC;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox txtMusteri;
        private System.Windows.Forms.Label lblFiyat;
        private System.Windows.Forms.Label lblVergi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}