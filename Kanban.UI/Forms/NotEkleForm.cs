using Kanban.DATA.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kanban.UI.Forms
{
    public partial class NotEkleForm : Form
    {
        private readonly KanbanProje _kanbanProje;
        private readonly KanbanVeri _kanbanVeri;
        OnIzlemeForm onIzlemeForm = new OnIzlemeForm();

        public NotEkleForm(KanbanProje kanbanProje, KanbanVeri kanbanVeri)
        {
            InitializeComponent();
            _kanbanProje = kanbanProje;
            _kanbanVeri = kanbanVeri;
            KategorileriDoldur();
            lblKarakterSayisi.BackColor = Color.LightGreen;
            onIzlemeForm.txtOlusturulmaZamaniOnIzleme.Text = DateTime.Now.ToShortDateString() + " - " + DateTime.Now.ToShortTimeString();
        }
        private void KategorileriDoldur()
        {
            cboKategori.Items.Clear();
            cboKategori.DataSource = _kanbanVeri.Kategoriler;
        }

        private void cboKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            Kategori seciliKategori = (Kategori)cboKategori.SelectedItem;
            onIzlemeForm.pnlOnIzleme.BackColor = seciliKategori.Renk;
            onIzlemeForm.txtKategoriOnIzleme.Text = seciliKategori.Ad;
        }

        private void txtAciklama_TextChanged(object sender, EventArgs e)
        {
            int karakterSayisi = txtAciklama.Text.Length;
            if (karakterSayisi < 140)
            {
                lblKarakterSayisi.BackColor = Color.LightGreen;
            }
            else
            {
                lblKarakterSayisi.BackColor = Color.Red;
            }
            lblKarakterSayisi.Text = "Karakter Sayısı: " + (140 - karakterSayisi).ToString();
            onIzlemeForm.txtAciklamaOnIzleme.Text = txtAciklama.Text;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtAciklama.Text))
            {
                Not not = new Not()
                {
                    Kategori = (Kategori)cboKategori.SelectedItem,
                    Aciklama = txtAciklama.Text,
                };
                _kanbanProje.Notlar.Add(not);
                this.Close();
            }
            else
            {
                MessageBox.Show("Lütfen Bir Açıklama Giriniz..!");
                return;
            }
        }

        private void lblOnIzleme_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            onIzlemeForm.ShowDialog();
        }
    }
}




