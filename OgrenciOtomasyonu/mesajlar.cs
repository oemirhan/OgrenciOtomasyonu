using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OgrenciOtomasyonu
{
    public partial class mesajlar : Form
    {
        public mesajlar(string n)
        {
            InitializeComponent();
            numara = n;
        }

        static string baglantit = "Data Source=EMIRHAN\\SERVEREMIRHAN; Initial Catalog=OgrenciNotKayıt; Integrated Security=True";
        string numara;

        void gelenmesajlar()
        {
            using (SqlConnection baglanti = new SqlConnection(baglantit))
            {
                SqlCommand cmda = new SqlCommand("select * from Tbl_Mesajlar where Alici=@p1", baglanti);
                cmda.Parameters.AddWithValue("@p1", numara);

                SqlDataAdapter dab = new SqlDataAdapter(cmda);
                DataTable dtb = new DataTable();
                dab.Fill(dtb);
                dataGridView1.DataSource = dtb;
                dataGridView1.AutoResizeColumns();
            }
        }

        void gidenmesajlar()
        {
            using (SqlConnection baglanti = new SqlConnection(baglantit))
            {
                SqlCommand cmda = new SqlCommand("select * from Tbl_Mesajlar where Gonderen=@p1", baglanti);
                cmda.Parameters.AddWithValue("@p1", numara);

                SqlDataAdapter dab = new SqlDataAdapter(cmda);
                DataTable dtb = new DataTable();
                dab.Fill(dtb);
                dataGridView2.DataSource = dtb;
                dataGridView2.AutoResizeColumns();
            }
        }

        private void gönderbuton_Click(object sender, EventArgs e)
        {
            using (SqlConnection baglanti = new SqlConnection(baglantit))
            {
                SqlCommand cmda = new SqlCommand("insert into Tbl_Mesajlar (Gonderen, Alici, Baslik, İcerik) values (@p1, @p2, @p3, @p4)", baglanti);
                cmda.Parameters.AddWithValue("@p1", gonderentext.Text);
                cmda.Parameters.AddWithValue("@p2", alicitext.Text);
                cmda.Parameters.AddWithValue("@p3", konutext.Text);
                cmda.Parameters.AddWithValue("@p4", mesajtext.Text);

                SqlDataAdapter dab = new SqlDataAdapter(cmda);
                DataTable dtb = new DataTable();
                dab.Fill(dtb);
                dataGridView1.DataSource = dtb;
                dataGridView1.AutoResizeColumns();
            }

            gelenmesajlar();
            gidenmesajlar();

            alicitext.Clear();
            konutext.Clear();
            mesajtext.Clear();
        }

        private void mesajlar_Load(object sender, EventArgs e)
        {
            gonderentext.Text = numara;
            tabControl1.Width = ClientSize.Width;
            tabPage1.Width = ClientSize.Width;
            tabPage2.Width = ClientSize.Width;
            dataGridView1.Width = ClientSize.Width;
            dataGridView2.Width = ClientSize.Width;
            gelenmesajlar();
            gidenmesajlar();
        }
    }
}
