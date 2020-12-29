using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kütüphane_Otomosyonu
{
    public partial class Sıralamafrm : Form
    {
        public Sıralamafrm()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-5N31265\\SQLEXPRESS;Initial Catalog=KütüphaneOtomosyonu;Integrated Security=True");
        DataSet daset = new DataSet();
        private void Sıralamafrm_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from uye  order by okukitapsayisi desc", baglanti);
            adtr.Fill(daset, "Uye");
            dataGridView1.DataSource = daset.Tables["Uye"];
            baglanti.Close();
            label2.Text = "";
            label4.Text = "";
            label2.Text = daset.Tables["uye"].Rows[0]["adsoyad"].ToString()+":";
            label2.Text += daset.Tables["uye"].Rows[0]["okukitapsayisi"].ToString();
            label4.Text = daset.Tables["uye"].Rows[dataGridView1.Rows.Count-2]["adsoyad"].ToString()+":";
            label4.Text += daset.Tables["uye"].Rows[dataGridView1.Rows.Count - 2]["okukitapsayisi"].ToString();

        }
    }
}
