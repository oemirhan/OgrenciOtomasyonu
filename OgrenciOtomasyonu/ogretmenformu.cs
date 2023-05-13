using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OgrenciOtomasyonu
{
    public partial class ogretmenformu : Form
    {
        public ogretmenformu(string i, string n)
        {
            InitializeComponent();

            ogtnumara = n;
            hosglabel.Text = i;
            numlabel.Text = n;
        }

        static string baglantit = "Data Source=EMIRHAN\\SERVEREMIRHAN; Initial Catalog=OgrenciNotKayıt; Integrated Security=True";
        string ogtnumara;
        double not1, not2, not3, not4, ortalamanot;
        bool bdeger;

        public void listel()
        {
            using (SqlConnection baglanti = new SqlConnection(baglantit))
            {
                SqlCommand cmda = new SqlCommand("select * from Tbl_Ogrenci", baglanti);

                SqlDataAdapter dab = new SqlDataAdapter(cmda);
                DataTable dtb = new DataTable();
                dab.Fill(dtb);
                dataGridView1.DataSource = dtb;
                dataGridView1.AutoResizeColumns();

                SqlCommand cmd = new SqlCommand("OgrencilerID", baglanti);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView2.DataSource = dt;
                dataGridView2.AutoResizeColumns();
            }
        }

        private void ogretmenformu_Load(object sender, EventArgs e)
        {
            listel();
            dataGridView1.Width = ClientSize.Width;
            dataGridView2.Width = ClientSize.Width;
        }

        private void kaydet_Click(object sender, EventArgs e)
        {
            using (SqlConnection baglanti = new SqlConnection(baglantit))
            {
                baglanti.Open();
                SqlCommand cmdekle = new SqlCommand("insert into Tbl_Ogrenci (Numara, Ad, Soyad, Sifre) VALUES (@v1, @v2, @v3, @v4)", baglanti);

                try
                {
                    if (numt.Text != "" || adt.Text != "" || soyadt.Text != "" || sifret.Text != "")
                    {
                        cmdekle.Parameters.AddWithValue("@v1", numt.Text);
                        cmdekle.Parameters.AddWithValue("@v2", adt.Text);
                        cmdekle.Parameters.AddWithValue("@v3", soyadt.Text);
                        cmdekle.Parameters.AddWithValue("@v4", sifret.Text);
                    //    cmdekle.Parameters.AddWithValue("@v5", double.Parse(txtfiyat.Text));
                        cmdekle.ExecuteNonQuery();
                        listel();
                        MessageBox.Show("Ekleme başarıyla tamamlandı.", "Eklendi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Lütfen boş bırakmayın!", "Boş Bırakmayın", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch
                {

                }
                baglanti.Close();

                numt.Clear();
                adt.Clear();
                soyadt.Clear();
                sifret.Clear();
                sinav1.Clear();
                sinav2.Clear();
                sinav3.Clear();
                proje.Clear();
            }
        }

        private void cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void listele_Click(object sender, EventArgs e)
        {
            listel();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                idt.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                adt.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                soyadt.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                sinav1.Clear();
                sinav2.Clear();
                sinav3.Clear();
                proje.Clear();
                numt.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                sifret.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                idt.Text = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
                adt.Text = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
                soyadt.Text = dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString();
                sinav1.Text = dataGridView2.Rows[e.RowIndex].Cells[3].Value.ToString();
                sinav2.Text = dataGridView2.Rows[e.RowIndex].Cells[4].Value.ToString();
                sinav3.Text = dataGridView2.Rows[e.RowIndex].Cells[5].Value.ToString();
                proje.Text = dataGridView2.Rows[e.RowIndex].Cells[6].Value.ToString();
                numt.Clear();
                sifret.Clear();
            }
        }

        private void sil_Click(object sender, EventArgs e)
        {
            using (SqlConnection baglanti = new SqlConnection(baglantit))
            {
                if (idt.Text == "")
                {
                    MessageBox.Show("Lütfen bir satır seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    baglanti.Open();

                    SqlCommand cmdsila = new SqlCommand("delete from Tbl_Notlar where ORGID=@d1", baglanti);

                    cmdsila.Parameters.AddWithValue("@d1", idt.Text);
                    cmdsila.ExecuteNonQuery();

                    SqlCommand cmdsil = new SqlCommand("delete from Tbl_Ogrenci where ID=@d1", baglanti);

                    cmdsil.Parameters.AddWithValue("@d1", idt.Text);
                    cmdsil.ExecuteNonQuery();

                    MessageBox.Show("Silinme başarıyla tamamlandı.", "Silindi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listel();
                }
            } 
        }

        private void guncelle_Click(object sender, EventArgs e)
        {
            using (SqlConnection baglanti = new SqlConnection(baglantit))
            {
                if (adt.Text == "")
                {
                    MessageBox.Show("Lütfen bir satır seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    baglanti.Open();
                    if (ortalama.Text == "" || ortalama.Text == null)
                    {
                        SqlCommand cmdduzenle = new SqlCommand("update Tbl_Notlar set Sinav1=@u1, Sinav2=@u2, Sinav3=@u3, Proje=@u4 where ORGID=@u8", baglanti);

                        cmdduzenle.Parameters.AddWithValue("@u1", sinav1.Text);
                        cmdduzenle.Parameters.AddWithValue("@u2", sinav2.Text);
                        cmdduzenle.Parameters.AddWithValue("@u3", sinav3.Text);
                        cmdduzenle.Parameters.AddWithValue("@u4", proje.Text);
                        cmdduzenle.Parameters.AddWithValue("@u8", idt.Text);
                        cmdduzenle.ExecuteNonQuery();
                    }
                    else
                    {
                        SqlCommand cmdduzenle = new SqlCommand("update Tbl_Notlar set Sinav1=@u1, Sinav2=@u2, Sinav3=@u3, Proje=@u4, Ortalama=@u5, Durum=@u6 where ORGID=@u8", baglanti);

                        cmdduzenle.Parameters.AddWithValue("@u1", sinav1.Text);
                        cmdduzenle.Parameters.AddWithValue("@u2", sinav2.Text);
                        cmdduzenle.Parameters.AddWithValue("@u3", sinav3.Text);
                        cmdduzenle.Parameters.AddWithValue("@u4", proje.Text);
                        cmdduzenle.Parameters.AddWithValue("@u5", double.Parse(ortalama.Text));
                        if (durum.Text == "Geçti")
                        {
                            bdeger = true;
                        }
                        else
                        {
                            bdeger = false;
                        }
                        cmdduzenle.Parameters.AddWithValue("@u6", bdeger);
                        cmdduzenle.Parameters.AddWithValue("@u8", idt.Text);
                        cmdduzenle.ExecuteNonQuery();
                    }

                    MessageBox.Show("Düzenleme başarıyla tamamlandı.", "Düzenleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listel();
                }
            }
        }

        private void mesajlar_Click(object sender, EventArgs e)
        {
            Hide();
            mesajlar mesajlar = new mesajlar(ogtnumara);
            mesajlar.Show();
        }

        private void duylist_Click(object sender, EventArgs e)
        {
            duyurulistele duyurulistele = new duyurulistele();
            duyurulistele.Show();
        }

        private void duyolus_Click(object sender, EventArgs e)
        {
            Hide();
            duyuruolustur duyuruolustur = new duyuruolustur();
            duyuruolustur.Show();
        }

        private void hesapla_Click(object sender, EventArgs e)
        {
            not1 = double.Parse(sinav1.Text);
            not2 = double.Parse(sinav2.Text);
            not3 = double.Parse(sinav3.Text);
            not4 = double.Parse(proje.Text);

            ortalamanot = (not1 + not2 + not3 + not4) /4;
            ortalama.Text = ortalamanot.ToString();

            if (ortalamanot >= 0 && ortalamanot < 50)
            {
                durum.Text = "Kaldı";
            }
            else if (ortalamanot >= 50 && ortalamanot <= 100)
            {
                durum.Text = "Geçti";
            }
            else
            {
                MessageBox.Show("Ortalama 0 ile 100 arasında değil","Hata",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}