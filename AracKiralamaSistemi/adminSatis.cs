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

namespace AracKiralamaSistemi
{
    public partial class adminSatis : Form
    {
        MySqlConnection baglanti = new MySqlConnection("server = localhost ; database = arackiralama ; Uid=root ; pwd=1221");
        MySqlDataAdapter adapter;
        DataTable dt; 
        public adminSatis()
        {
            InitializeComponent();
        }

   
        private void VeriGetir()
        {
            try
            {
                if (baglanti.State == ConnectionState.Open)
                    baglanti.Close();

                dt = new DataTable();
                baglanti.Open();
                adapter = new MySqlDataAdapter("Select * From arac_satis", baglanti);
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veri getirilemedi: " + ex.Message);
            }
            finally
            {
                if (baglanti.State == ConnectionState.Open)
                    baglanti.Close();
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

        private void btnSatis_Click(object sender, EventArgs e)
        {
            string foto = selectedFileName;
            try
            {
                baglanti.Open();
                MySqlCommand insert = new MySqlCommand("Insert Into arac_satis(marka,model,tip,yıl,fiyat,il,yakıt,vites,renk,eklenme_tarihi,durum,resim) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12)",baglanti);
                insert.Parameters.AddWithValue("@p1",txtmarka.Text);
                insert.Parameters.AddWithValue("@p2",txtModel.Text);
                insert.Parameters.AddWithValue("@p3",combotip.Text);
                insert.Parameters.AddWithValue("@p4",txtYil.Text);
                insert.Parameters.AddWithValue("@p5",txtFiyat.Text);
                insert.Parameters.AddWithValue("@p6",comboSehir.Text);
                insert.Parameters.AddWithValue("@p7",comboYakit.Text);
                insert.Parameters.AddWithValue("@p8",comboVites.Text);
                insert.Parameters.AddWithValue("@p9",txtRenk.Text);
                insert.Parameters.AddWithValue("@p10",dateTimePicker1.Text);
                insert.Parameters.AddWithValue("@p11",comboDurum.Text);
                insert.Parameters.AddWithValue("@p12",foto);
                insert.ExecuteNonQuery();
                
                baglanti.Close();
                VeriGetir();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            adminPage admin = new adminPage();
            admin.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            adminLogin login = new adminLogin();
            login.Show();
        }

        private void adminSatis_Load(object sender, EventArgs e)
        {
            VeriGetir();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
  
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtId.Clear();
            txtFiyat.Clear();
            txtmarka.Clear();
            txtModel.Clear();
            txtRenk.Clear();
            txtYil.Clear();
            comboDurum.Text = "";
            comboSehir.Text = "";
            combotip.Text = "";
            comboVites.Text = "";
            comboYakit.Text = "";
            dateTimePicker1.Text = "";
            pictureBox1.Image = null; 
        }

        private void btnCikar_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            MySqlCommand sil = new MySqlCommand("Delete From arac_satis where id=@s1", baglanti);
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
            MySqlCommand update = new MySqlCommand("UPDATE arac_satis SET id=@k0 ,marka = @k1, model = @k2, tip = @k3, yıl = @k4, fiyat = @k5, il = @k6, yakıt = @k7, vites = @k8, renk = @k9, eklenme_tarihi = @k10, durum = @k11, resim = @k12 WHERE id = @k0", baglanti);
            update.Parameters.AddWithValue("@k0",txtId.Text);
            update.Parameters.AddWithValue("@k1",txtmarka.Text);
            update.Parameters.AddWithValue("@k2",txtModel.Text);
            update.Parameters.AddWithValue("@k3",combotip.Text);
            update.Parameters.AddWithValue("@k4",txtYil.Text);
            update.Parameters.AddWithValue("@k5",txtFiyat.Text);
            update.Parameters.AddWithValue("@k6",comboSehir.Text);
            update.Parameters.AddWithValue("@k7",comboYakit.Text);
            update.Parameters.AddWithValue("@k8",comboVites.Text);
            update.Parameters.AddWithValue("@k9",txtRenk.Text);
            update.Parameters.AddWithValue("@k10",dateTimePicker1.Text);
            update.Parameters.AddWithValue("@k11",comboDurum.Text);
            update.Parameters.AddWithValue("@k12", foto);
            update.ExecuteNonQuery();
            MessageBox.Show("Araç kaydı başarıyla güncellendi.","Güncellendi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            VeriGetir();
            
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                txtId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtmarka.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtModel.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                combotip.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                txtYil.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                txtFiyat.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                comboSehir.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                comboYakit.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                comboVites.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                txtRenk.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
                comboDurum.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
                string fotoDosya = dataGridView1.CurrentRow.Cells[12].Value.ToString();

                string fotoPath = Path.Combine(Application.StartupPath, "resimler", fotoDosya);
                if (File.Exists(fotoPath))
                {
                    pictureBox1.Image?.Dispose(); // Mevcut resmi temizleme komutu var mı diye kontrol geçekleştirir varsa temizler.
                    pictureBox1.Image = Image.FromFile(fotoPath);
                }
                else
                {
                    pictureBox1.Image = null;
                }
                VeriGetir();
            }

        }
    }
}
