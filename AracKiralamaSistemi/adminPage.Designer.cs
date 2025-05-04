namespace AracKiralamaSistemi
{
    partial class adminPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminPage));
            this.label1 = new System.Windows.Forms.Label();
            this.btnaraclar = new System.Windows.Forms.Button();
            this.btnmüsteri = new System.Windows.Forms.Button();
            this.btnaractakip = new System.Windows.Forms.Button();
            this.btnkasa = new System.Windows.Forms.Button();
            this.btncıkıs = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Mono", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(51, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin Islem Paneli ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnaraclar
            // 
            this.btnaraclar.BackColor = System.Drawing.Color.DarkOrange;
            this.btnaraclar.Location = new System.Drawing.Point(41, 164);
            this.btnaraclar.Name = "btnaraclar";
            this.btnaraclar.Size = new System.Drawing.Size(392, 56);
            this.btnaraclar.TabIndex = 3;
            this.btnaraclar.Text = "Kiralık Araclar";
            this.btnaraclar.UseVisualStyleBackColor = false;
            this.btnaraclar.Click += new System.EventHandler(this.btnaraclar_Click);
            // 
            // btnmüsteri
            // 
            this.btnmüsteri.BackColor = System.Drawing.Color.DarkOrange;
            this.btnmüsteri.Location = new System.Drawing.Point(41, 327);
            this.btnmüsteri.Name = "btnmüsteri";
            this.btnmüsteri.Size = new System.Drawing.Size(392, 56);
            this.btnmüsteri.TabIndex = 4;
            this.btnmüsteri.Text = "Müsteriler";
            this.btnmüsteri.UseVisualStyleBackColor = false;
            this.btnmüsteri.Click += new System.EventHandler(this.btnmüsteri_Click);
            // 
            // btnaractakip
            // 
            this.btnaractakip.BackColor = System.Drawing.Color.DarkOrange;
            this.btnaractakip.Location = new System.Drawing.Point(41, 415);
            this.btnaractakip.Name = "btnaractakip";
            this.btnaractakip.Size = new System.Drawing.Size(392, 56);
            this.btnaractakip.TabIndex = 5;
            this.btnaractakip.Text = "Müsteri ve Arac Takip";
            this.btnaractakip.UseVisualStyleBackColor = false;
            this.btnaractakip.Click += new System.EventHandler(this.btnaractakip_Click);
            // 
            // btnkasa
            // 
            this.btnkasa.BackColor = System.Drawing.Color.DarkOrange;
            this.btnkasa.Location = new System.Drawing.Point(41, 500);
            this.btnkasa.Name = "btnkasa";
            this.btnkasa.Size = new System.Drawing.Size(392, 56);
            this.btnkasa.TabIndex = 6;
            this.btnkasa.Text = "Kasa";
            this.btnkasa.UseVisualStyleBackColor = false;
            this.btnkasa.Click += new System.EventHandler(this.btnkasa_Click);
            // 
            // btncıkıs
            // 
            this.btncıkıs.BackColor = System.Drawing.Color.Red;
            this.btncıkıs.Location = new System.Drawing.Point(41, 581);
            this.btncıkıs.Name = "btncıkıs";
            this.btncıkıs.Size = new System.Drawing.Size(392, 56);
            this.btncıkıs.TabIndex = 7;
            this.btncıkıs.Text = "Çıkış";
            this.btncıkıs.UseVisualStyleBackColor = false;
            this.btncıkıs.Click += new System.EventHandler(this.btncıkıs_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(477, 45);
            this.panel1.TabIndex = 8;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 44);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(431, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(46, 44);
            this.button3.TabIndex = 3;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkOrange;
            this.button2.Location = new System.Drawing.Point(41, 246);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(392, 56);
            this.button2.TabIndex = 9;
            this.button2.Text = "Satılık Araclar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // adminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(477, 708);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btncıkıs);
            this.Controls.Add(this.btnkasa);
            this.Controls.Add(this.btnaractakip);
            this.Controls.Add(this.btnmüsteri);
            this.Controls.Add(this.btnaraclar);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Cascadia Mono", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "adminPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "adminPage";
            this.Load += new System.EventHandler(this.adminPage_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnaraclar;
        private System.Windows.Forms.Button btnmüsteri;
        private System.Windows.Forms.Button btnaractakip;
        private System.Windows.Forms.Button btnkasa;
        private System.Windows.Forms.Button btncıkıs;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}