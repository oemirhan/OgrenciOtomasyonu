using System;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace OgrenciOtomasyonu
{
    public partial class ogrenciformu : Form
    {
        public ogrenciformu(string i, string n)
        {
            InitializeComponent();

            ognnumara = n;
            hosglabel.Text = i;
            numlabel.Text = n;
        }

        static string baglantit = "Data Source=EMIRHAN\\SERVEREMIRHAN; Initial Catalog=OgrenciNotKayıt; Integrated Security=True";
        string ognnumara, n1, n2, n3, p1, o1, dt;
        bool d1;
        Color back, fore = new Color();

        private void cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void hmakinesi_Click(object sender, EventArgs e)
        {
            Process.Start("calc.exe");
        }

        private void duyurular_Click(object sender, EventArgs e)
        {
            Hide();
            duyurulistele duyurulistele = new duyurulistele();
            duyurulistele.Show();
        }

        private void mesajlar_Click(object sender, EventArgs e)
        {
            Hide();
            mesajlar mesajlar = new mesajlar(ognnumara);
            mesajlar.Show();
        }

        private void ogrenciformu_Load(object sender, EventArgs e)
        {
            notlariyukle();
        }

        void notlariyukle()
        {
            using (SqlConnection baglanti = new SqlConnection(baglantit))
            {
                baglanti.Open();
                string query = "select Numara, Sinav1, Sinav2, Sinav3, Proje, ortalama, durum from Tbl_Notlar inner join Tbl_Ogrenci on ORGID = ID where Numara = @num";
                SqlCommand cmd = new SqlCommand(query, baglanti);
                cmd.Parameters.AddWithValue("@num", ognnumara);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        n1 = reader.GetByte(1).ToString();
                        n2 = reader.GetByte(2).ToString();
                        n3 = reader.GetByte(3).ToString();
                        p1 = reader.GetByte(4).ToString();
                        o1 = reader.GetDecimal(5).ToString();
                        d1 = reader.GetBoolean(6);
                    }

                    if (o1 == "0,00")
                    {
                        n1 = "-";
                        n2 = "-";
                        n3 = "-";
                        p1 = "-";
                        o1 = "-";
                        dt = "Notlar açıklanmadı.";
                        fore = Color.Black;
                        back = Color.Transparent;
                    }
                    else
                    {
                        if (d1 == true)
                        {
                            dt = "Geçti";
                            fore = Color.Black;
                            back = Color.Green;
                        }
                        else if (d1 == false)
                        {
                            dt = "Kaldı";
                            fore = Color.White;
                            back = Color.Red;
                        }
                    }

                    sinavl1.Text = n1;
                    sinavl2.Text = n2;
                    sinavl3.Text = n3;
                    projel.Text = p1;
                    ortalalabel.Text = o1;
                    duruml.Text = dt;
                    duruml.ForeColor = fore;
                    duruml.BackColor = back;
                }
                else
                {
                    MessageBox.Show("Bir hata oluştu!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
            }
        }
    }
}