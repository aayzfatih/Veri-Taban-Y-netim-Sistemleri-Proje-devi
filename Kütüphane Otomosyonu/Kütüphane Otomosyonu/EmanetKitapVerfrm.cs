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
    public partial class EmanetKitapVerfrm : Form
    {
        public EmanetKitapVerfrm()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-5N31265\\SQLEXPRESS;Initial Catalog=KütüphaneOtomosyonu;Integrated Security=True");
        DataSet daset = new DataSet();

        private void iptalButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void sepetListele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from sepet", baglanti);
            adtr.Fill(daset, "sepet");
            dataGridView1.DataSource = daset.Tables["sepet"];
            baglanti.Close();
        }


    
        private void ekleButton_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into sepet(barkodno,kitapadi,yazari,yayınevi,sayfasayisi,kitapsayisi,teslimtarihi,iadetarihi)" +
                " values(@barkodno,@kitapadi,@yazari,@yayınevi,@sayfasayisi,@kitapsayisi,@teslimtarihi,@iadetarihi)", baglanti);
            komut.Parameters.AddWithValue("@barkodno", barkodNoTextBox.Text);
            komut.Parameters.AddWithValue("@kitapadi", kitapAdiTextBox.Text);
            komut.Parameters.AddWithValue("@yazari", yazariTextBox.Text);
            komut.Parameters.AddWithValue("@yayınevi", yayıneviTextBox.Text);
            komut.Parameters.AddWithValue("@sayfasayisi", sayfaSayisiTextBox.Text);
            komut.Parameters.AddWithValue("@kitapsayisi", int.Parse(kitapSayisiTexBox.Text));
            komut.Parameters.AddWithValue("@teslimtarihi", dateTimePicker1.Text);
            komut.Parameters.AddWithValue("@iadetarihi", dateTimePicker2.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kitaplar sepete eklendi","Ekleme İşlemi");
            daset.Tables["sepet"].Clear();
            sepetListele();
            kitapSayisiLabel.Text = " ";
            kitapSayisi();
            foreach (Control item in kitapBilgileriGroupBox.Controls)
            {
                if(item is TextBox)
                {
                    if(item!=kitapSayisiTexBox)
                    {
                        item.Text = " ";
                    }
                }

            }


        }
        private void kitapSayisi()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select sum(kitapsayisi) from sepet", baglanti);
            kitapSayisiLabel.Text = komut.ExecuteScalar().ToString();
            baglanti.Close();

        }

        private void EmanetKitapVerfrm_Load(object sender, EventArgs e)
        {
            sepetListele();
            kitapSayisi();
        }

        private void tcTextBox_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from uye where tc like'" + tcTextBox.Text + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                adSoyadTextBox.Text = read["adsoyad"].ToString();
                yasTextBox.Text = read["yas"].ToString();
                telefonTextBox.Text = read["telefon"].ToString();
            }
            baglanti.Close();

            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select sum(kitapsayisi) from emanetkitaplar where tc='"+tcTextBox.Text+"'", baglanti);
            kayitliKitapLabel.Text = komut2.ExecuteScalar().ToString();
            baglanti.Close();
            if (tcTextBox.Text==" ")
            {
                foreach (Control item in uyeBilgileriGroupBox.Controls)
                {
                    if (item is TextBox)
                    {
                        if (item!=tcTextBox)
                        {
                            item.Text = " ";
                        }
                       
                    }
                 }
                kayitliKitapLabel.Text = " ";

            }

        }

        private void kitapBilgileriGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void barkodNoTextBox_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from kitap where barkodno like'" + barkodNoTextBox.Text + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                kitapAdiTextBox.Text = read["kitapadi"].ToString();
                yazariTextBox.Text = read["yazari"].ToString();
                yayıneviTextBox.Text = read["yayınevi"].ToString();
                sayfaSayisiTextBox.Text = read["sayfasayisi"].ToString();
            }
            baglanti.Close();
            if (barkodNoTextBox.Text==" ")
            {

                foreach (Control item in kitapBilgileriGroupBox.Controls)
                {
                     if (item is TextBox)
                     {
                         if (item!=kitapSayisiTexBox)
                          {
                         item.Text = " ";
                         }

                     }
                }
            }

           

        }

        private void silButton_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("Kayıt silinsin mi", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialog==DialogResult.Yes)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from sepet where barkodno='" + dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString() + "'", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Silme İşlemi yapıldı", "Silme İşlemi");
                daset.Tables["sepet"].Clear();
                sepetListele();
                kitapSayisiLabel.Text = " ";
                kitapSayisi();

            }
            

        }

        private void teslimEtButton_Click(object sender, EventArgs e)
        {
            if (kitapSayisiLabel.Text!=" ")
            {
                if (kayitliKitapLabel.Text==" "&& int.Parse(kitapSayisiLabel.Text)<=3||kayitliKitapLabel.Text!=" "&& int.Parse(kayitliKitapLabel.Text)+int.Parse(kitapSayisiLabel.Text)<=3)
                {
                    if (tcTextBox.Text!=" "&&adSoyadTextBox.Text!=" "&&yasTextBox.Text!=" "&&telefonTextBox.Text!=" ")
                    {
                        for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
                        {
                            baglanti.Open();
                            SqlCommand komut = new SqlCommand("insert into emanetkitaplar(tc,adsoyad,yas,telefon,barkodno,kitapadi,yazari,yayınevi,sayfasayisi,kitapsayisi,teslimtarihi,iadetarihi)" +
                                " values(insert into emanetkitaplar(@tc,@adsoyad,@yas,@telefon,@barkodno,@kitapadi,@yazari,@yayınevi,@sayfasayisi,@kitapsayisi,@teslimtarihi,@iadetarihi)", baglanti);
                            komut.Parameters.AddWithValue("@tc", tcTextBox.Text);
                            komut.Parameters.AddWithValue("@adsoyad",adSoyadTextBox.Text);
                            komut.Parameters.AddWithValue("@yas", yasTextBox.Text);
                            komut.Parameters.AddWithValue("@telefon", telefonTextBox.Text);
                            komut.Parameters.AddWithValue("barkodNo",dataGridView1.Rows[i].Cells["barkodno"].Value.ToString());
                            komut.Parameters.AddWithValue("kitapadi", dataGridView1.Rows[i].Cells["kitapadi"].Value.ToString());
                            komut.Parameters.AddWithValue("yazari", dataGridView1.Rows[i].Cells["yazari"].Value.ToString());
                            komut.Parameters.AddWithValue("yayınevi", dataGridView1.Rows[i].Cells["yayınevi"].Value.ToString());
                            komut.Parameters.AddWithValue("sayfasayisi", dataGridView1.Rows[i].Cells["sayfasayisi"].Value.ToString());
                            komut.Parameters.AddWithValue("kitapsayisi", int.Parse(dataGridView1.Rows[i].Cells["kitapsayisi"].Value.ToString()));
                            komut.Parameters.AddWithValue("teslimtarihi", dataGridView1.Rows[i].Cells["teslimtarihi"].Value.ToString());
                            komut.Parameters.AddWithValue("iadetarihi", dataGridView1.Rows[i].Cells["iadetarihi"].Value.ToString());
                            komut.ExecuteNonQuery();
                            SqlCommand komut2 = new SqlCommand("update uye set okukitapsayisi=okukitapsayisi'"+int.Parse(dataGridView1.Rows[i].Cells["kitapsayisi"].Value.ToString())+"'where tc='"+tcTextBox.Text+"' ",baglanti);
                            komut2.ExecuteNonQuery();
                            SqlCommand komut3 = new SqlCommand("update kitap set stoksayisi=stoksayisi-'" + int.Parse(dataGridView1.Rows[i].Cells["kitapsayisi"].Value.ToString()) + "'where barkodno='" + dataGridView1.Rows[i].Cells["barkodno"].Value.ToString() + "' ", baglanti);
                            komut3.ExecuteNonQuery();
                            baglanti.Close();
                        }

                        baglanti.Open();
                        SqlCommand komut4 = new SqlCommand("delete from sepet", baglanti);
                        komut4.ExecuteNonQuery();
                        baglanti.Close();
                        MessageBox.Show("Kitaplar emanet edildi");
                        daset.Tables["sepet"].Clear();
                        sepetListele();
                        tcTextBox.Text = " ";
                        kitapSayisiLabel.Text = " ";
                        kitapSayisi();
                        kayitliKitapLabel.Text = " ";
                    }
                    else
                    {
                        MessageBox.Show("üye ismi seçmelisiniz", "Uyarı");
                    }
                }
                else
                {
                    MessageBox.Show("Emanet Kitap Sayisi 3'ten fazla olamaz", "Uyarı");
                }
            }
            else
            {
                MessageBox.Show("Once sepete kitap eklenmeidir", "Dikkat");
            }







        }
    }
}
