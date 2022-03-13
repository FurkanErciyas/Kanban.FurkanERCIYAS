namespace Kanban.UI.Forms
{
    partial class ProjeForm
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
            this.msProjeForm = new System.Windows.Forms.MenuStrip();
            this.tsmiNotEkle = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiProjeSil = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlToDo = new System.Windows.Forms.Panel();
            this.pnlDone = new System.Windows.Forms.Panel();
            this.pnlDoing = new System.Windows.Forms.Panel();
            this.msProjeForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // msProjeForm
            // 
            this.msProjeForm.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.msProjeForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNotEkle,
            this.tsmiProjeSil});
            this.msProjeForm.Location = new System.Drawing.Point(0, 0);
            this.msProjeForm.Name = "msProjeForm";
            this.msProjeForm.Size = new System.Drawing.Size(939, 29);
            this.msProjeForm.TabIndex = 0;
            this.msProjeForm.Text = "menuStrip1";
            // 
            // tsmiNotEkle
            // 
            this.tsmiNotEkle.Name = "tsmiNotEkle";
            this.tsmiNotEkle.Size = new System.Drawing.Size(80, 25);
            this.tsmiNotEkle.Text = "Not Ekle";
            // 
            // tsmiProjeSil
            // 
            this.tsmiProjeSil.Name = "tsmiProjeSil";
            this.tsmiProjeSil.Size = new System.Drawing.Size(79, 25);
            this.tsmiProjeSil.Text = "Proje Sil";
            // 
            // pnlToDo
            // 
            this.pnlToDo.AllowDrop = true;
            this.pnlToDo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlToDo.AutoScroll = true;
            this.pnlToDo.BackColor = System.Drawing.Color.LightGray;
            this.pnlToDo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlToDo.Location = new System.Drawing.Point(12, 32);
            this.pnlToDo.Name = "pnlToDo";
            this.pnlToDo.Size = new System.Drawing.Size(300, 400);
            this.pnlToDo.TabIndex = 2;
            // 
            // pnlDone
            // 
            this.pnlDone.AllowDrop = true;
            this.pnlDone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDone.AutoScroll = true;
            this.pnlDone.BackColor = System.Drawing.Color.LightGray;
            this.pnlDone.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlDone.Location = new System.Drawing.Point(624, 32);
            this.pnlDone.Name = "pnlDone";
            this.pnlDone.Size = new System.Drawing.Size(300, 400);
            this.pnlDone.TabIndex = 3;
            // 
            // pnlDoing
            // 
            this.pnlDoing.AllowDrop = true;
            this.pnlDoing.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pnlDoing.AutoScroll = true;
            this.pnlDoing.BackColor = System.Drawing.Color.LightGray;
            this.pnlDoing.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlDoing.Location = new System.Drawing.Point(318, 32);
            this.pnlDoing.Name = "pnlDoing";
            this.pnlDoing.Size = new System.Drawing.Size(300, 400);
            this.pnlDoing.TabIndex = 3;
            // 
            // ProjeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(939, 447);
            this.Controls.Add(this.pnlDoing);
            this.Controls.Add(this.pnlDone);
            this.Controls.Add(this.pnlToDo);
            this.Controls.Add(this.msProjeForm);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MainMenuStrip = this.msProjeForm;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ProjeForm";
            this.Text = "Proje";
            this.msProjeForm.ResumeLayout(false);
            this.msProjeForm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msProjeForm;
        private System.Windows.Forms.ToolStripMenuItem tsmiNotEkle;
        private System.Windows.Forms.ToolStripMenuItem tsmiProjeSil;
        private System.Windows.Forms.Panel pnlToDo;
        private System.Windows.Forms.Panel pnlDone;
        private System.Windows.Forms.Panel pnlDoing;
    }
}