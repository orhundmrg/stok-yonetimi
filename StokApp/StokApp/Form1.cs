using System;
using System.Drawing;
using System.Windows.Forms;

namespace stok_yonetimi
{
    public partial class Form1 : Form
    {
        // = null!; ifadesi derleyiciye "burası boş kalmayacak merak etme" der.
        private Button btnSatis = null!;
        private Button btnCari = null!;
        private Button btnStok = null!;
        private Button btnUrunYonetimi = null!;

        public Form1()
        {
            FormAyarlaVeButonlariEkle();
        }

        private void FormAyarlaVeButonlariEkle()
        {
            this.Text = "Stok ve Teknik Servis Yönetim Paneli";
            this.Width = 800;
            this.Height = 600;
            this.StartPosition = FormStartPosition.CenterScreen;

            btnSatis = new Button { Text = "Satış Yap", Width = 200, Height = 60, Location = new Point(300, 120) };
            btnSatis.Click += BtnSatis_Click;
            this.Controls.Add(btnSatis);

            btnCari = new Button { Text = "Cari Hesaplar", Width = 200, Height = 60, Location = new Point(300, 200) };
            btnCari.Click += BtnCari_Click;
            this.Controls.Add(btnCari);

            btnStok = new Button { Text = "Stok Durumu", Width = 200, Height = 60, Location = new Point(300, 280) };
            btnStok.Click += BtnStok_Click;
            this.Controls.Add(btnStok);

            btnUrunYonetimi = new Button { Text = "Ürün Ekle / Çıkar", Width = 200, Height = 60, Location = new Point(300, 360) };
            btnUrunYonetimi.Click += BtnUrunYonetimi_Click;
            this.Controls.Add(btnUrunYonetimi);
        }

        private void BtnSatis_Click(object? sender, EventArgs e)
        {
            SatisForm satisSayfasi = new SatisForm();
            satisSayfasi.Show();
        }

        private void BtnCari_Click(object? sender, EventArgs e)
        {
            CariForm cariSayfasi = new CariForm();
            cariSayfasi.Show();
        }

        private void BtnStok_Click(object? sender, EventArgs e)
        {
            StokForm stokSayfasi = new StokForm();
            stokSayfasi.Show();
        }

        private void BtnUrunYonetimi_Click(object? sender, EventArgs e)
        {
            UrunYonetimForm urunSayfasi = new UrunYonetimForm();
            urunSayfasi.Show();
        }
    }
}