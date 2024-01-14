namespace kutuphaneOtomasyonu
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.dgvTarih = new System.Windows.Forms.DataGridView();
            this.btnKytEkle = new System.Windows.Forms.Button();
            this.btnKytSil = new System.Windows.Forms.Button();
            this.btnKytGuncelle = new System.Windows.Forms.Button();
            this.dateTeslim = new System.Windows.Forms.DateTimePicker();
            this.dateAl = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKitapId = new System.Windows.Forms.TextBox();
            this.txtUyeId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnİade = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarih)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTarih
            // 
            this.dgvTarih.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvTarih.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTarih.Location = new System.Drawing.Point(482, 115);
            this.dgvTarih.Name = "dgvTarih";
            this.dgvTarih.RowHeadersWidth = 51;
            this.dgvTarih.RowTemplate.Height = 29;
            this.dgvTarih.Size = new System.Drawing.Size(661, 444);
            this.dgvTarih.TabIndex = 0;
            // 
            // btnKytEkle
            // 
            this.btnKytEkle.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnKytEkle.Location = new System.Drawing.Point(14, 487);
            this.btnKytEkle.Name = "btnKytEkle";
            this.btnKytEkle.Size = new System.Drawing.Size(143, 61);
            this.btnKytEkle.TabIndex = 1;
            this.btnKytEkle.Text = "Kayıt Ekle";
            this.btnKytEkle.UseVisualStyleBackColor = true;
            this.btnKytEkle.Click += new System.EventHandler(this.btnKytEkle_Click);
            // 
            // btnKytSil
            // 
            this.btnKytSil.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnKytSil.Location = new System.Drawing.Point(163, 487);
            this.btnKytSil.Name = "btnKytSil";
            this.btnKytSil.Size = new System.Drawing.Size(150, 61);
            this.btnKytSil.TabIndex = 2;
            this.btnKytSil.Text = "Kayıt Sil";
            this.btnKytSil.UseVisualStyleBackColor = true;
            this.btnKytSil.Click += new System.EventHandler(this.btnKytSil_Click);
            // 
            // btnKytGuncelle
            // 
            this.btnKytGuncelle.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnKytGuncelle.Location = new System.Drawing.Point(319, 487);
            this.btnKytGuncelle.Name = "btnKytGuncelle";
            this.btnKytGuncelle.Size = new System.Drawing.Size(128, 61);
            this.btnKytGuncelle.TabIndex = 3;
            this.btnKytGuncelle.Text = "Güncelle";
            this.btnKytGuncelle.UseVisualStyleBackColor = true;
            this.btnKytGuncelle.Click += new System.EventHandler(this.btnKytGuncelle_Click);
            // 
            // dateTeslim
            // 
            this.dateTeslim.Location = new System.Drawing.Point(185, 370);
            this.dateTeslim.Name = "dateTeslim";
            this.dateTeslim.Size = new System.Drawing.Size(250, 27);
            this.dateTeslim.TabIndex = 4;
            // 
            // dateAl
            // 
            this.dateAl.Location = new System.Drawing.Point(185, 315);
            this.dateAl.Name = "dateAl";
            this.dateAl.Size = new System.Drawing.Size(250, 27);
            this.dateAl.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(19, 315);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Alındığı Tarih :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(27, 372);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Teslim Tarihi :";
            // 
            // txtKitapId
            // 
            this.txtKitapId.Location = new System.Drawing.Point(185, 226);
            this.txtKitapId.Name = "txtKitapId";
            this.txtKitapId.Size = new System.Drawing.Size(250, 27);
            this.txtKitapId.TabIndex = 10;
            // 
            // txtUyeId
            // 
            this.txtUyeId.Location = new System.Drawing.Point(185, 175);
            this.txtUyeId.Name = "txtUyeId";
            this.txtUyeId.Size = new System.Drawing.Size(250, 27);
            this.txtUyeId.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(97, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Üye ID :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(87, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "Kitap ID :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // btnİade
            // 
            this.btnİade.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnİade.Location = new System.Drawing.Point(838, 30);
            this.btnİade.Name = "btnİade";
            this.btnİade.Size = new System.Drawing.Size(263, 55);
            this.btnİade.TabIndex = 15;
            this.btnİade.Text = "Kitap İade İşlemleri";
            this.btnİade.UseVisualStyleBackColor = true;
            this.btnİade.Click += new System.EventHandler(this.btnİade_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1155, 663);
            this.Controls.Add(this.btnİade);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtUyeId);
            this.Controls.Add(this.txtKitapId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateAl);
            this.Controls.Add(this.dateTeslim);
            this.Controls.Add(this.btnKytGuncelle);
            this.Controls.Add(this.btnKytSil);
            this.Controls.Add(this.btnKytEkle);
            this.Controls.Add(this.dgvTarih);
            this.Name = "Form4";
            this.Text = "Takip İşlemleri";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarih)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvTarih;
        private Button btnKytEkle;
        private Button btnKytSil;
        private Button btnKytGuncelle;
        private DateTimePicker dateTeslim;
        private DateTimePicker dateAl;
        private Label label1;
        private Label label2;
        private TextBox txtKitapId;
        private TextBox txtUyeId;
        private Label label4;
        private Label label5;
        private PictureBox pictureBox1;
        private Button btnİade;
    }
}