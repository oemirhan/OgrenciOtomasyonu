namespace OgrenciOtomasyonu
{
    partial class duyuruolustur
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
            this.listele = new System.Windows.Forms.Button();
            this.ekle = new System.Windows.Forms.Button();
            this.guncelle = new System.Windows.Forms.Button();
            this.sil = new System.Windows.Forms.Button();
            this.cikis = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // listele
            // 
            this.listele.Location = new System.Drawing.Point(517, 175);
            this.listele.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listele.Name = "listele";
            this.listele.Size = new System.Drawing.Size(160, 35);
            this.listele.TabIndex = 28;
            this.listele.Text = "Listele";
            this.listele.UseVisualStyleBackColor = true;
            this.listele.Click += new System.EventHandler(this.listele_Click);
            // 
            // ekle
            // 
            this.ekle.Location = new System.Drawing.Point(13, 175);
            this.ekle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ekle.Name = "ekle";
            this.ekle.Size = new System.Drawing.Size(160, 35);
            this.ekle.TabIndex = 25;
            this.ekle.Text = "Ekle";
            this.ekle.UseVisualStyleBackColor = true;
            this.ekle.Click += new System.EventHandler(this.ekle_Click);
            // 
            // guncelle
            // 
            this.guncelle.Location = new System.Drawing.Point(349, 175);
            this.guncelle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guncelle.Name = "guncelle";
            this.guncelle.Size = new System.Drawing.Size(160, 35);
            this.guncelle.TabIndex = 27;
            this.guncelle.Text = "Güncelle";
            this.guncelle.UseVisualStyleBackColor = true;
            this.guncelle.Click += new System.EventHandler(this.guncelle_Click);
            // 
            // sil
            // 
            this.sil.Location = new System.Drawing.Point(181, 175);
            this.sil.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sil.Name = "sil";
            this.sil.Size = new System.Drawing.Size(160, 35);
            this.sil.TabIndex = 26;
            this.sil.Text = "Sil";
            this.sil.UseVisualStyleBackColor = true;
            this.sil.Click += new System.EventHandler(this.sil_Click);
            // 
            // cikis
            // 
            this.cikis.Location = new System.Drawing.Point(685, 175);
            this.cikis.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cikis.Name = "cikis";
            this.cikis.Size = new System.Drawing.Size(160, 35);
            this.cikis.TabIndex = 28;
            this.cikis.Text = "Çıkış";
            this.cikis.UseVisualStyleBackColor = true;
            this.cikis.Click += new System.EventHandler(this.cikis_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(13, 12);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(832, 153);
            this.richTextBox1.TabIndex = 29;
            this.richTextBox1.Text = "";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 220);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(832, 543);
            this.dataGridView1.TabIndex = 31;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // idt
            // 
            this.idt.Location = new System.Drawing.Point(13, 12);
            this.idt.Name = "idt";
            this.idt.ReadOnly = true;
            this.idt.Size = new System.Drawing.Size(100, 26);
            this.idt.TabIndex = 32;
            this.idt.Visible = false;
            // 
            // duyuruolustur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(860, 777);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.idt);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cikis);
            this.Controls.Add(this.listele);
            this.Controls.Add(this.ekle);
            this.Controls.Add(this.guncelle);
            this.Controls.Add(this.sil);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "duyuruolustur";
            this.ShowIcon = false;
            this.Text = "Duyuru Oluştur";
            this.Load += new System.EventHandler(this.duyuruolustur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button listele;
        private System.Windows.Forms.Button ekle;
        private System.Windows.Forms.Button guncelle;
        private System.Windows.Forms.Button sil;
        private System.Windows.Forms.Button cikis;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox idt;
    }
}