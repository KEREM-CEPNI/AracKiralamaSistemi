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
    public partial class forgotpass : Form
    {
        MySqlConnection baglanti = new MySqlConnection("server = localhost ; database = arackiralama ; Uid=root ; pwd = 1221");
        public forgotpass()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            userlogin userlogin = new userlogin();
            userlogin.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Clear()
        {
            txtmail.Clear();
            txtpass.Clear();
            txtrepass.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string mail = txtmail.Text.Trim();
            string password = txtpass.Text.Trim();
            string repass = txtrepass.Text.Trim();

            if (string.IsNullOrEmpty(mail) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(repass))
            {
                MessageBox.Show("Lütfen Tüm Alanları Dolduralım.");
                return;
            }
            if (password != repass)
            {
                MessageBox.Show("Şifreler Eşleşmiyor");
                return;  
            }
           
            try
            {

                baglanti.Open();
                MySqlCommand kontrol = new MySqlCommand("Select COUNT(*) FROM login Where mail= @mail ",baglanti);
                kontrol.Parameters.AddWithValue("@mail",mail);

                int count = Convert.ToInt32(kontrol.ExecuteScalar());



                if (count>0)
                {
                    MySqlCommand update = new MySqlCommand("UPDATE login SET password = @p1 Where mail=@p2", baglanti);
                    update.Parameters.AddWithValue("@p1", password);
                    update.Parameters.AddWithValue("@p2", mail);

                    update.ExecuteNonQuery();
                    MessageBox.Show("Şifre Başarıyla Güncellendi.");
                }
                else
                {
                    MessageBox.Show("E-mail adresi sistemde bulunamadı.");
                }
            }catch {
                    
            }

            Clear();

        }
    }
}
