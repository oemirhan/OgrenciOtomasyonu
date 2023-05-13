using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OgrenciOtomasyonu
{
    public partial class duyurulistele : Form
    {
        public duyurulistele()
        {
            InitializeComponent();
        }

        static string baglantit = "Data Source=EMIRHAN\\SERVEREMIRHAN; Initial Catalog=OgrenciNotKayıt; Integrated Security=True";

        private void duyurulistele_Load(object sender, EventArgs e)
        {
            using (SqlConnection baglanti = new SqlConnection(baglantit))
            {
                SqlCommand cmda = new SqlCommand("select Duyuruİcerik from Tbl_Duyurular", baglanti);

                SqlDataAdapter dab = new SqlDataAdapter(cmda);
                DataTable dtb = new DataTable();
                dab.Fill(dtb);
                dataGridView1.DataSource = dtb;
                dataGridView1.AutoResizeColumns();
            }
        }
    }
}
