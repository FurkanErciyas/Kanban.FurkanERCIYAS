namespace Kanban.UI.Forms
{
    partial class AnaForm
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
            this.msAnaForm = new System.Windows.Forms.MenuStrip();
            this.tsmiProjeEkle = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiProjeler = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiKategoriEkle = new System.Windows.Forms.ToolStripMenuItem();
            this.msAnaForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // msAnaForm
            // 
            this.msAnaForm.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.msAnaForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiProjeEkle,
            this.tsmiProjeler,
            this.tsmiKategoriEkle});
            this.msAnaForm.Location = new System.Drawing.Point(0, 0);
            this.msAnaForm.Name = "msAnaForm";
            this.msAnaForm.Padding = new System.Windows.Forms.Padding(11, 4, 0, 4);
            this.msAnaForm.Size = new System.Drawing.Size(784, 33);
            this.msAnaForm.TabIndex = 1;
            this.msAnaForm.Text = "menuStrip1";
            // 
            // tsmiProjeEkle
            // 
            this.tsmiProjeEkle.Name = "tsmiProjeEkle";
            this.tsmiProjeEkle.Size = new System.Drawing.Size(90, 25);
            this.tsmiProjeEkle.Text = "Proje Ekle";
            this.tsmiProjeEkle.Click += new System.EventHandler(this.tsmiProjeEkle_Click);
            // 
            // tsmiProjeler
            // 
            this.tsmiProjeler.Name = "tsmiProjeler";
            this.tsmiProjeler.Size = new System.Drawing.Size(76, 25);
            this.tsmiProjeler.Text = "Projeler";
            // 
            // tsmiKategoriEkle
            // 
            this.tsmiKategoriEkle.Name = "tsmiKategoriEkle";
            this.tsmiKategoriEkle.Size = new System.Drawing.Size(112, 25);
            this.tsmiKategoriEkle.Text = "Kategori Ekle";
            this.tsmiKategoriEkle.Click += new System.EventHandler(this.tsmiKategoriEkle_Click);
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.msAnaForm);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msAnaForm;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "AnaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kanban";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AnaForm_FormClosing);
            this.msAnaForm.ResumeLayout(false);
            this.msAnaForm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msAnaForm;
        private System.Windows.Forms.ToolStripMenuItem tsmiProjeEkle;
        private System.Windows.Forms.ToolStripMenuItem tsmiProjeler;
        private System.Windows.Forms.ToolStripMenuItem tsmiKategoriEkle;
    }
}