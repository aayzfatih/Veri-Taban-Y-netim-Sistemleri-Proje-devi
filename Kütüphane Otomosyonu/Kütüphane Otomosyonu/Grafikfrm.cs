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
    public partial class Grafikfrm : Form
    {
        public Grafikfrm()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-5N31265\\SQLEXPRESS;Initial Catalog=KütüphaneOtomosyonu;Integrated Security=True");
        
        private void Grafikfrm_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select adsoyad,okukitapsayisi from uye", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                chart1.Series["Okunan Kitap Sayisi"].Points.AddXY(read["adsoyad"].ToString(),read["okukitapsayisi"]);

            }
            baglanti.Close();
            chart1.Series["Okunan Kitap Sayisi"].Color = Color.Red;

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
