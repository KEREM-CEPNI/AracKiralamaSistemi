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
    public partial class musteriPage : Form
    {
        public musteriPage()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            aracKira kiralama = new aracKira();
            kiralama.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            userlogin userlogin = new userlogin();
            userlogin.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            musteriSatinAlim satis = new musteriSatinAlim();
            satis.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            userlogin login = new userlogin();
            login.Show();
            this.Hide();
        }
    }
}
