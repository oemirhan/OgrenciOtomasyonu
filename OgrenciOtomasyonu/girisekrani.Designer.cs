namespace OgrenciOtomasyonu
{
    partial class girisekrani
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(girisekrani));
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ogrnbuton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ogrnkadi = new System.Windows.Forms.MaskedTextBox();
            this.ogrnsif = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ogrtbuton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ogrtkadi = new System.Windows.Forms.MaskedTextBox();
            this.ogrtsif = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.ogrnbuton);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.ogrnkadi);
            this.panel2.Controls.Add(this.ogrnsif);
            this.panel2.Location = new System.Drawing.Point(18, 251);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(435, 223);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(18, 69);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(110, 128);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 18);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Öğrenci:";
            // 
            // ogrnbuton
            // 
            this.ogrnbuton.Location = new System.Drawing.Point(294, 149);
            this.ogrnbuton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ogrnbuton.Name = "ogrnbuton";
            this.ogrnbuton.Size = new System.Drawing.Size(112, 35);
            this.ogrnbuton.TabIndex = 6;
            this.ogrnbuton.Text = "Giriş Yap";
            this.ogrnbuton.UseVisualStyleBackColor = true;
            this.ogrnbuton.Click += new System.EventHandler(this.ogrnbuton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(177, 114);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Şifre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(177, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Numara:";
            // 
            // ogrnkadi
            // 
            this.ogrnkadi.Location = new System.Drawing.Point(256, 69);
            this.ogrnkadi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ogrnkadi.Mask = "0000";
            this.ogrnkadi.Name = "ogrnkadi";
            this.ogrnkadi.Size = new System.Drawing.Size(148, 26);
            this.ogrnkadi.TabIndex = 2;
            this.ogrnkadi.ValidatingType = typeof(int);
            // 
            // ogrnsif
            // 
            this.ogrnsif.Location = new System.Drawing.Point(256, 109);
            this.ogrnsif.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ogrnsif.Name = "ogrnsif";
            this.ogrnsif.PasswordChar = '*';
            this.ogrnsif.Size = new System.Drawing.Size(148, 26);
            this.ogrnsif.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.ogrtbuton);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.ogrtkadi);
            this.panel1.Controls.Add(this.ogrtsif);
            this.panel1.Location = new System.Drawing.Point(18, 18);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(435, 223);
            this.panel1.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 18);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Öğretmen:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(18, 57);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 143);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // ogrtbuton
            // 
            this.ogrtbuton.Location = new System.Drawing.Point(294, 151);
            this.ogrtbuton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ogrtbuton.Name = "ogrtbuton";
            this.ogrtbuton.Size = new System.Drawing.Size(112, 35);
            this.ogrtbuton.TabIndex = 6;
            this.ogrtbuton.Text = "Giriş Yap";
            this.ogrtbuton.UseVisualStyleBackColor = true;
            this.ogrtbuton.Click += new System.EventHandler(this.ogrtbuton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(177, 115);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Şifre:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(177, 75);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Numara:";
            // 
            // ogrtkadi
            // 
            this.ogrtkadi.Location = new System.Drawing.Point(256, 71);
            this.ogrtkadi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ogrtkadi.Mask = "0000";
            this.ogrtkadi.Name = "ogrtkadi";
            this.ogrtkadi.Size = new System.Drawing.Size(148, 26);
            this.ogrtkadi.TabIndex = 2;
            // 
            // ogrtsif
            // 
            this.ogrtsif.Location = new System.Drawing.Point(256, 111);
            this.ogrtsif.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ogrtsif.Name = "ogrtsif";
            this.ogrtsif.PasswordChar = '*';
            this.ogrtsif.Size = new System.Drawing.Size(148, 26);
            this.ogrtsif.TabIndex = 4;
            // 
            // girisekrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(471, 489);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "girisekrani";
            this.ShowIcon = false;
            this.Text = "Öğretmen / Öğrenci Giriş Ekranı";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ogrnbuton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox ogrnkadi;
        private System.Windows.Forms.TextBox ogrnsif;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ogrtbuton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox ogrtkadi;
        private System.Windows.Forms.TextBox ogrtsif;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

