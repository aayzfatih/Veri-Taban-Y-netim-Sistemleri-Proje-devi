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

namespace Kütüphane_Otomosyonu
{
    public partial class UyeEklefrm : Form
    {
        public UyeEklefrm()
        {
            InitializeComponent();
        }

      

        private void iptalButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-5N31265\\SQLEXPRESS;Initial Catalog=KütüphaneOtomosyonu;Integrated Security=True");
        private void ekleButton_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into uye(tc,adsoyad,yas,cinsiyet,telefon,adres,email,okukitapsayisi) values(@tc,@adsoyad,@yas,@cinsiyet,@telefon,@adres,@email,@okukitapsayisi)", baglanti);
            komut.Parameters.AddWithValue("@tc",tcTextBox.Text);
            komut.Parameters.AddWithValue("@adsoyad", adSoyadTextBox.Text);
            komut.Parameters.AddWithValue("@yas", yasTextBox.Text);
            komut.Parameters.AddWithValue("@cinsiyet", cinsiyetComboBox.Text);
            komut.Parameters.AddWithValue("@telefon", telefonTextBox.Text);
            komut.Parameters.AddWithValue("@adres", adresTextBox.Text);
            komut.Parameters.AddWithValue("@email", mailTextBox.Text);
            komut.Parameters.AddWithValue("@okukitapsayisi", okuduguKitapTextBox.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Uye Kaydi Yapildi");
            foreach (Control item in Controls)
            {
                if(item is TextBox)
                {
                    item.Text=" ";
                }
            }
            
        }

        private void UyeEklefrm_Load(object sender, EventArgs e)
        {

        }
    }
}
