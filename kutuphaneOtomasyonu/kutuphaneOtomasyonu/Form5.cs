using System;
using System.Data;
using System.Data.SqlClient;

namespace kutuphaneOtomasyonu
{
    public partial class Form5 : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-V4CSVMT;Initial Catalog=KütüphaneOtomasyonu;Integrated Security=True");
        string sqlSorgum = "SELECT * FROM tblTakip";
        public Form5()
        {
            InitializeComponent();
            this.Load += Form5_Load;
        }
        public void kitapMusait(string kitapID)
        {
            string sql = "UPDATE tblKitaplar SET Uygunluk='1' WHERE ID='" + kitapID + "'";

            SqlCommand cmd = new SqlCommand(sql, conn);

            conn.Open();

            cmd.ExecuteNonQuery();

            conn.Close();

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
        public void cezaPuaniVer(string uyeID)
        {
            string sql = "UPDATE tblUyeler SET CezaPuani=CezaPuani+10 WHERE UyeID='" + uyeID + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                string sql2 = "select * from tblKitaplar where ID='"+textBox2.Text+"'";
                 SqlCommand kmt2 = new SqlCommand(sql2, conn);
               conn.Open();
                 SqlDataReader dr2 = kmt2.ExecuteReader();
                
                 if (dr2.Read())
                {
                   sql2 = dr2[5].ToString();
                }
                int uygunluk = Int32.Parse(sql2);
                 conn.Close();
              if (uygunluk == 0)
            {
                kitapMusait(textBox2.Text);
                DateTime geldigitarih = DateTime.Now;
                string format = "yyyy-MM-dd HH:mm:ss";
                string sql = "Update tblTakip SET GeldigiTarih='" + geldigitarih.ToString(format) + "'WHERE UyeID='" + textBox1.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                cmd.ExecuteNonQuery();


                string sqll = "Select * from tblTakip";
                SqlCommand kmt = new SqlCommand(sqll, conn);
                SqlDataReader dr = kmt.ExecuteReader();
                if (dr.Read())
                {
                    sqll = dr[4].ToString();
                }
                DateTime teslimtarihi = DateTime.Parse(sqll);

                if (geldigitarih > teslimtarihi)
                {
                    cezaPuaniVer(textBox1.Text);
                }
                conn.Close();
                MessageBox.Show("Kitabınız iade edilmiştir");
            }
            else
            {
                MessageBox.Show("kitap kütüphanede mevcut");
            }
        }
        private void Form5_Load(object? sender, EventArgs e)
        {
            listele(sqlSorgum,dgvİade);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }
    }
}
