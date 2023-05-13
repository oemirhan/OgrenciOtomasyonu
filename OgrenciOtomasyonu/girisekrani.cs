using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OgrenciOtomasyonu
{
    public partial class girisekrani : Form
    {
        public girisekrani()
        {
            InitializeComponent();
        }

        static string baglantit = "Data Source=EMIRHAN\\SERVEREMIRHAN; Initial Catalog=OgrenciNotKayıt; Integrated Security=True";
        string ogrtisim, ogrtnumara, ogrnisim, ogrnnumara;

        private void ogrtbuton_Click(object sender, EventArgs e)
        {
            using (SqlConnection baglanti = new SqlConnection(baglantit))
            {
                baglanti.Open();

                string query = "select * from Tbl_Ogretmenler where Numara=@kullaniciadi and Sifre=@sifre";
                SqlCommand cmd = new SqlCommand(query, baglanti);
                cmd.Parameters.AddWithValue("@kullaniciadi", ogrtkadi.Text);
                cmd.Parameters.AddWithValue("@sifre", ogrtsif.Text);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ogrtisim = reader.GetString(1);
                        ogrtnumara = reader.GetString(3);
                    }

                    Hide();
                    ogretmenformu ogretmenformu = new ogretmenformu(ogrtisim, ogrtnumara);
                    ogretmenformu.Show();
                }
                else
                {
                    MessageBox.Show("Numara veya şifre hatalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ogrnbuton_Click(object sender, EventArgs e)
        {
            using (SqlConnection baglanti = new SqlConnection(baglantit))
            {
                baglanti.Open();

                string query = "select * from Tbl_Ogrenci where Numara=@kullaniciadi and Sifre=@sifre";
                SqlCommand cmd = new SqlCommand(query, baglanti);
                cmd.Parameters.AddWithValue("@kullaniciadi", ogrnkadi.Text);
                cmd.Parameters.AddWithValue("@sifre", ogrnsif.Text);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ogrnisim = reader.GetString(1);
                        ogrnnumara = reader.GetString(3);
                    }

                    Hide();
                    ogrenciformu ogrenciformu1 = new ogrenciformu(ogrnisim, ogrnnumara);
                    ogrenciformu1.Show();
                }
                else
                {
                    MessageBox.Show("Numara veya şifre hatalı!", "Hata",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    } 
}