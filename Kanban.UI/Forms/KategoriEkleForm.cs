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
    public partial class KategoriEkleForm : Form
    {
        private readonly KanbanVeri _kanbanVeri;
        public KategoriEkleForm(KanbanVeri kanbanVeri)
        {
            InitializeComponent();
            _kanbanVeri = kanbanVeri;
            KategorileriYukle();
        }

        private void pbRenk_Click(object sender, EventArgs e)
        {
            cdiRenk.ShowDialog();
            pbRenk.BackColor = cdiRenk.Color;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtKategoriAdi.Text))
            {
                _kanbanVeri.Kategoriler.Add(new Kategori()
                {
                    Ad = txtKategoriAdi.Text,
                    Renk = pbRenk.BackColor
                });
                txtKategoriAdi.Clear();
                pbRenk.BackColor = Color.Black;
                KategorileriYukle();
            }
        }

        private void KategorileriYukle()
        {
            lstKategoriler.Items.Clear();
            ImageList imageList = new ImageList();
            imageList.ImageSize = new Size(25, 25);
            lstKategoriler.SmallImageList = imageList;
            foreach (Kategori item in _kanbanVeri.Kategoriler)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Name = item.Ad + item.Id;
                lvi.Text = item.Ad;
                lvi.Tag = item.Id;
                Bitmap bitmap = new Bitmap(25, 25);
                for (int i = 0; i < bitmap.Width; i++)
                {
                    for (int j = 0; j < bitmap.Height; j++)
                    {
                        bitmap.SetPixel(i, j, item.Renk);
                    }
                }
                imageList.Images.Add(item.Ad, bitmap);
                lvi.ImageKey = item.Ad;
                lstKategoriler.Items.Add(lvi);
            }
        }

        private void lstKategoriler_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Delete && lstKategoriler.SelectedItems.Count > 0)
            {
                Guid kategoriId = (Guid)lstKategoriler.SelectedItems[0].Tag;
                Kategori kategori = _kanbanVeri.Kategoriler.FirstOrDefault(x => x.Id == kategoriId);
                _kanbanVeri.Kategoriler.Remove(kategori);
                KategorileriYukle();
            }
        }
    }
}
