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
    public partial class adminPage : Form
    {
        public adminPage()
        {
            InitializeComponent();
        }

        private void adminPage_Load(object sender, EventArgs e)
        {

        }

        private void btnaraclar_Click(object sender, EventArgs e)
        {
            araclar arac = new araclar();
            arac.Show();
            this.Hide();
        }

        private void btnmüsteri_Click(object sender, EventArgs e)
        {
            Musteriler musteriler = new Musteriler();
            musteriler.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            adminLogin adminLogin = new adminLogin();
            adminLogin.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            adminSatis satis = new adminSatis();
            satis.Show();
        }

        private void btncıkıs_Click(object sender, EventArgs e)
        {
            adminLogin login = new adminLogin();
            login.Show();
            this.Hide();
        }

        private void btnkasa_Click(object sender, EventArgs e)
        {
            this.Hide();
            adminKasa kasa = new adminKasa();
            kasa.Show();
        }

        private void btnaractakip_Click(object sender, EventArgs e)
        {
            musteri_Arac_Takip takip = new musteri_Arac_Takip();
            takip.Show();
            this.Hide();
        }
    }
}
