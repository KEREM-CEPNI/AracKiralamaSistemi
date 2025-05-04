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
    public partial class musteri_Arac_Takip : Form
    {
        MySqlConnection baglanti = new MySqlConnection("server = localhost ; database = arackiralama ; Uid=root ; pwd = 1221");
        MySqlDataAdapter adapter;
        DataTable dt; 
        public musteri_Arac_Takip()
        {
            InitializeComponent();
        }

        public void VeriGetir()
        {
            dt = new DataTable();
            baglanti.Open();
            adapter = new MySqlDataAdapter("SELECT username,contact,mail,marka,model,alıs_tarihi,teslim_tarihi FROM arac_kirala", baglanti);
            dataGridView1.DataSource = dt;
            adapter.Fill(dt);
            baglanti.Close();
        }

        private void musteri_Arac_Takip_Load(object sender, EventArgs e)
        {
            VeriGetir();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            adminPage admin = new adminPage();
            admin.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            adminLogin login = new adminLogin();    
            login.Show();
            this.Hide();

        }
    }
}
