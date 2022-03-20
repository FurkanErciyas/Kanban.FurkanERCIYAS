namespace Kanban.UI.Forms
{
    partial class OnIzlemeForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pnlOnIzleme = new System.Windows.Forms.Panel();
            this.btnSil = new System.Windows.Forms.Button();
            this.txtAciklamaOnIzleme = new System.Windows.Forms.TextBox();
            this.txtOlusturulmaZamaniOnIzleme = new System.Windows.Forms.TextBox();
            this.txtKategoriOnIzleme = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.pnlOnIzleme.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pnlOnIzleme);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(278, 287);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ön İzleme";
            // 
            // pnlOnIzleme
            // 
            this.pnlOnIzleme.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlOnIzleme.Controls.Add(this.btnSil);
            this.pnlOnIzleme.Controls.Add(this.txtAciklamaOnIzleme);
            this.pnlOnIzleme.Controls.Add(this.txtOlusturulmaZamaniOnIzleme);
            this.pnlOnIzleme.Controls.Add(this.txtKategoriOnIzleme);
            this.pnlOnIzleme.Location = new System.Drawing.Point(6, 28);
            this.pnlOnIzleme.Name = "pnlOnIzleme";
            this.pnlOnIzleme.Size = new System.Drawing.Size(266, 259);
            this.pnlOnIzleme.TabIndex = 6;
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(228, 225);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(32, 28);
            this.btnSil.TabIndex = 8;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            // 
            // txtAciklamaOnIzleme
            // 
            this.txtAciklamaOnIzleme.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAciklamaOnIzleme.Location = new System.Drawing.Point(4, 60);
            this.txtAciklamaOnIzleme.Multiline = true;
            this.txtAciklamaOnIzleme.Name = "txtAciklamaOnIzleme";
            this.txtAciklamaOnIzleme.ReadOnly = true;
            this.txtAciklamaOnIzleme.Size = new System.Drawing.Size(256, 160);
            this.txtAciklamaOnIzleme.TabIndex = 7;
            // 
            // txtOlusturulmaZamaniOnIzleme
            // 
            this.txtOlusturulmaZamaniOnIzleme.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOlusturulmaZamaniOnIzleme.Enabled = false;
            this.txtOlusturulmaZamaniOnIzleme.Location = new System.Drawing.Point(4, 225);
            this.txtOlusturulmaZamaniOnIzleme.Name = "txtOlusturulmaZamaniOnIzleme";
            this.txtOlusturulmaZamaniOnIzleme.ReadOnly = true;
            this.txtOlusturulmaZamaniOnIzleme.Size = new System.Drawing.Size(256, 29);
            this.txtOlusturulmaZamaniOnIzleme.TabIndex = 6;
            // 
            // txtKategoriOnIzleme
            // 
            this.txtKategoriOnIzleme.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKategoriOnIzleme.Enabled = false;
            this.txtKategoriOnIzleme.Location = new System.Drawing.Point(4, 26);
            this.txtKategoriOnIzleme.Name = "txtKategoriOnIzleme";
            this.txtKategoriOnIzleme.ReadOnly = true;
            this.txtKategoriOnIzleme.Size = new System.Drawing.Size(256, 29);
            this.txtKategoriOnIzleme.TabIndex = 5;
            this.txtKategoriOnIzleme.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // OnIzlemeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 314);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "OnIzlemeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ön İzleme";
            this.groupBox1.ResumeLayout(false);
            this.pnlOnIzleme.ResumeLayout(false);
            this.pnlOnIzleme.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Panel pnlOnIzleme;
        public System.Windows.Forms.Button btnSil;
        public System.Windows.Forms.TextBox txtAciklamaOnIzleme;
        public System.Windows.Forms.TextBox txtOlusturulmaZamaniOnIzleme;
        public System.Windows.Forms.TextBox txtKategoriOnIzleme;
    }
}