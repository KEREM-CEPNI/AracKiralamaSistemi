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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.BackColor = Color.Transparent;
            label1.Parent = this; 
            label1.BringToFront();
            label1.Left = (this.ClientSize.Width - label1.Width) / 2;


            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button1.BackColor = Color.Transparent;
            button1.ForeColor = Color.White; // Yazı rengi

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnuser_Click(object sender, EventArgs e)
        {
            userlogin userlogin = new userlogin();
            userlogin.ShowDialog();
            this.Hide();
        }

        private void btnadmin_Click(object sender, EventArgs e)
        {
            adminLogin adminlogin = new adminLogin();
            adminlogin.ShowDialog();
            this.Hide();
        }
    }
}
