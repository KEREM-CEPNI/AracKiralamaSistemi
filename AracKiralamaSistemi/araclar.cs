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
using System.IO;
namespace AracKiralamaSistemi
{
    public partial class araclar : Form
    {
        MySqlConnection baglanti = new MySqlConnection("server = localhost ; database = arackiralama ; Uid=root ; pwd = 1221");
        DataTable dt;
        MySqlDataAdapter adapter; 

        public araclar()
        {
            InitializeComponent();
        }


        private void VeriGetir()
        {
            dt = new DataTable();
            baglanti.Open();
            adapter = new MySqlDataAdapter("Select * From arac_ekleme ", baglanti);
            dataGridView1.DataSource = dt;
            adapter.Fill(dt);
            baglanti.Close(); 
        }

        
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string foto = selectedFileName;
            try
            {
                baglanti.Open();
                MySqlCommand ekle = new MySqlCommand(
             "INSERT INTO arac_ekleme (plaka, marka, model, üretim, yakıt, vites, kiralama_ucreti, durum, picture, `date`) " +
             "VALUES (@p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9, @p10)",
              baglanti
                );

                ekle.Parameters.AddWithValue("@p1", txtPlaka.Text);
                ekle.Parameters.AddWithValue("@p2", txtMarka.Text);
                ekle.Parameters.AddWithValue("@p3", txtModel.Text);
                ekle.Parameters.AddWithValue("@p4", txtUretim.Text);
                ekle.Parameters.AddWithValue("@p5", comboYakıt.Text);
                ekle.Parameters.AddWithValue("@p6", comboVites.Text);
                ekle.Parameters.AddWithValue("@p7", txtFiyat.Text);
                ekle.Parameters.AddWithValue("@p8", comboDurum.Text);
                ekle.Parameters.AddWithValue("@p9", foto);
                ekle.Parameters.AddWithValue("@p10", dateTimePicker1.Text);
                ekle.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kayıt Başarıyla Eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                VeriGetir();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Hata : " + ex.Message);
            }

            
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text= dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtPlaka.Text=dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtMarka.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtModel.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtUretim.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            comboYakıt.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            comboVites.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtFiyat.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            comboDurum.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString(); 
            string fotoDosya = dataGridView1.CurrentRow.Cells[9].Value.ToString();

            string fotoPath = Path.Combine(Application.StartupPath, "resimler", fotoDosya);
            if (File.Exists(fotoPath))
            {
                pictureBox1.Image?.Dispose(); // Mevcut resmi temizle
                pictureBox1.Image = Image.FromFile(fotoPath);
            }
            else
            {
                pictureBox1.Image = null;
            }
        }

        string selectedImagePath = "";
        string selectedFileName = "";
        private void btnFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Resim Dosyaları|*.jpg;*.jpeg;*.png;*.gif";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                selectedFileName = Path.GetFileName(ofd.FileName); // sadece dosya adı
                string hedefKlasor = Path.Combine(Application.StartupPath, "resimler");
                Directory.CreateDirectory(hedefKlasor); // yoksa oluştur

                string hedefYol = Path.Combine(hedefKlasor, selectedFileName);
                File.Copy(ofd.FileName, hedefYol, true); // dosyayı klasöre kopyala

                selectedImagePath = hedefYol; // form için tam yol
                pictureBox1.Image = Image.FromFile(selectedImagePath); // formda göster
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void araclar_Load(object sender, EventArgs e)
        {
            VeriGetir();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtFiyat.Clear();
            txtId.Clear();
            txtMarka.Clear();
            txtModel.Clear();
            txtModel.Clear();
            txtPlaka.Clear();
            txtUretim.Clear();
            comboDurum.Text = "";
            comboYakıt.Text = "";
            comboVites.Text = "";
            pictureBox1.Image = null;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            MySqlCommand sil = new MySqlCommand("Delete From arac_ekleme where id=@s1", baglanti);
            sil.Parameters.AddWithValue("@s1", txtId.Text);
            sil.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Araç Kaydı başarıyla silindi.");
            VeriGetir();
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            string foto = selectedFileName;
            baglanti.Open();
            MySqlCommand güncelle = new MySqlCommand("UPDATE arac_ekleme SET plaka=@a1 , marka = @a2 , model=@a3,üretim = @a4,yakıt=@a5,vites=@a6,kiralama_ucreti=@a7,durum=@a8,picture = @a9,date=@a10",baglanti);
            güncelle.Parameters.AddWithValue("@a1",txtPlaka.Text);
            güncelle.Parameters.AddWithValue("@a2",txtMarka.Text);
            güncelle.Parameters.AddWithValue("@a3",txtModel.Text);
            güncelle.Parameters.AddWithValue("@a4",txtUretim.Text);
            güncelle.Parameters.AddWithValue("@a5",comboYakıt.Text);
            güncelle.Parameters.AddWithValue("@a6",comboVites.Text);
            güncelle.Parameters.AddWithValue("@a7",txtFiyat.Text);
            güncelle.Parameters.AddWithValue("@a8",comboDurum.Text);
            güncelle.Parameters.AddWithValue("@a9",foto);
            güncelle.Parameters.AddWithValue("@a10",dateTimePicker1.Text);
            güncelle.ExecuteNonQuery();
            MessageBox.Show("Kayıt başarıyla güncellendi.","Başarılı",MessageBoxButtons.OK,MessageBoxIcon.Information);
            baglanti.Close();
            VeriGetir();
              
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            adminPage adminPage = new adminPage();
            adminPage.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
