using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace AracKiralamaSistemi
{
    public partial class adminKasa : Form
    {
        MySqlConnection baglanti = new MySqlConnection("server = localhost ; database=arackiralama ; Uid = root ; Pwd = 1221");
        MySqlDataAdapter adapter;
        DataTable dt;

        public void VeriGetir_1()
        {
            dt = new DataTable();
            baglanti.Open();
            adapter = new MySqlDataAdapter("SELECT marka, model, üretim, kiralama_ucreti FROM arac_ekleme WHERE durum = 'Kirada'", baglanti);
            dataGridView1.DataSource = dt;
            adapter.Fill(dt);
            baglanti.Close();
        }
        
        public void VeriGetir_2()
        {
            dt = new DataTable();
            baglanti.Open();
            adapter = new MySqlDataAdapter("SELECT marka, model,tip,yıl,fiyat FROM arac_satis WHERE durum = 'Satıldı'", baglanti);
            dataGridView2.DataSource = dt;
            adapter.Fill(dt);
            baglanti.Close();
        }
        public adminKasa()
        {
            InitializeComponent();
        }

        private void adminKasa_Load(object sender, EventArgs e)
        {
            VeriGetir_1();
            VeriGetir_2();
            KiralikKazancHesapla();
            SatisKazancHesapla();
            ToplamKazanciHesapla();

        }

        private void KiralikKazancHesapla()
        {
            decimal toplam = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["kiralama_ucreti"].Value != null)
                {
                    decimal tutar;
                    if (decimal.TryParse(row.Cells["kiralama_ucreti"].Value.ToString(), out tutar))
                    {
                        toplam += tutar;
                    }
                }
            }

            lblKiralıkKazanc.Text = toplam.ToString("C2"); // ₺ şeklinde göstermek istersen
        }

        private void SatisKazancHesapla()
        {
            decimal toplam = 0;

            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                if (row.Cells["fiyat"].Value != null)
                {
                    decimal fiyat;
                    if (decimal.TryParse(row.Cells["fiyat"].Value.ToString(), out fiyat))
                    {
                        toplam += fiyat;
                    }
                }
            }

            lblSatisKazanc.Text = toplam.ToString("C2");
        }

        private void ToplamKazanciHesapla()
        {
            decimal kiralikKazanc = 0;
            decimal satisKazanc = 0;

            // Kiralık kazancı al
            if (decimal.TryParse(lblKiralıkKazanc.Text, NumberStyles.Currency, CultureInfo.CurrentCulture, out decimal k))
            {
                kiralikKazanc = k;
            }

            // Satış kazancını al
            if (decimal.TryParse(lblSatisKazanc.Text, NumberStyles.Currency, CultureInfo.CurrentCulture, out decimal s))
            {
                satisKazanc = s;
            }

            
            decimal toplam = kiralikKazanc + satisKazanc;

            lblToplamKazanc.Text = toplam.ToString("C2"); // Örn: ₺2.345,67
        }

        private void button2_Click(object sender, EventArgs e)
        {
            adminPage admin = new adminPage();
            admin.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            adminLogin login = new adminLogin();    
            login.Show();
        }
    }
}
