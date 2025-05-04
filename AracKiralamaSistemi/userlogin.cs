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
using MySql.Data.MySqlClient;

namespace AracKiralamaSistemi
{
    public partial class userlogin : Form
    {
        MySqlConnection baglanti = new MySqlConnection("Server = localhost ; database = arackiralama ; Uid=root ; pwd = 1221");
        MySqlDataAdapter adapter = new MySqlDataAdapter();
        DataTable dt = new DataTable(); 

        public userlogin()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void userlogin_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.ShowDialog();
            this.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            usersignup usersignup = new usersignup();
            usersignup.ShowDialog();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            MySqlCommand login = new MySqlCommand("Select * From login Where username = @k1 and password = @k2", baglanti);
            login.Parameters.AddWithValue("@k1", textBox1.Text);
            login.Parameters.AddWithValue("@k2", textBox2.Text);
            MySqlDataReader reader = login.ExecuteReader();
            if (reader.Read())
            {
                musteriPage musteri = new musteriPage();
                musteri.ShowDialog();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı ya da Şifre !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            baglanti.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            forgotpass forgotpass = new forgotpass();
            forgotpass.ShowDialog();
            this.Hide();
        }


    }
}
