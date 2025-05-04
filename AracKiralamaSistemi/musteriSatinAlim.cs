using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Cmp;

namespace AracKiralamaSistemi
{
    public partial class musteriSatinAlim : Form
    {
        MySqlConnection baglanti = new MySqlConnection("server = localhost ; database = arackiralama ; Uid = root ; pwd = 1221");
        MySqlDataAdapter adapter;
        DataTable dt;

        public musteriSatinAlim()
        {
            InitializeComponent();
    
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void musteriSatinAlim_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            MySqlCommand komut = new MySqlCommand("SELECT * FROM arac_satis WHERE durum = 'SATIŞTA'", baglanti);
            MySqlDataReader reader = komut.ExecuteReader();

            SatılıkAraclar.Items.Clear(); // önceki öğeleri temizle

            while (reader.Read())
            {
                SatılıkAraclar.Items.Add(reader["marka"].ToString() + " " + reader["model"].ToString());
            }

            baglanti.Close();
        }

        public string SeciliMarka
        {
            get
            {
                return SatılıkAraclar.SelectedItem?.ToString().Trim();
            }
        }
        public string SeciliModel
        {
            get
            {
                return SatılıkAraclar.SelectedItem?.ToString().Trim();
            }
        }

        private void SatılıkAraclar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SatılıkAraclar.SelectedItem == null)
                return;

            string secilenarac = SatılıkAraclar.SelectedItem.ToString();

            baglanti.Open();
            MySqlCommand getir = new MySqlCommand("Select * From arac_satis Where CONCAT(marka,' ',model)=@arac", baglanti);
            getir.Parameters.AddWithValue("@arac", secilenarac);
            MySqlDataReader dr = getir.ExecuteReader();

            if (dr.Read())
            {
                txtMarka.Text = dr["marka"].ToString();
                txtModel.Text = dr["model"].ToString();
                txtAractipi.Text = dr["tip"].ToString();
                txtYil.Text = dr["yıl"].ToString();
                txtSehir.Text = dr["il"].ToString();
                txtYakit.Text = dr["yakıt"].ToString();
                txtVites.Text = dr["vites"].ToString();
                txtRenk.Text = dr["renk"].ToString();
                txtfiyat.Text= dr["fiyat"].ToString();



                string dosyaAdi = dr["resim"].ToString();
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

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            MySqlCommand satis = new MySqlCommand("Insert Into satilan_araclar(ad_soyad,contact,mail,tc,adres,marka,model,tip,yıl,sehir,yakıt,vites,renk,fiyat) Values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12,@p13,@p14)",baglanti);
            satis.Parameters.AddWithValue("@p1",txtName.Text);
            satis.Parameters.AddWithValue("@p2",mskdcon.Text);
            satis.Parameters.AddWithValue("@p3",txtMail.Text);
            satis.Parameters.AddWithValue("@p4",mskdtc.Text);
            satis.Parameters.AddWithValue("@p5",richAdrss.Text);
            satis.Parameters.AddWithValue("@p6",txtMarka.Text);
            satis.Parameters.AddWithValue("@p7",txtModel.Text);
            satis.Parameters.AddWithValue("@p8",txtAractipi.Text);
            satis.Parameters.AddWithValue("@p9",txtYil.Text);
            satis.Parameters.AddWithValue("@p10",txtSehir.Text);
            satis.Parameters.AddWithValue("@p11",txtYakit.Text);
            satis.Parameters.AddWithValue("@p12",txtVites.Text);
            satis.Parameters.AddWithValue("@p13",txtRenk.Text);
            satis.Parameters.AddWithValue("@p14",txtfiyat.Text);
            satis.ExecuteNonQuery();

            //ödeme_satis öde = new ödeme_satis();
            //öde.Show();
            //this.Hide();

            this.Hide();
            if (SatılıkAraclar.SelectedItem != null)
            {
                
                string seciliMarka = SeciliMarka;
                string seciliModel = SeciliModel;
                ödeme_satis odemeForm = new ödeme_satis(seciliMarka,seciliModel);
                odemeForm.Show();
            }
            else
            {
                MessageBox.Show("Lütfen bir marka seçin.");
            }


            baglanti.Close();

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            userlogin userlogin = new userlogin();
            userlogin.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            musteriPage musteri = new musteriPage();
            musteri.Show();
            this.Hide();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            if (!radioButton1.Checked) return;

            string arama = textBox1.Text.Trim();
            SatılıkAraclar.Items.Clear();

            try
            {
                using (MySqlConnection baglanti = new MySqlConnection("server=localhost;database=arackiralama;Uid=root;pwd=1221"))
                {
                    baglanti.Open();
                    string sorgu;

                    if (string.IsNullOrEmpty(arama))
                    {
                        // TextBox boşsa, sadece SATIŞTA olanları getir
                        sorgu = @"SELECT marka, model 
                      FROM arac_satis 
                      WHERE durum = 'SATIŞTA'";
                    }
                    else
                    {
                        // TextBox doluysa, filtreleme yap AMA sadece SATIŞTA olanları getir
                        sorgu = @"SELECT marka, model 
                      FROM arac_satis 
                      WHERE durum = 'SATIŞTA' AND 
                            (marka LIKE @arama OR 
                             model LIKE @arama OR 
                             il LIKE @arama OR 
                             tip LIKE @arama)";
                    }

                    using (MySqlCommand cmd = new MySqlCommand(sorgu, baglanti))
                    {
                        if (!string.IsNullOrEmpty(arama))
                            cmd.Parameters.AddWithValue("@arama", "%" + arama + "%");

                        using (MySqlDataReader dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                string sonuc = $"{dr["marka"]} {dr["model"]}";
                                SatılıkAraclar.Items.Add(sonuc);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Arama hatası: " + ex.Message);
            }
        }
    }
}
