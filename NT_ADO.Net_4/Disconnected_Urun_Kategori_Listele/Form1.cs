using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Disconnected_Urun_Kategori_Listele
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source = WISSEN\MSSQLSRV; Initial Catalog = Northwind; Integrated Security = True");
        DataSet ds = new DataSet();

        public Form1()
        {
            InitializeComponent();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            if (ds.Tables.Contains("Urunler"))
            {
                ds.Tables.Remove("Urunler");
            }
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Products", conn);
                DataTable dt = ds.Tables.Add("Urunler");
                da.Fill(dt);
                MessageBox.Show("Ürünler listesi eklendi.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (ds.Tables.Contains("Kategoriler"))
            {
                ds.Tables.Remove("Kategoriler");
            }
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Categories", conn);
                DataTable dt = ds.Tables.Add("Kategoriler");
                da.Fill(dt);
                MessageBox.Show("Kategoriler listesi eklendi.");
        }

        private void btnUrunGetir_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.Tables["Urunler"];
        }

        private void btnKategoriGetir_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.Tables["Kategoriler"];
        }
    }
}
