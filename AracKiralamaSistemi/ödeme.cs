using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AracKiralamaSistemi
{
    public partial class ödeme : Form
    {
        MySqlConnection baglanti = new MySqlConnection("server = localhost ; database = arackiralama ; Uid = root ; pwd = 1221");
        
        private string marka;
        private string model; 
        public ödeme(string gelenMarka,string gelenModel)
        {
            InitializeComponent();
            marka = gelenMarka;
            model = gelenModel;

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            labelname.Text = txtName.Text;

        }

        private void mskdKart_KeyUp(object sender, KeyEventArgs e)
        {
            labelKartNo.Text = mskdKart.Text;
        }

        private void comboAy_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelskt.Text = comboAy.Text + "/" + comboYıl.Text;
        }

        private void mskdCvv_KeyUp(object sender, KeyEventArgs e)
        {
            labelcvv.Text = mskdCvv.Text;
        }

        private void ödeme_Load(object sender, EventArgs e)
        {
            int ay;
            int yil;
            for (ay=1; ay<13;ay++)
            {
                comboAy.Items.Add(ay);
            }
            for(yil=25;yil<50;yil++){
                comboYıl.Items.Add(yil);
            }            
        }

        private void comboYıl_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelskt.Text = comboAy.Text + "/" + comboYıl.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            aracKira aracKira = new aracKira();
            aracKira.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            musteriPage muste = new musteriPage();
            muste.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ödemeSonuc sonuc = new ödemeSonuc();
            sonuc.Show();

            try
            {
                string[] parcalar = marka.Split(' ');
                string gercekMarka = parcalar[0];
                string gercekModel = parcalar.Length > 1 ? parcalar[1] : "";


                baglanti.Open();
                MySqlCommand durum = new MySqlCommand("UPDATE arac_ekleme SET durum = 'Kirada' WHERE marka = @marka AND model = @model", baglanti);
                durum.Parameters.AddWithValue("@marka", gercekMarka);
                durum.Parameters.AddWithValue("@model", gercekModel);
                int result = durum.ExecuteNonQuery();

            }
            catch
            {

            }
            baglanti.Close();

        }
    }
}
