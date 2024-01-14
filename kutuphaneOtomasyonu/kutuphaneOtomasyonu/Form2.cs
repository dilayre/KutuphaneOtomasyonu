using System.Data;
using System.Data.SqlClient;
using System.Transactions;

namespace kutuphaneOtomasyonu
{
    public partial class Form2 : Form
    {

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-V4CSVMT;Initial Catalog=KütüphaneOtomasyonu;Integrated Security=True");
        string selectSorgu = "SELECT * FROM tblUyeler";
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            listele(selectSorgu, dgvUyeler);
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

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            string sorgu = "SELECT * FROM tblUyeler WHERE Ad LIKE '%" + txtAra.Text + "%'  OR  Soyad LIKE '%" + txtAra.Text + "%' OR  Meslek LIKE '%" + txtAra.Text + "%' OR  CezaPuani LIKE '%" + txtAra.Text + "%' ";
            listele(sorgu, dgvUyeler);
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            string ekleSorgusu = "INSERT INTO tblUyeler(Ad,Soyad,Meslek,CezaPuani) values(@Ad,@Soyad,@Meslek,@CezaPuani)";
            SqlCommand ekle = new SqlCommand(ekleSorgusu, conn);
            ekle.Parameters.AddWithValue("@Ad", txtAd.Text);
            ekle.Parameters.AddWithValue("@Soyad", txtSoyad.Text);
            ekle.Parameters.AddWithValue("@Meslek", txtMeslek.Text);
            ekle.Parameters.AddWithValue("@CezaPuani", txtCeza.Text);

            conn.Open();
                ekle.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Üye Ekleme İşlemi Başarılı!");
            listele(selectSorgu, dgvUyeler);
            txtAd.ResetText();
            txtSoyad.ResetText();
            txtMeslek.ResetText();
            txtCeza.ResetText();

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            string guncelleSorgusu = "UPDATE tblUyeler SET Ad=@Ad, Soyad=@Soyad, Meslek=@Meslek, CezaPuani=@CezaPuani WHERE ID=@ID";
            SqlCommand guncelle = new SqlCommand(guncelleSorgusu, conn);
            guncelle.Parameters.AddWithValue("@ID", dgvUyeler.CurrentRow.Cells[0].Value);
            guncelle.Parameters.AddWithValue("@Ad", dgvUyeler.CurrentRow.Cells[1].Value);
            guncelle.Parameters.AddWithValue("@Soyad", dgvUyeler.CurrentRow.Cells[2].Value);
            guncelle.Parameters.AddWithValue("@Meslek", dgvUyeler.CurrentRow.Cells[3].Value);
            guncelle.Parameters.AddWithValue("@CezaPuani", dgvUyeler.CurrentRow.Cells[4].Value);

            conn.Open();
            guncelle.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Seçilen Üye Bilgileri Güncellendi!");
            listele(selectSorgu, dgvUyeler);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            string silSorgu = "DELETE FROM tblUyeler WHERE ID = @ID";
            SqlCommand sil = new SqlCommand(silSorgu, conn);
            sil.Parameters.AddWithValue("@ID", dgvUyeler.CurrentRow.Cells[0].Value);

            conn.Open();
            sil.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Silme İşlemi Başarılı!");
            listele(selectSorgu, dgvUyeler);
        }

        private void btnDon_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void dgvUyeler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
    }
}
