using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AracKiralamaSistemi
{
    public partial class ödeme_satis : Form
    {
        MySqlConnection baglanti = new MySqlConnection("server = localhost ; database = arackiralama ; Uid = root ; pwd = 1221");

        private string marka;
        private string model; 
        public ödeme_satis(string gelenMarka,string gelenModel)
        {
            InitializeComponent();
            marka = gelenMarka;
            model = gelenModel;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            musteriSatinAlim alim = new musteriSatinAlim();
            alim.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            musteriPage musteri = new musteriPage();
            musteri.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ödemeSonuc sonuc = new ödemeSonuc();
            sonuc.Show();
            this.Hide();

            
            try
            {
                string[] parcalar = marka.Split(' ');
                string gercekMarka = parcalar[0];
                string gercekModel = parcalar.Length > 1 ? parcalar[1] : "";


                baglanti.Open();
                MySqlCommand durum = new MySqlCommand("UPDATE arac_satis SET durum = 'Satıldı' WHERE marka = @marka AND model = @model", baglanti);
                durum.Parameters.AddWithValue("@marka",gercekMarka);
                durum.Parameters.AddWithValue("@model",gercekModel);
                int result = durum.ExecuteNonQuery();

            }
            catch 
            {

            }
        }

        private void ödeme_satis_Load(object sender, EventArgs e)
        {
            int ay;
            int yil;
            for (ay = 1; ay < 13; ay++)
            {
                comboAy.Items.Add(ay);
            }
            for (yil = 25; yil < 50; yil++)
            {
                comboYıl.Items.Add(yil);
            }
        }

        private void txtName_TextChanged_1(object sender, EventArgs e)
        {
            lblName.Text = txtName.Text ;
        }

        

        private void comboAy_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            lblcvc.Text = comboAy.Text + "/" + comboYıl.Text;
        }

        private void mskdCvv_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            lblcvv.Text = mskdCvv.Text;
        }

        private void comboYıl_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            lblcvc.Text = comboAy.Text + "/" + comboYıl.Text;
        }

        private void mskdKart_KeyUp(object sender, KeyEventArgs e)
        {
            lblKart.Text = mskdKart.Text;
        }
    }
}
