namespace kutuphaneOtomasyonu
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.lblKitapAdi = new System.Windows.Forms.Label();
            this.lblYazar = new System.Windows.Forms.Label();
            this.lblTur = new System.Windows.Forms.Label();
            this.lblSayfa = new System.Windows.Forms.Label();
            this.txtKitap = new System.Windows.Forms.TextBox();
            this.txtYazar = new System.Windows.Forms.TextBox();
            this.txtSayfa = new System.Windows.Forms.TextBox();
            this.btnKitap = new System.Windows.Forms.Button();
            this.btnKtpSil = new System.Windows.Forms.Button();
            this.btnGuncelKtp = new System.Windows.Forms.Button();
            this.dgvKitaplar = new System.Windows.Forms.DataGridView();
            this.txtKitapAra = new System.Windows.Forms.TextBox();
            this.lblKitapAra = new System.Windows.Forms.Label();
            this.lblUygun = new System.Windows.Forms.Label();
            this.cmbUygun = new System.Windows.Forms.ComboBox();
            this.comboText = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKitaplar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblKitapAdi
            // 
            this.lblKitapAdi.AutoSize = true;
            this.lblKitapAdi.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblKitapAdi.Location = new System.Drawing.Point(62, 109);
            this.lblKitapAdi.Name = "lblKitapAdi";
            this.lblKitapAdi.Size = new System.Drawing.Size(97, 25);
            this.lblKitapAdi.TabIndex = 0;
            this.lblKitapAdi.Text = "Kitap Adı :";
            // 
            // lblYazar
            // 
            this.lblYazar.AutoSize = true;
            this.lblYazar.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblYazar.Location = new System.Drawing.Point(92, 176);
            this.lblYazar.Name = "lblYazar";
            this.lblYazar.Size = new System.Drawing.Size(67, 25);
            this.lblYazar.TabIndex = 1;
            this.lblYazar.Text = "Yazarı :";
            // 
            // lblTur
            // 
            this.lblTur.AutoSize = true;
            this.lblTur.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTur.Location = new System.Drawing.Point(100, 247);
            this.lblTur.Name = "lblTur";
            this.lblTur.Size = new System.Drawing.Size(59, 25);
            this.lblTur.TabIndex = 2;
            this.lblTur.Text = "Türü :";
            // 
            // lblSayfa
            // 
            this.lblSayfa.AutoSize = true;
            this.lblSayfa.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSayfa.Location = new System.Drawing.Point(44, 311);
            this.lblSayfa.Name = "lblSayfa";
            this.lblSayfa.Size = new System.Drawing.Size(115, 25);
            this.lblSayfa.TabIndex = 3;
            this.lblSayfa.Text = "Sayfa Sayısı :";
            // 
            // txtKitap
            // 
            this.txtKitap.Location = new System.Drawing.Point(184, 107);
            this.txtKitap.Name = "txtKitap";
            this.txtKitap.Size = new System.Drawing.Size(125, 27);
            this.txtKitap.TabIndex = 4;
            // 
            // txtYazar
            // 
            this.txtYazar.Location = new System.Drawing.Point(184, 176);
            this.txtYazar.Name = "txtYazar";
            this.txtYazar.Size = new System.Drawing.Size(125, 27);
            this.txtYazar.TabIndex = 5;
            // 
            // txtSayfa
            // 
            this.txtSayfa.Location = new System.Drawing.Point(184, 309);
            this.txtSayfa.Name = "txtSayfa";
            this.txtSayfa.Size = new System.Drawing.Size(125, 27);
            this.txtSayfa.TabIndex = 7;
            // 
            // btnKitap
            // 
            this.btnKitap.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnKitap.Location = new System.Drawing.Point(40, 438);
            this.btnKitap.Name = "btnKitap";
            this.btnKitap.Size = new System.Drawing.Size(119, 48);
            this.btnKitap.TabIndex = 8;
            this.btnKitap.Text = "Kitap Ekle";
            this.btnKitap.UseVisualStyleBackColor = true;
            this.btnKitap.Click += new System.EventHandler(this.btnKitap_Click);
            // 
            // btnKtpSil
            // 
            this.btnKtpSil.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnKtpSil.Location = new System.Drawing.Point(164, 438);
            this.btnKtpSil.Name = "btnKtpSil";
            this.btnKtpSil.Size = new System.Drawing.Size(109, 48);
            this.btnKtpSil.TabIndex = 9;
            this.btnKtpSil.Text = "Kitap Sil";
            this.btnKtpSil.UseVisualStyleBackColor = true;
            this.btnKtpSil.Click += new System.EventHandler(this.btnKtpSil_Click);
            // 
            // btnGuncelKtp
            // 
            this.btnGuncelKtp.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGuncelKtp.Location = new System.Drawing.Point(279, 438);
            this.btnGuncelKtp.Name = "btnGuncelKtp";
            this.btnGuncelKtp.Size = new System.Drawing.Size(113, 48);
            this.btnGuncelKtp.TabIndex = 10;
            this.btnGuncelKtp.Text = "Düzenle";
            this.btnGuncelKtp.UseVisualStyleBackColor = true;
            this.btnGuncelKtp.Click += new System.EventHandler(this.btnGuncelKtp_Click);
            // 
            // dgvKitaplar
            // 
            this.dgvKitaplar.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvKitaplar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKitaplar.Location = new System.Drawing.Point(426, 95);
            this.dgvKitaplar.Name = "dgvKitaplar";
            this.dgvKitaplar.RowHeadersWidth = 51;
            this.dgvKitaplar.RowTemplate.Height = 29;
            this.dgvKitaplar.Size = new System.Drawing.Size(703, 404);
            this.dgvKitaplar.TabIndex = 11;
            // 
            // txtKitapAra
            // 
            this.txtKitapAra.Location = new System.Drawing.Point(481, 47);
            this.txtKitapAra.Name = "txtKitapAra";
            this.txtKitapAra.Size = new System.Drawing.Size(648, 27);
            this.txtKitapAra.TabIndex = 12;
            this.txtKitapAra.TextChanged += new System.EventHandler(this.txtKitapAra_TextChanged);
            // 
            // lblKitapAra
            // 
            this.lblKitapAra.AutoSize = true;
            this.lblKitapAra.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblKitapAra.Location = new System.Drawing.Point(426, 47);
            this.lblKitapAra.Name = "lblKitapAra";
            this.lblKitapAra.Size = new System.Drawing.Size(49, 25);
            this.lblKitapAra.TabIndex = 13;
            this.lblKitapAra.Text = "Ara :";
            // 
            // lblUygun
            // 
            this.lblUygun.AutoSize = true;
            this.lblUygun.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUygun.Location = new System.Drawing.Point(58, 379);
            this.lblUygun.Name = "lblUygun";
            this.lblUygun.Size = new System.Drawing.Size(101, 25);
            this.lblUygun.TabIndex = 15;
            this.lblUygun.Text = "Uygunluk :";
            // 
            // cmbUygun
            // 
            this.cmbUygun.FormattingEnabled = true;
            this.cmbUygun.Items.AddRange(new object[] {
            "uygun",
            "uygun değil"});
            this.cmbUygun.Location = new System.Drawing.Point(184, 376);
            this.cmbUygun.Name = "cmbUygun";
            this.cmbUygun.Size = new System.Drawing.Size(125, 28);
            this.cmbUygun.TabIndex = 17;
            // 
            // comboText
            // 
            this.comboText.FormattingEnabled = true;
            this.comboText.Items.AddRange(new object[] {
            "Roman",
            "Deneme",
            "Edebiyat",
            "Gençlik",
            "Felsefe",
            "Çizgi Roman"});
            this.comboText.Location = new System.Drawing.Point(184, 244);
            this.comboText.Name = "comboText";
            this.comboText.Size = new System.Drawing.Size(125, 28);
            this.comboText.TabIndex = 18;
            this.comboText.SelectedIndexChanged += new System.EventHandler(this.comboText_SelectedIndexChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-2, -2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 33);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1176, 536);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.comboText);
            this.Controls.Add(this.cmbUygun);
            this.Controls.Add(this.lblUygun);
            this.Controls.Add(this.lblKitapAra);
            this.Controls.Add(this.txtKitapAra);
            this.Controls.Add(this.dgvKitaplar);
            this.Controls.Add(this.btnGuncelKtp);
            this.Controls.Add(this.btnKtpSil);
            this.Controls.Add(this.btnKitap);
            this.Controls.Add(this.txtSayfa);
            this.Controls.Add(this.txtYazar);
            this.Controls.Add(this.txtKitap);
            this.Controls.Add(this.lblSayfa);
            this.Controls.Add(this.lblTur);
            this.Controls.Add(this.lblYazar);
            this.Controls.Add(this.lblKitapAdi);
            this.Name = "Form3";
            this.Text = "Kitap İşlemleri";
            this.Load += new System.EventHandler(this.Form3_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKitaplar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblKitapAdi;
        private Label lblYazar;
        private Label lblTur;
        private Label lblSayfa;
        private TextBox txtKitap;
        private TextBox txtYazar;
        private TextBox txtSayfa;
        private Button btnKitap;
        private Button btnKtpSil;
        private Button btnGuncelKtp;
        private DataGridView dgvKitaplar;
        private TextBox txtKitapAra;
        private Label lblKitapAra;
        private Label lblUygun;
        private ComboBox cmbUygun;
        private ComboBox comboText;
        private PictureBox pictureBox2;
    }
}