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
    

    public partial class usersignup : Form
    {

        MySqlConnection baglanti = new MySqlConnection("Server = localhost ; database = arackiralama ; Uid=root ; pwd = 1221");
        MySqlDataAdapter adapter = new MySqlDataAdapter();
        DataTable dt = new DataTable();
        public usersignup()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            userlogin userlogin = new userlogin();
            userlogin.ShowDialog();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            userlogin userlogin = new userlogin();
            userlogin.ShowDialog();
            this.Hide();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            
            MySqlCommand checkCmd = new MySqlCommand("SELECT COUNT(*) FROM login WHERE mail = @mail OR contact = @contact", baglanti);
            checkCmd.Parameters.AddWithValue("@mail", txtmail.Text);
            checkCmd.Parameters.AddWithValue("@contact", txtcontact.Text);

            int kayitSayisi = Convert.ToInt32(checkCmd.ExecuteScalar());

            if (kayitSayisi > 0)
            {
                MessageBox.Show("Bu e-posta veya iletişim numarası ile zaten kayıt yapılmış.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MySqlCommand insert = new MySqlCommand("INSERT INTO login (username, contact, mail, password) VALUES (@p1, @p2, @p3, @p4)", baglanti);
                insert.Parameters.AddWithValue("@p1", txtname.Text);
                insert.Parameters.AddWithValue("@p2", txtcontact.Text);
                insert.Parameters.AddWithValue("@p3", txtmail.Text);
                insert.Parameters.AddWithValue("@p4", txtpass.Text);
                insert.ExecuteNonQuery();

                MessageBox.Show("Kayıt işlemi başarıyla gerçekleşti. Lütfen giriş ekranına dönünüz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            baglanti.Close();
        }
    }
}
