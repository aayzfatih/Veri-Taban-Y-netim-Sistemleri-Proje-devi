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
    public partial class kitapeklefrm : Form
    {
        public kitapeklefrm()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-5N31265\\SQLEXPRESS;Initial Catalog=KütüphaneOtomosyonu;Integrated Security=True");
        private void kitapeklefrm_Load(object sender, EventArgs e)
        {

        }

        private void iptalButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ekleButton_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into kitap(barkodno,kitapAdi,yazari,yayınevi,sayfasayisi,turu,stoksayisi,rafno,aciklama,kayıttarihi) values(@barkodno,@kitapAdi,@yazari,@yayınevi,@sayfasayisi,@turu,@stoksayisi,@rafno,@aciklama,@kayıttarihi)", baglanti);
            komut.Parameters.AddWithValue("@barkodno", barkodNoTextBox.Text);
            komut.Parameters.AddWithValue("@kitapAdi", kitapadiTextBox.Text);
            komut.Parameters.AddWithValue("@yazari", yazariTextBox.Text);
            komut.Parameters.AddWithValue("@yayınevi", yayıneviTextBox.Text);
            komut.Parameters.AddWithValue("@sayfasayisi", sayfaSayisiTextBox.Text);
            komut.Parameters.AddWithValue("@turu", turuComboBox.Text);
            komut.Parameters.AddWithValue("@stoksayisi", stokSayisiTextBox.Text);
            komut.Parameters.AddWithValue("@rafno", rafNoTExtBox.Text);
            komut.Parameters.AddWithValue("@aciklama", aciklamaTextBox.Text);
            komut.Parameters.AddWithValue("@kayıttarihi",DateTime.Now.ToShortDateString());

            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kitap Kaydi Yapildi");
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = " ";
                }
            }
        }
    }
}
