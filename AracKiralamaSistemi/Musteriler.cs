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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace AracKiralamaSistemi
{
    public partial class Musteriler : Form
    {
        MySqlConnection baglanti = new MySqlConnection("server = localhost ; database = arackiralama ; Uid = root ; Pwd = 1221 ");
        MySqlDataAdapter adapter; 
        DataTable dt;
        public Musteriler()
        {
            InitializeComponent();
        }
        private void VeriGetir()
        {
            dt = new DataTable();
            baglanti.Open();
            adapter = new MySqlDataAdapter("Select * From login ", baglanti);
            dataGridView1.DataSource = dt;
            adapter.Fill(dt);
            baglanti.Close();
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            MySqlCommand insert = new MySqlCommand("Insert Into login (username,contact,mail,password) values (@p1,@p2,@p3,@p4)",baglanti);
            insert.Parameters.AddWithValue("@p1",txtUser.Text);
            insert.Parameters.AddWithValue("@p2",txtCon.Text);
            insert.Parameters.AddWithValue("@p3",txtmail.Text);
            insert.Parameters.AddWithValue("@p4",txtpass.Text);
            insert.ExecuteNonQuery();
            MessageBox.Show("Kayıt Başarıyla Eklendi.","Başarılı",MessageBoxButtons.OK,MessageBoxIcon.Information);
            baglanti.Close();
            VeriGetir();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtUser.Text= dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtCon.Text= dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtmail.Text= dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtpass.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void Musteriler_Load(object sender, EventArgs e)
        {
            VeriGetir();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            adminPage adminpage= new adminPage();
            adminpage.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            MySqlCommand güncelle = new MySqlCommand("UPDATE login SET username=@a1,contact = @a2,mail=@a3,password=@a4 ",baglanti);
            güncelle.Parameters.AddWithValue("@a1",txtUser.Text);
            güncelle.Parameters.AddWithValue("@a2",txtCon.Text);
            güncelle.Parameters.AddWithValue("@a3",txtmail.Text);
            güncelle.Parameters.AddWithValue("@a4",txtpass.Text);
            güncelle.ExecuteNonQuery();
            MessageBox.Show("Kullanıcı kaydı başarıyla güncellendi","başarı",MessageBoxButtons.OK,MessageBoxIcon.Information);
            baglanti.Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            MySqlCommand sil = new MySqlCommand("Delete From login where id=@s1", baglanti);
            sil.Parameters.AddWithValue("@s1", txtId.Text);
            sil.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kullanıcı kaydı başarıyla silindi.","Başarılı",MessageBoxButtons.OK,MessageBoxIcon.Information);
            VeriGetir();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtId.Clear();
            txtCon.Clear();
            txtUser.Clear();
            txtmail.Clear();
            txtpass.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                string input = textBox1.Text.Replace("'", "''"); // Tırnaklardan korumak için yaptım .
                DataView dv = dt.DefaultView;
                dv.RowFilter = $"username LIKE '{input}%' OR contact LIKE '{input}%' OR mail LIKE '{input}%'";
                dataGridView1.DataSource = dv;
            }
        }
    }
}
