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
using MySql.Data.MySqlClient;
using System.IO;
namespace AracKiralamaSistemi
{
    public partial class aracKira : Form
    {
        MySqlConnection baglanti = new MySqlConnection("server = localhost ; database = arackiralama ; Uid = root ; Pwd = 1221");
        MySqlDataAdapter adapter;
        DataTable dt;

        public aracKira()
        {
            InitializeComponent();
        }


        public string SeciliMarka
        {
            get
            {
                return ARACLAR.SelectedItem?.ToString().Trim();
            }
        }
        public string SeciliModel
        {
            get
            {
                return ARACLAR.SelectedItem?.ToString().Trim();
            }
        }
        private void aracKira_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            MySqlCommand komut = new MySqlCommand("Select * From arac_ekleme WHERE durum='Uygun'", baglanti);
            MySqlDataReader reader = komut.ExecuteReader();
            while (reader.Read())
            {
                ARACLAR.Items.Add(reader["marka"].ToString() + " " + reader["model"].ToString());
            }
            baglanti.Close();
        }

        private void ARACLAR_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ARACLAR.SelectedItem == null)
                return;

            string secilenarac = ARACLAR.SelectedItem.ToString();

            baglanti.Open();
            MySqlCommand getir = new MySqlCommand("Select * From arac_ekleme Where CONCAT(marka,' ',model)=@arac", baglanti);
            getir.Parameters.AddWithValue("@arac", secilenarac);
            MySqlDataReader dr = getir.ExecuteReader();
            
            if (dr.Read())
            {
                txtMarka.Text = dr["marka"].ToString();
                txtModel.Text = dr["model"].ToString();
                txtUretim.Text = dr["üretim"].ToString();
                comboYakıt.Text = dr["yakıt"].ToString();
                comboVites.Text = dr["vites"].ToString();
                txtFiyat.Text = dr["kiralama_ucreti"].ToString();

             
                string dosyaAdi = dr["picture"].ToString(); 
                string resimKlasoru = Path.Combine(Application.StartupPath, "resimler"); 
                string tamYol = Path.Combine(resimKlasoru, dosyaAdi);

                if (File.Exists(tamYol))
                {
                    pictureBox1.ImageLocation = tamYol;
                }
                else
                {
                    pictureBox1.Image = null;
                    MessageBox.Show("Resim bulunamadı: " + tamYol, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            baglanti.Close();
        }

        private void HesaplaTutar()
        {
            TimeSpan fark = dtpTeslimtarihi.Value - dtpAlistarihi.Value;
            int gunSayisi = fark.Days;

            if (gunSayisi>0 && !string.IsNullOrEmpty(txtFiyat.Text))
            {
                double kiraFiyati = Convert.ToDouble(txtFiyat.Text);
                double toplamTutar =gunSayisi * kiraFiyati;
                txtTutar.Text = toplamTutar.ToString("0.00");
            }
            else
            {
                txtTutar.Text = "0";
            }
        }

        private void dtpAlistarihi_ValueChanged(object sender, EventArgs e)
        {
            HesaplaTutar();
        }

        private void dtpTeslimtarihi_ValueChanged(object sender, EventArgs e)
        {
            HesaplaTutar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            musteriPage musteri = new musteriPage();
            musteri.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            MySqlCommand insert = new MySqlCommand("Insert Into arac_kirala(username,contact,mail,marka,model,uretim,yakıt,vites,fiyat,alıs_tarihi,teslim_tarihi,tutar) " +
                "values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12)",baglanti);
            insert.Parameters.AddWithValue("@p1",txtUser.Text);
            insert.Parameters.AddWithValue("@p2",mskdCon.Text);
            insert.Parameters.AddWithValue("@p3",txtMail.Text);
            insert.Parameters.AddWithValue("@p4",txtMarka.Text);
            insert.Parameters.AddWithValue("@p5",txtModel.Text);
            insert.Parameters.AddWithValue("@p6",txtUretim.Text);
            insert.Parameters.AddWithValue("@p7",comboYakıt.Text);
            insert.Parameters.AddWithValue("@p8",comboVites.Text);
            insert.Parameters.AddWithValue("@p9",txtFiyat.Text);
            insert.Parameters.AddWithValue("@p10",dtpAlistarihi.Text);
            insert.Parameters.AddWithValue("@p11",dtpTeslimtarihi.Text);
            insert.Parameters.AddWithValue("@p12", txtTutar.Text);
            insert.ExecuteNonQuery();

            //ödeme öde = new ödeme();
            //öde.Show();
            //this.Hide();
            this.Hide();
            if (ARACLAR.SelectedItem != null)
            {

                string seciliMarka = SeciliMarka;
                string seciliModel = SeciliModel;
                ödeme odemeForm = new ödeme(seciliMarka, seciliModel);
                odemeForm.Show();
            }
            else
            {
                MessageBox.Show("Lütfen bir marka seçin.");
            }
            baglanti.Close();
        }
    }
}
