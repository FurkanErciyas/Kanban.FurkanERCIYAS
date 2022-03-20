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
            this.tlpBoard = new System.Windows.Forms.TableLayoutPanel();
            this.pnlDone = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlDoing = new System.Windows.Forms.Panel();
            this.lblDoing = new System.Windows.Forms.Label();
            this.lblToDo = new System.Windows.Forms.Label();
            this.pnlToDo = new System.Windows.Forms.Panel();
            this.pnlToDoName = new System.Windows.Forms.Panel();
            this.pnlDoingName = new System.Windows.Forms.Panel();
            this.pnlDoneName = new System.Windows.Forms.Panel();
            this.msProjeForm.SuspendLayout();
            this.tlpBoard.SuspendLayout();
            this.pnlToDoName.SuspendLayout();
            this.pnlDoingName.SuspendLayout();
            this.pnlDoneName.SuspendLayout();
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
            this.msProjeForm.Size = new System.Drawing.Size(940, 29);
            this.msProjeForm.TabIndex = 0;
            this.msProjeForm.Text = "menuStrip1";
            // 
            // tsmiNotEkle
            // 
            this.tsmiNotEkle.Name = "tsmiNotEkle";
            this.tsmiNotEkle.Size = new System.Drawing.Size(80, 25);
            this.tsmiNotEkle.Text = "Not Ekle";
            this.tsmiNotEkle.Click += new System.EventHandler(this.tsmiNotEkle_Click);
            // 
            // tsmiProjeSil
            // 
            this.tsmiProjeSil.Name = "tsmiProjeSil";
            this.tsmiProjeSil.Size = new System.Drawing.Size(79, 25);
            this.tsmiProjeSil.Text = "Proje Sil";
            this.tsmiProjeSil.Click += new System.EventHandler(this.tsmiProjeSil_Click);
            // 
            // tlpBoard
            // 
            this.tlpBoard.BackColor = System.Drawing.Color.DarkGray;
            this.tlpBoard.ColumnCount = 3;
            this.tlpBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tlpBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.34F));
            this.tlpBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tlpBoard.Controls.Add(this.pnlDoneName, 2, 0);
            this.tlpBoard.Controls.Add(this.pnlDoingName, 1, 0);
            this.tlpBoard.Controls.Add(this.pnlDone, 2, 1);
            this.tlpBoard.Controls.Add(this.pnlDoing, 1, 1);
            this.tlpBoard.Controls.Add(this.pnlToDo, 0, 1);
            this.tlpBoard.Controls.Add(this.pnlToDoName, 0, 0);
            this.tlpBoard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpBoard.Location = new System.Drawing.Point(0, 29);
            this.tlpBoard.Name = "tlpBoard";
            this.tlpBoard.RowCount = 2;
            this.tlpBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tlpBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBoard.Size = new System.Drawing.Size(940, 400);
            this.tlpBoard.TabIndex = 1;
            // 
            // pnlDone
            // 
            this.pnlDone.AllowDrop = true;
            this.pnlDone.AutoScroll = true;
            this.pnlDone.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlDone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDone.Location = new System.Drawing.Point(629, 73);
            this.pnlDone.Name = "pnlDone";
            this.pnlDone.Size = new System.Drawing.Size(308, 324);
            this.pnlDone.TabIndex = 1;
            this.pnlDone.DragDrop += new System.Windows.Forms.DragEventHandler(this.pnlDone_DragDrop);
            this.pnlDone.DragEnter += new System.Windows.Forms.DragEventHandler(this.pnlToDo_DragEnter);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(113, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 33);
            this.label2.TabIndex = 3;
            this.label2.Text = "Done";
            // 
            // pnlDoing
            // 
            this.pnlDoing.AllowDrop = true;
            this.pnlDoing.AutoScroll = true;
            this.pnlDoing.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlDoing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDoing.Location = new System.Drawing.Point(316, 73);
            this.pnlDoing.Name = "pnlDoing";
            this.pnlDoing.Size = new System.Drawing.Size(307, 324);
            this.pnlDoing.TabIndex = 1;
            this.pnlDoing.DragDrop += new System.Windows.Forms.DragEventHandler(this.pnlDoing_DragDrop);
            this.pnlDoing.DragEnter += new System.Windows.Forms.DragEventHandler(this.pnlToDo_DragEnter);
            // 
            // lblDoing
            // 
            this.lblDoing.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDoing.AutoSize = true;
            this.lblDoing.BackColor = System.Drawing.Color.White;
            this.lblDoing.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDoing.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDoing.Location = new System.Drawing.Point(110, 15);
            this.lblDoing.Name = "lblDoing";
            this.lblDoing.Size = new System.Drawing.Size(87, 33);
            this.lblDoing.TabIndex = 4;
            this.lblDoing.Text = "Doing";
            // 
            // lblToDo
            // 
            this.lblToDo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblToDo.AutoSize = true;
            this.lblToDo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblToDo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblToDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToDo.Location = new System.Drawing.Point(112, 15);
            this.lblToDo.Name = "lblToDo";
            this.lblToDo.Size = new System.Drawing.Size(83, 33);
            this.lblToDo.TabIndex = 2;
            this.lblToDo.Text = "ToDo";
            // 
            // pnlToDo
            // 
            this.pnlToDo.AllowDrop = true;
            this.pnlToDo.AutoScroll = true;
            this.pnlToDo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlToDo.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlToDo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlToDo.Location = new System.Drawing.Point(3, 73);
            this.pnlToDo.Name = "pnlToDo";
            this.pnlToDo.Size = new System.Drawing.Size(307, 324);
            this.pnlToDo.TabIndex = 5;
            this.pnlToDo.DragDrop += new System.Windows.Forms.DragEventHandler(this.pnlToDo_DragDrop);
            this.pnlToDo.DragEnter += new System.Windows.Forms.DragEventHandler(this.pnlToDo_DragEnter);
            // 
            // pnlToDoName
            // 
            this.pnlToDoName.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlToDoName.Controls.Add(this.lblToDo);
            this.pnlToDoName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlToDoName.Location = new System.Drawing.Point(3, 3);
            this.pnlToDoName.Name = "pnlToDoName";
            this.pnlToDoName.Size = new System.Drawing.Size(307, 64);
            this.pnlToDoName.TabIndex = 6;
            // 
            // pnlDoingName
            // 
            this.pnlDoingName.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlDoingName.Controls.Add(this.lblDoing);
            this.pnlDoingName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDoingName.Location = new System.Drawing.Point(316, 3);
            this.pnlDoingName.Name = "pnlDoingName";
            this.pnlDoingName.Size = new System.Drawing.Size(307, 64);
            this.pnlDoingName.TabIndex = 7;
            // 
            // pnlDoneName
            // 
            this.pnlDoneName.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlDoneName.Controls.Add(this.label2);
            this.pnlDoneName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDoneName.Location = new System.Drawing.Point(629, 3);
            this.pnlDoneName.Name = "pnlDoneName";
            this.pnlDoneName.Size = new System.Drawing.Size(308, 64);
            this.pnlDoneName.TabIndex = 8;
            // 
            // ProjeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(940, 429);
            this.Controls.Add(this.tlpBoard);
            this.Controls.Add(this.msProjeForm);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MainMenuStrip = this.msProjeForm;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ProjeForm";
            this.Text = "Proje";
            this.msProjeForm.ResumeLayout(false);
            this.msProjeForm.PerformLayout();
            this.tlpBoard.ResumeLayout(false);
            this.pnlToDoName.ResumeLayout(false);
            this.pnlToDoName.PerformLayout();
            this.pnlDoingName.ResumeLayout(false);
            this.pnlDoingName.PerformLayout();
            this.pnlDoneName.ResumeLayout(false);
            this.pnlDoneName.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msProjeForm;
        private System.Windows.Forms.ToolStripMenuItem tsmiNotEkle;
        private System.Windows.Forms.ToolStripMenuItem tsmiProjeSil;
        private System.Windows.Forms.TableLayoutPanel tlpBoard;
        private System.Windows.Forms.Panel pnlDone;
        private System.Windows.Forms.Panel pnlDoing;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDoing;
        private System.Windows.Forms.Panel pnlToDo;
        private System.Windows.Forms.Label lblToDo;
        private System.Windows.Forms.Panel pnlDoneName;
        private System.Windows.Forms.Panel pnlDoingName;
        private System.Windows.Forms.Panel pnlToDoName;
    }
}