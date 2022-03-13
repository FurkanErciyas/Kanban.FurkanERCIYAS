namespace Kanban.UI.Forms
{
    partial class KategoriEkleForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKategoriAdi = new System.Windows.Forms.TextBox();
            this.pbRenk = new System.Windows.Forms.PictureBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.lstKategoriler = new System.Windows.Forms.ListView();
            this.cdiRenk = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pbRenk)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kategori Adı: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Renk";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kategoriler";
            // 
            // txtKategoriAdi
            // 
            this.txtKategoriAdi.Location = new System.Drawing.Point(128, 16);
            this.txtKategoriAdi.Name = "txtKategoriAdi";
            this.txtKategoriAdi.Size = new System.Drawing.Size(175, 29);
            this.txtKategoriAdi.TabIndex = 3;
            // 
            // pbRenk
            // 
            this.pbRenk.BackColor = System.Drawing.Color.Black;
            this.pbRenk.Location = new System.Drawing.Point(128, 51);
            this.pbRenk.Name = "pbRenk";
            this.pbRenk.Size = new System.Drawing.Size(30, 30);
            this.pbRenk.TabIndex = 4;
            this.pbRenk.TabStop = false;
            this.pbRenk.Click += new System.EventHandler(this.pbRenk_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(166, 51);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(137, 30);
            this.btnEkle.TabIndex = 5;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // lstKategoriler
            // 
            this.lstKategoriler.HideSelection = false;
            this.lstKategoriler.Location = new System.Drawing.Point(16, 123);
            this.lstKategoriler.Name = "lstKategoriler";
            this.lstKategoriler.Size = new System.Drawing.Size(287, 266);
            this.lstKategoriler.TabIndex = 1;
            this.lstKategoriler.UseCompatibleStateImageBehavior = false;
            this.lstKategoriler.View = System.Windows.Forms.View.SmallIcon;
            this.lstKategoriler.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstKategoriler_KeyDown);
            // 
            // KategoriEkleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(320, 401);
            this.Controls.Add(this.lstKategoriler);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.pbRenk);
            this.Controls.Add(this.txtKategoriAdi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(336, 440);
            this.MinimumSize = new System.Drawing.Size(336, 440);
            this.Name = "KategoriEkleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Kategori Ekle";
            ((System.ComponentModel.ISupportInitialize)(this.pbRenk)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKategoriAdi;
        private System.Windows.Forms.PictureBox pbRenk;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.ListView lstKategoriler;
        private System.Windows.Forms.ColorDialog cdiRenk;
    }
}