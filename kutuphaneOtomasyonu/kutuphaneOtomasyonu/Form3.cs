using System.Data;
using System.Data.SqlClient;


namespace kutuphaneOtomasyonu
{
    public partial class Form3 : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-V4CSVMT;Initial Catalog=KütüphaneOtomasyonu;Integrated Security=True");
        string sqlSorgum = "SELECT * FROM tblKitaplar";
        public Form3()
        {
            InitializeComponent();
        }
        private void Form3_Load(object sender, EventArgs e)
        {
           
        }

        private void listelen(string sqlSorgu, DataGridView dgv)
        {
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(sqlSorgu, conn);
            DataTable dt = new DataTable();
            da.Fill(dt); //DataAdapter, datatable'ı dolduracak. DataTable zaten verileri buraya çekmeye ve göstermeye yarar.
            conn.Close();
            dgv.DataSource = dt; //Veritabanı bağlantısı yapmayı sağlayan özelliktir.
        }

        private void btnKitap_Click(object sender, EventArgs e)
        {
            string kitapEkleSorgu = "INSERT INTO tblKitaplar(KitapAdi,Yazar,Tur,Sayfa)" + " values(@KitapAdi,@Yazar,@Tur,@Sayfa)";
            SqlCommand ekleme = new SqlCommand(kitapEkleSorgu, conn);
            ekleme.Parameters.AddWithValue ("@KitapAdi", txtKitap.Text);
            ekleme.Parameters.AddWithValue ("@Yazar", txtYazar.Text);
            ekleme.Parameters.AddWithValue ("@Tur", comboText.Text);
            ekleme.Parameters.AddWithValue ("@Sayfa", txtSayfa.Text);

            conn.Open();
            ekleme.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Kitap Ekleme İşlemi Gerçekleşmiştir!");
            listelen(sqlSorgum, dgvKitaplar);
            txtKitap.ResetText();
            txtYazar.ResetText();
            comboText.ResetText();
            txtSayfa.ResetText();
        }

        private void txtKitapAra_TextChanged(object sender, EventArgs e)
        {
            string araSorgu = "SELECT * FROM tblKitaplar WHERE KitapAdi LIKE '%" + txtKitapAra.Text + "%'  OR Yazar LIKE '%" + txtKitapAra.Text + "%' OR Tur LIKE '%" + txtKitapAra.Text + "%' OR Sayfa LIKE '%" + txtKitapAra.Text + "%' ";
            listelen(araSorgu, dgvKitaplar);
        }

        private void btnKtpSil_Click(object sender, EventArgs e)
        {
            string silSorgu = "DELETE FROM tblKitaplar WHERE ID = @ID";
            SqlCommand silmeislemi = new SqlCommand(silSorgu, conn);
            silmeislemi.Parameters.AddWithValue("@ID", dgvKitaplar.CurrentRow.Cells[0].Value);

            conn.Open();
            silmeislemi.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Silme İşlemi Başarılı!");
            listelen(sqlSorgum, dgvKitaplar);
        }

        private void btnGuncelKtp_Click(object sender, EventArgs e)
        {
            string duzenleSorgusu = "UPDATE tblKitaplar SET KitapAdi=@Ad, Yazar=@Yazar, Tur=@Tur, Sayfa=@Sayfa WHERE ID=@ID";
            SqlCommand duzenle = new SqlCommand(duzenleSorgusu, conn);
            duzenle.Parameters.AddWithValue("@ID", dgvKitaplar.CurrentRow.Cells[0].Value);
            duzenle.Parameters.AddWithValue("@Ad", dgvKitaplar.CurrentRow.Cells[1].Value);
            duzenle.Parameters.AddWithValue("@Yazar", dgvKitaplar.CurrentRow.Cells[2].Value);
            duzenle.Parameters.AddWithValue("@Tur", dgvKitaplar.CurrentRow.Cells[3].Value);
            duzenle.Parameters.AddWithValue("@Sayfa", dgvKitaplar.CurrentRow.Cells[4].Value);

            conn.Open();
            duzenle.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Seçilen Üye Bilgileri Güncellendi!");
            listelen(sqlSorgum, dgvKitaplar);
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void Form3_Load_1(object sender, EventArgs e)
        {
            listelen(sqlSorgum, dgvKitaplar);
        }

        private void txtTur_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboText_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
 
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
