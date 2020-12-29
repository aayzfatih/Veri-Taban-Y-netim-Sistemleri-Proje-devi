using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kütüphane_Otomosyonu
{
    public partial class UyeEkleForm : Form
    {
        public UyeEkleForm()
        {
            InitializeComponent();
        }

        private void UyeEklemeButton_Click(object sender, EventArgs e)
        {
            UyeEklefrm uyeEkle= new UyeEklefrm();
            uyeEkle.ShowDialog();

        }

        private void uyeListelemeButton_Click(object sender, EventArgs e)
        {
            UyeListelemefrm uyeliste = new UyeListelemefrm();
            uyeliste.ShowDialog();
        }

        private void kitapEklemeButton_Click(object sender, EventArgs e)
        {
            kitapeklefrm kitapekle = new kitapeklefrm();
            kitapekle.ShowDialog();

        }

        private void kitapListelemeButton_Click(object sender, EventArgs e)
        {
            KitapListelemefrm kitapListele = new KitapListelemefrm();
            kitapListele.ShowDialog();
        }

        private void UyeEkleForm_Load(object sender, EventArgs e)
        {

        }

        private void EmanetKitapVermeButtton_Click(object sender, EventArgs e)
        {
            EmanetKitapVerfrm emanet = new EmanetKitapVerfrm();
            emanet.ShowDialog();
        }

        private void emanetKitapListelemeButton_Click(object sender, EventArgs e)
        {
            EmanetKitapListelemefrm liste = new EmanetKitapListelemefrm();
            liste.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EmanetKitapİadefrm iade = new EmanetKitapİadefrm();
            iade.ShowDialog();
        }

        private void siralamaButton_Click(object sender, EventArgs e)
        {
            Sıralamafrm sirala = new Sıralamafrm();
            sirala.ShowDialog();

        }

        private void grafikButton_Click(object sender, EventArgs e)
        {
            Grafikfrm grafik = new Grafikfrm();
            grafik.ShowDialog();
        }
    }
}
