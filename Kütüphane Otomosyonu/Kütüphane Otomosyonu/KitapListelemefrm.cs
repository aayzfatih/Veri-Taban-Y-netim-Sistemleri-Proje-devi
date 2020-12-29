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
    public partial class KitapListelemefrm : Form
    {
        public KitapListelemefrm()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-5N31265\\SQLEXPRESS;Initial Catalog=KütüphaneOtomosyonu;Integrated Security=True");
        DataSet daset = new DataSet();
        private void kitapListele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from kitap", baglanti);
            adtr.Fill(daset, "kitap");
            dataGridView1.DataSource = daset.Tables["kitap"];
            baglanti.Close();
        }
        private void KitapListelemefrm_Load(object sender, EventArgs e)
        {
            kitapListele();
        }

        private void silButton_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("Bu kaydi silmek istiyor musunuz?", "Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {

                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from kitap where barkodno=@barkodno", baglanti);
                komut.Parameters.AddWithValue("@barkodno", dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString());
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Silme islemi tamamlandi");
                daset.Tables["kitap"].Clear();
                kitapListele();

                foreach (Control item in Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = " ";
                    }
                }
            }
            kitapListele();
        }

        private void guncelleButton_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update kitap set kitapadi=@kitapAdi,yazari=@yazari,yayınevi=@yayınevi,sayfasayisi=@sayfasayisi,turu=@turu,stoksayisi=@stoksayisi,rafno=@rafno,aciklama=@aciklama,kayıttarihi=@kayıttarihi where barkodno=@barkodno", baglanti);
            komut.Parameters.AddWithValue("@barkodno", barkodNoTextBox.Text);
            komut.Parameters.AddWithValue("@kitapAdi", kitapadiTextBox.Text);
            komut.Parameters.AddWithValue("@yazari", yazariTextBox.Text);
            komut.Parameters.AddWithValue("@yayınevi", yayıneviTextBox.Text);
            komut.Parameters.AddWithValue("@sayfasayisi", sayfaSayisiTextBox.Text);
            komut.Parameters.AddWithValue("@turu", turuComboBox.Text);
            komut.Parameters.AddWithValue("@stoksayisi", stokSayisiTextBox.Text);
            komut.Parameters.AddWithValue("@rafno", rafNoTExtBox.Text);
            komut.Parameters.AddWithValue("@aciklama", aciklamaTextBox.Text);
            komut.Parameters.AddWithValue("@kayıttarihi", DateTime.Now.ToShortDateString());
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Guncelleme islemi gerceklesti");
            daset.Tables["kitap"].Clear();
            kitapListele();

            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = " ";
                }
            }
           
        }

        private void iptalButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from kitap where barkodno like '" + textBox1.Text + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                kitapadiTextBox.Text = read["kitapadi"].ToString();
                yazariTextBox.Text = read["yazari"].ToString();
                yayıneviTextBox.Text = read["yayınevi"].ToString();
                sayfaSayisiTextBox.Text = read["sayfasayisi"].ToString();
                turuComboBox.Text = read["turu"].ToString();
                stokSayisiTextBox.Text = read["stoksayisi"].ToString();
                rafNoTExtBox.Text = read["rafno"].ToString();
                aciklamaTextBox.Text = read["aciklama"].ToString();
            }
            baglanti.Close();

        }

        private void aranacakBarkodNoTextBox_TextChanged(object sender, EventArgs e)
        {
            daset.Tables["kitap"].Clear();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from kitap where barkodNo like '%" + aranacakBarkodNoTextBox.Text + "'", baglanti);
            adtr.Fill(daset, "kitap");
            dataGridView1.DataSource = daset.Tables["kitap"];
            baglanti.Close();

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            barkodNoTextBox.Text = dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString();
        }
    }
}
