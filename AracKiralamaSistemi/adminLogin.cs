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
    public partial class adminLogin : Form
    {
        MySqlConnection baglanti = new MySqlConnection("server = localhost ; database = arackiralama ; Uid = root ; pwd = 1221");
        DataTable dataTable = new DataTable();  
        

        public adminLogin()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            MySqlCommand login = new MySqlCommand("Select * From admin Where username = @k1 and password = @k2", baglanti);
            login.Parameters.AddWithValue("@k1", textBox1.Text);
            login.Parameters.AddWithValue("@k2", textBox2.Text);
            MySqlDataReader reader = login.ExecuteReader();
            if (reader.Read())
            {
                adminPage admin = new adminPage();
                admin.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı ya da Şifre !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            baglanti.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.ShowDialog();
            this.Hide();
        }
    }
}
