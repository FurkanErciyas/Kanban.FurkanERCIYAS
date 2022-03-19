namespace Kanban.UI.Forms
{
    partial class NotEkleForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.cboKategori = new System.Windows.Forms.ComboBox();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grpOnIzleme = new System.Windows.Forms.Panel();
            this.txtAciklamaOnIzleme = new System.Windows.Forms.TextBox();
            this.txtOlusturulmaZamaniOnIzleme = new System.Windows.Forms.TextBox();
            this.txtKategoriOnIzleme = new System.Windows.Forms.TextBox();
            this.lblKarakterSayisi = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.grpOnIzleme.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kategori: ";
            // 
            // cboKategori
            // 
            this.cboKategori.DisplayMember = "Ad";
            this.cboKategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKategori.FormattingEnabled = true;
            this.cboKategori.Location = new System.Drawing.Point(94, 17);
            this.cboKategori.Name = "cboKategori";
            this.cboKategori.Size = new System.Drawing.Size(187, 32);
            this.cboKategori.TabIndex = 1;
            this.cboKategori.SelectedIndexChanged += new System.EventHandler(this.cboKategori_SelectedIndexChanged);
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(16, 55);
            this.txtAciklama.MaxLength = 140;
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(265, 206);
            this.txtAciklama.TabIndex = 2;
            this.txtAciklama.TextChanged += new System.EventHandler(this.txtAciklama_TextChanged);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(181, 267);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(100, 37);
            this.btnEkle.TabIndex = 3;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grpOnIzleme);
            this.groupBox1.Location = new System.Drawing.Point(287, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(271, 287);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ön İzleme";
            // 
            // grpOnIzleme
            // 
            this.grpOnIzleme.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.grpOnIzleme.Controls.Add(this.btnSil);
            this.grpOnIzleme.Controls.Add(this.txtAciklamaOnIzleme);
            this.grpOnIzleme.Controls.Add(this.txtOlusturulmaZamaniOnIzleme);
            this.grpOnIzleme.Controls.Add(this.txtKategoriOnIzleme);
            this.grpOnIzleme.Location = new System.Drawing.Point(6, 38);
            this.grpOnIzleme.Name = "grpOnIzleme";
            this.grpOnIzleme.Size = new System.Drawing.Size(259, 243);
            this.grpOnIzleme.TabIndex = 0;
            // 
            // txtAciklamaOnIzleme
            // 
            this.txtAciklamaOnIzleme.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAciklamaOnIzleme.Location = new System.Drawing.Point(3, 38);
            this.txtAciklamaOnIzleme.Multiline = true;
            this.txtAciklamaOnIzleme.Name = "txtAciklamaOnIzleme";
            this.txtAciklamaOnIzleme.ReadOnly = true;
            this.txtAciklamaOnIzleme.Size = new System.Drawing.Size(253, 167);
            this.txtAciklamaOnIzleme.TabIndex = 3;
            // 
            // txtOlusturulmaZamaniOnIzleme
            // 
            this.txtOlusturulmaZamaniOnIzleme.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOlusturulmaZamaniOnIzleme.Enabled = false;
            this.txtOlusturulmaZamaniOnIzleme.Location = new System.Drawing.Point(3, 211);
            this.txtOlusturulmaZamaniOnIzleme.Name = "txtOlusturulmaZamaniOnIzleme";
            this.txtOlusturulmaZamaniOnIzleme.ReadOnly = true;
            this.txtOlusturulmaZamaniOnIzleme.Size = new System.Drawing.Size(253, 29);
            this.txtOlusturulmaZamaniOnIzleme.TabIndex = 1;
            // 
            // txtKategoriOnIzleme
            // 
            this.txtKategoriOnIzleme.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKategoriOnIzleme.Enabled = false;
            this.txtKategoriOnIzleme.Location = new System.Drawing.Point(3, 3);
            this.txtKategoriOnIzleme.Name = "txtKategoriOnIzleme";
            this.txtKategoriOnIzleme.ReadOnly = true;
            this.txtKategoriOnIzleme.Size = new System.Drawing.Size(253, 29);
            this.txtKategoriOnIzleme.TabIndex = 0;
            this.txtKategoriOnIzleme.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblKarakterSayisi
            // 
            this.lblKarakterSayisi.AutoSize = true;
            this.lblKarakterSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKarakterSayisi.Location = new System.Drawing.Point(13, 267);
            this.lblKarakterSayisi.Name = "lblKarakterSayisi";
            this.lblKarakterSayisi.Size = new System.Drawing.Size(135, 17);
            this.lblKarakterSayisi.TabIndex = 5;
            this.lblKarakterSayisi.Text = "Karakter Sayısı: 140";
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(224, 212);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(32, 28);
            this.btnSil.TabIndex = 4;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            // 
            // NotEkleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 312);
            this.Controls.Add(this.lblKarakterSayisi);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.cboKategori);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "NotEkleForm";
            this.Text = "Not Ekle";
            this.groupBox1.ResumeLayout(false);
            this.grpOnIzleme.ResumeLayout(false);
            this.grpOnIzleme.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboKategori;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Panel grpOnIzleme;
        public System.Windows.Forms.TextBox txtAciklamaOnIzleme;
        public System.Windows.Forms.TextBox txtOlusturulmaZamaniOnIzleme;
        public System.Windows.Forms.TextBox txtKategoriOnIzleme;
        private System.Windows.Forms.Label lblKarakterSayisi;
        public System.Windows.Forms.Button btnSil;
    }
}