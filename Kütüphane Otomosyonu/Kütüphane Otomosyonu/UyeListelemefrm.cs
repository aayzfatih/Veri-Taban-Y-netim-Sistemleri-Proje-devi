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
    public partial class UyeListelemefrm : Form
    {
        DataSet daset = new DataSet();
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-5N31265\\SQLEXPRESS;Initial Catalog=KütüphaneOtomosyonu;Integrated Security=True");
        public UyeListelemefrm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void uyeListele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from uye",baglanti);
            adtr.Fill(daset,"uye");
            dataGridView1.DataSource = daset.Tables["uye"];
            baglanti.Close();
        }
        private void UyeListelemefrm_Load(object sender, EventArgs e)
        {
            uyeListele();
        }

        private void tcTextBox_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from uye where tc like '"+tcTextBox.Text+"'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                adSoyadTextBox.Text = read["adsoyad"].ToString();
                yasTextBox.Text = read["yas"].ToString();
                cinsiyetComboBox.Text = read["cinsiyet"].ToString();
                telefonTextBox.Text = read["telefon"].ToString();
                adresTextBox.Text = read["adres"].ToString();
                mailTextBox.Text = read["email"].ToString();
                okuduguKitapTextBox.Text = read["okukitapsayisi"].ToString();
            }
            baglanti.Close();

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tcTextBox.Text = dataGridView1.CurrentRow.Cells["tc"].Value.ToString();
        }
       
        private void arananTcTextBox_TextChanged(object sender, EventArgs e)
        {
            daset.Tables["uye"].Clear();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from uye where tc like '%" + arananTcTextBox.Text + "'", baglanti);
            adtr.Fill(daset,"uye");
            dataGridView1.DataSource = daset.Tables["uye"];
            baglanti.Close();
        }

        private void iptalButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void silButton_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("Bu kaydi silmek istiyor musunuz?","Sil",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (dialog==DialogResult.Yes)
            {

              baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from uye where tc=@tc", baglanti);
                komut.Parameters.AddWithValue("@tc", dataGridView1.CurrentRow.Cells["tc"].Value.ToString());
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Silme islemi tamamlandi");
                daset.Tables["uye"].Clear();
                uyeListele();
                 foreach (Control item in Controls)
                {
                  if (item is TextBox)
                  {
                     item.Text = " ";
                  }
                }
            }
            uyeListele();
        }

        private void guncelleButton_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update uye set adsoyad=@adsoyad,yas=@yas,cinsiyet=@cinsiyet,telefon=@telefon,adres=@adres,email=@email,okukitapsayisi=@okukitapsayisi where tc=@tc ",baglanti);
            komut.Parameters.AddWithValue("@tc", tcTextBox.Text);
            komut.Parameters.AddWithValue("@adsoyad", adSoyadTextBox.Text);
            komut.Parameters.AddWithValue("@yas", yasTextBox.Text);
            komut.Parameters.AddWithValue("@cinsiyet", cinsiyetComboBox.Text);
            komut.Parameters.AddWithValue("@telefon", telefonTextBox.Text);
            komut.Parameters.AddWithValue("@adres", adresTextBox.Text);
            komut.Parameters.AddWithValue("@email", mailTextBox.Text);
            komut.Parameters.AddWithValue("@okukitapsayisi", int.Parse(okuduguKitapTextBox.Text));
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Guncelleme islemi gerceklesti");
            daset.Tables["uye"].Clear();
            uyeListele();
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = " ";
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
