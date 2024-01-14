using System;
using System.Data;
using System.Data.SqlClient;


namespace kutuphaneOtomasyonu
{
    public partial class Form4 : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-V4CSVMT;Initial Catalog=KütüphaneOtomasyonu;Integrated Security=True");
        string sqlSorgum = "SELECT * FROM tblTakip";
        public Form4()
        {
            InitializeComponent();
        }

        private void listele(string sqlSorgu, DataGridView dgv)
        {
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(sqlSorgu, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            dgv.DataSource = dt;
        }    
        public void kitapMusaitDegil(string kitapID)
        {
            string sql = "UPDATE tblKitaplar SET Uygunluk='0' WHERE ID='" + kitapID + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            listele(sqlSorgum, dgvTarih);
        }

        private void btnKytEkle_Click(object sender, EventArgs e)
        {
            conn.Open();
            string sqll = "select * from TblUyeler where ID='"+txtUyeId.Text+"'";
            SqlCommand kmt = new SqlCommand(sqll, conn);
            SqlDataReader dr = kmt.ExecuteReader();
            if (dr.Read())
            {
                sqll = dr[4].ToString();
            }
            int cezapuani = Int32.Parse(sqll);
            dr.Close();
            string sql2 = "select * from TblKitaplar";
            SqlCommand kmt2 = new SqlCommand(sql2, conn);
            SqlDataReader dr2 = kmt2.ExecuteReader();
            if (dr2.Read())
            {
                sql2 = dr2[5].ToString();
            }
            int uygunluk = Int32.Parse(sql2);
            dr2.Close();
            conn.Close();
            if (cezapuani < 50)
            {
                if (uygunluk == 1)
                {
                    kitapMusaitDegil(txtKitapId.Text);
                    string kitapEkleSorgu = "INSERT INTO tblTakip(uyeID,kitapID,alimTarihi,teslimTarihi) values(@uyeID,@kitapID,@alimTarihi,@teslimTarihi)";
                    SqlCommand ekleme = new SqlCommand(kitapEkleSorgu, conn);
                    ekleme.Parameters.AddWithValue("@uyeID", txtUyeId.Text);
                    ekleme.Parameters.AddWithValue("@kitapID", txtKitapId.Text);
                    ekleme.Parameters.AddWithValue("@alimTarihi", dateAl.Value);
                    ekleme.Parameters.AddWithValue("@teslimTarihi", dateTeslim.Value);

                    conn.Open();
                    ekleme.ExecuteNonQuery();
                    conn.Close();
                    
                    MessageBox.Show("Takip Ekleme İşlemi Başarılı!");
                    listele(sqlSorgum, dgvTarih);
                    txtUyeId.ResetText();
                    txtKitapId.ResetText();
                    dateAl.ResetText();
                    dateTeslim.ResetText();
                }
                else
                {
                    MessageBox.Show("Kitap uygun değildir.");
                }
            }
            else
            {
                MessageBox.Show("ceza puanınız 50'ye eşit veya 50'den fazla olduğu için ödünç kitap alamazsınız!");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void btnKytSil_Click(object sender, EventArgs e)
        {
            string silSorgu = "DELETE FROM tblTakip WHERE ID = @ID";
            SqlCommand sil = new SqlCommand(silSorgu, conn);
            sil.Parameters.AddWithValue("@ID", dgvTarih.CurrentRow.Cells[0].Value);

            conn.Open();
            sil.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Silme İşlemi Başarılı!");
            listele(sqlSorgum, dgvTarih);
        }

        private void btnKytGuncelle_Click(object sender, EventArgs e)
        {
            string guncelleSorgusu = "UPDATE tblTakip SET uyeID=@uyeID, kitapID=@kitapID, alimTarihi=@alimTarihi, teslimTarihi=@teslimTarihi, geldigiTarih=@geldigiTarih WHERE ID=@ID";
            SqlCommand guncelle = new SqlCommand(guncelleSorgusu, conn);
            guncelle.Parameters.AddWithValue("@ID", dgvTarih.CurrentRow.Cells[0].Value);
            guncelle.Parameters.AddWithValue("@uyeID", dgvTarih.CurrentRow.Cells[1].Value);
            guncelle.Parameters.AddWithValue("@kitapID", dgvTarih.CurrentRow.Cells[2].Value);
            guncelle.Parameters.AddWithValue("@alimTarihi", dgvTarih.CurrentRow.Cells[3].Value);
            guncelle.Parameters.AddWithValue("@teslimTarihi", dgvTarih.CurrentRow.Cells[4].Value);
            guncelle.Parameters.AddWithValue("@geldigiTarih", dgvTarih.CurrentRow.Cells[5].Value);

            conn.Open();
            guncelle.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Seçilen Takip Bilgileri Güncellendi!");
            listele(sqlSorgum, dgvTarih);
        }

        private void btnİade_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            this.Hide();
        }
    }
}
