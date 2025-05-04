namespace AracKiralamaSistemi
{
    partial class ödeme_satis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ödeme_satis));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.mskdCvv = new System.Windows.Forms.MaskedTextBox();
            this.comboYıl = new System.Windows.Forms.ComboBox();
            this.comboAy = new System.Windows.Forms.ComboBox();
            this.mskdKart = new System.Windows.Forms.MaskedTextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblcvc = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblKart = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblcvv = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblKartName = new System.Windows.Forms.Label();
            this.lblKartno = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(471, 531);
            this.panel1.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel5.Controls.Add(this.button1);
            this.panel5.Controls.Add(this.mskdCvv);
            this.panel5.Controls.Add(this.comboYıl);
            this.panel5.Controls.Add(this.comboAy);
            this.panel5.Controls.Add(this.mskdKart);
            this.panel5.Controls.Add(this.txtName);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Font = new System.Drawing.Font("Cascadia Mono", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panel5.Location = new System.Drawing.Point(12, 118);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(437, 363);
            this.panel5.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(136, 285);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(211, 51);
            this.button1.TabIndex = 10;
            this.button1.Text = "ÖDEME YAP";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mskdCvv
            // 
            this.mskdCvv.Location = new System.Drawing.Point(148, 225);
            this.mskdCvv.Mask = "000";
            this.mskdCvv.Name = "mskdCvv";
            this.mskdCvv.Size = new System.Drawing.Size(67, 34);
            this.mskdCvv.TabIndex = 9;
            this.mskdCvv.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskdCvv_MaskInputRejected);
            // 
            // comboYıl
            // 
            this.comboYıl.FormattingEnabled = true;
            this.comboYıl.Location = new System.Drawing.Point(293, 165);
            this.comboYıl.Name = "comboYıl";
            this.comboYıl.Size = new System.Drawing.Size(126, 38);
            this.comboYıl.TabIndex = 8;
            this.comboYıl.SelectedIndexChanged += new System.EventHandler(this.comboYıl_SelectedIndexChanged_1);
            // 
            // comboAy
            // 
            this.comboAy.FormattingEnabled = true;
            this.comboAy.Location = new System.Drawing.Point(148, 165);
            this.comboAy.Name = "comboAy";
            this.comboAy.Size = new System.Drawing.Size(124, 38);
            this.comboAy.TabIndex = 7;
            this.comboAy.SelectedIndexChanged += new System.EventHandler(this.comboAy_SelectedIndexChanged_1);
            // 
            // mskdKart
            // 
            this.mskdKart.Location = new System.Drawing.Point(148, 117);
            this.mskdKart.Mask = "0000 0000 0000 0000";
            this.mskdKart.Name = "mskdKart";
            this.mskdKart.Size = new System.Drawing.Size(271, 34);
            this.mskdKart.TabIndex = 6;
            this.mskdKart.KeyUp += new System.Windows.Forms.KeyEventHandler(this.mskdKart_KeyUp);
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Location = new System.Drawing.Point(148, 66);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(271, 34);
            this.txtName.TabIndex = 5;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(61, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 30);
            this.label5.TabIndex = 4;
            this.label5.Text = "CVV : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(9, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "AD-SOYAD :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(22, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 30);
            this.label4.TabIndex = 3;
            this.label4.Text = "AY/YIL : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(9, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "KART NO : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Mono", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(73, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 30);
            this.label1.TabIndex = 6;
            this.label1.Text = "ÖDEMENİZİ TAMAMLAYINIZ";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(471, 45);
            this.panel3.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(0, 1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(46, 44);
            this.button2.TabIndex = 9;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Controls.Add(this.lblcvc);
            this.panel2.Controls.Add(this.lblName);
            this.panel2.Controls.Add(this.lblKart);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.lblcvv);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.lblKartName);
            this.panel2.Controls.Add(this.lblKartno);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Font = new System.Drawing.Font("Cascadia Mono", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panel2.Location = new System.Drawing.Point(470, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(432, 531);
            this.panel2.TabIndex = 1;
            // 
            // lblcvc
            // 
            this.lblcvc.AutoSize = true;
            this.lblcvc.Font = new System.Drawing.Font("Cascadia Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblcvc.Location = new System.Drawing.Point(230, 220);
            this.lblcvc.Name = "lblcvc";
            this.lblcvc.Size = new System.Drawing.Size(0, 20);
            this.lblcvc.TabIndex = 22;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(78, 231);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 24);
            this.lblName.TabIndex = 21;
            // 
            // lblKart
            // 
            this.lblKart.AutoSize = true;
            this.lblKart.Location = new System.Drawing.Point(78, 180);
            this.lblKart.Name = "lblKart";
            this.lblKart.Size = new System.Drawing.Size(0, 24);
            this.lblKart.TabIndex = 20;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(47, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(357, 199);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // lblcvv
            // 
            this.lblcvv.AutoSize = true;
            this.lblcvv.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblcvv.Location = new System.Drawing.Point(224, 371);
            this.lblcvv.Name = "lblcvv";
            this.lblcvv.Size = new System.Drawing.Size(0, 24);
            this.lblcvv.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(224, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 24);
            this.label6.TabIndex = 17;
            // 
            // lblKartName
            // 
            this.lblKartName.AutoSize = true;
            this.lblKartName.Location = new System.Drawing.Point(65, 231);
            this.lblKartName.Name = "lblKartName";
            this.lblKartName.Size = new System.Drawing.Size(0, 24);
            this.lblKartName.TabIndex = 16;
            // 
            // lblKartno
            // 
            this.lblKartno.AutoSize = true;
            this.lblKartno.Location = new System.Drawing.Point(78, 180);
            this.lblKartno.Name = "lblKartno";
            this.lblKartno.Size = new System.Drawing.Size(0, 24);
            this.lblKartno.TabIndex = 15;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(47, 291);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(357, 199);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(432, 45);
            this.panel4.TabIndex = 12;
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button3.Location = new System.Drawing.Point(386, 1);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(46, 44);
            this.button3.TabIndex = 11;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ödeme_satis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(902, 531);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ödeme_satis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ödeme_satis";
            this.Load += new System.EventHandler(this.ödeme_satis_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox mskdCvv;
        private System.Windows.Forms.ComboBox comboYıl;
        private System.Windows.Forms.ComboBox comboAy;
        private System.Windows.Forms.MaskedTextBox mskdKart;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lblKartno;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblKartName;
        private System.Windows.Forms.Label lblcvv;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblKart;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblcvc;
    }
}