using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OgrenciOtomasyonu
{
    public partial class duyuruolustur : Form
    {
        public duyuruolustur()
        {
            InitializeComponent();
        }

        static string baglantit = "Data Source=EMIRHAN\\SERVEREMIRHAN; Initial Catalog=OgrenciNotKayıt; Integrated Security=True";

        public void listel()
        {
            using (SqlConnection baglanti = new SqlConnection(baglantit))
            {
                SqlCommand cmda = new SqlCommand("select * from Tbl_Duyurular", baglanti);

                SqlDataAdapter dab = new SqlDataAdapter(cmda);
                DataTable dtb = new DataTable();
                dab.Fill(dtb);
                dataGridView1.DataSource = dtb;
                dataGridView1.AutoResizeColumns();
            }
        }

        private void ekle_Click(object sender, EventArgs e)
        {
            using (SqlConnection baglanti = new SqlConnection(baglantit))
            {
                baglanti.Open();
                SqlCommand cmdekle = new SqlCommand("insert into Tbl_Duyurular (Duyuruİcerik) VALUES (@v1)", baglanti);

                try
                {
                    if (richTextBox1.Text != "")
                    {
                        cmdekle.Parameters.AddWithValue("@v1", richTextBox1.Text);
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

                richTextBox1.Clear();
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

                    SqlCommand cmdsila = new SqlCommand("delete from Tbl_Duyurular where DuyuruID=@d1", baglanti);

                    cmdsila.Parameters.AddWithValue("@d1", idt.Text);
                    cmdsila.ExecuteNonQuery();

                    MessageBox.Show("Silinme başarıyla tamamlandı.", "Silindi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listel();
                }
            }
        }

        private void guncelle_Click(object sender, EventArgs e)
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
                    
                    SqlCommand cmdduzenle = new SqlCommand("update Tbl_Duyurular set Duyuruİcerik=@u1 where DuyuruID=@u8", baglanti);

                    cmdduzenle.Parameters.AddWithValue("@u1", richTextBox1.Text);
                    cmdduzenle.Parameters.AddWithValue("@u8", idt.Text);
                    cmdduzenle.ExecuteNonQuery();
                }
                MessageBox.Show("Düzenleme başarıyla tamamlandı.", "Düzenleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listel();
            }
        }

        private void duyuruolustur_Load(object sender, EventArgs e)
        {
            listel();
        }

        private void listele_Click(object sender, EventArgs e)
        {
            listel();
        }

        private void cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                idt.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                richTextBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
        }
    }
}
