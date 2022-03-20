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
    public delegate void ProjeSilindigindeEventHandler(KanbanProje kanbanProje);
    public partial class ProjeForm : Form
    {
        private readonly KanbanProje _kanbanProje;
        private readonly KanbanVeri _kanbanVeri;
        public event ProjeSilindigindeEventHandler ProjeSilindiginde;

        public ProjeForm(KanbanProje kanbanProje, KanbanVeri kanbanVeri)
        {
            InitializeComponent();
            _kanbanProje = kanbanProje;
            _kanbanVeri = kanbanVeri;
            this.Text = "Proje Adı: " + kanbanProje.Ad + " Olusturulma Zamanı: " + kanbanProje.OlusturulmaZamani.ToShortDateString();
            msProjeForm.AllowMerge = false;
            PanelleriListele();
        }

        private void tsmiProjeSil_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show($"{_kanbanProje.Ad} silinsin mi?", "Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                ProjeSilindiginde(_kanbanProje);
            }
        }

        private void tsmiNotEkle_Click(object sender, EventArgs e)
        {
            NotEkleForm notEkleForm = new NotEkleForm(_kanbanProje, _kanbanVeri);
            notEkleForm.ShowDialog();
            PanelleriListele();
        }

        public void ToDoListele()
        {
            pnlToDo.Controls.Clear();

            List<Not> toDoNot = _kanbanProje.Notlar.Where(x => x.DurumEnum == DurumEnum.ToDo).ToList();

            for (int i = 0; i < toDoNot.Count; i++)
            {
                OnIzlemeForm notGoster = new OnIzlemeForm();
                pnlToDo.Controls.Add(notGoster.pnlOnIzleme);
                notGoster.pnlOnIzleme.BackColor = toDoNot[i].Kategori.Renk;
                notGoster.pnlOnIzleme.Top = (i * notGoster.pnlOnIzleme.Height) + 10;
                notGoster.pnlOnIzleme.Left = (pnlToDo.Width - notGoster.pnlOnIzleme.Width) / 2;
                notGoster.txtKategoriOnIzleme.Text = toDoNot[i].Kategori.ToString();
                notGoster.txtAciklamaOnIzleme.Text = toDoNot[i].Aciklama.ToString();
                notGoster.txtOlusturulmaZamaniOnIzleme.Text = toDoNot[i].OlusturulmaZamani.ToShortDateString() + " - " + toDoNot[i].OlusturulmaZamani.ToShortTimeString();
                notGoster.btnSil.Click += BtnSil_Click;
                notGoster.btnSil.Tag = toDoNot[i].Id;
                notGoster.pnlOnIzleme.MouseDown += PnlOnIzleme_MouseDown;
                notGoster.pnlOnIzleme.Tag = toDoNot[i].Id;
            }
        }

        public void DoingListele()
        {
            pnlDoing.Controls.Clear();

            List<Not> doingNot = _kanbanProje.Notlar.Where(x => x.DurumEnum == DurumEnum.Doing).ToList();

            for (int i = 0; i < doingNot.Count; i++)
            {
                OnIzlemeForm notGoster = new OnIzlemeForm();
                pnlDoing.Controls.Add(notGoster.pnlOnIzleme);
                notGoster.pnlOnIzleme.BackColor = doingNot[i].Kategori.Renk;
                notGoster.pnlOnIzleme.Top = (i * notGoster.pnlOnIzleme.Height) + 10;
                notGoster.pnlOnIzleme.Left = (pnlDoing.Width - notGoster.pnlOnIzleme.Width) / 2;
                notGoster.txtKategoriOnIzleme.Text = doingNot[i].Kategori.ToString();
                notGoster.txtAciklamaOnIzleme.Text = doingNot[i].Aciklama.ToString();
                notGoster.txtOlusturulmaZamaniOnIzleme.Text = doingNot[i].OlusturulmaZamani.ToShortDateString() + " - " + doingNot[i].OlusturulmaZamani.ToShortTimeString();
                notGoster.btnSil.Click += BtnSil_Click;
                notGoster.btnSil.Tag = doingNot[i].Id;
                notGoster.pnlOnIzleme.MouseDown += PnlOnIzleme_MouseDown;
                notGoster.pnlOnIzleme.Tag = doingNot[i].Id;
            }
        }

        public void DoneListele()
        {
            pnlDone.Controls.Clear();

            List<Not> doneNot = _kanbanProje.Notlar.Where(x => x.DurumEnum == DurumEnum.Done).ToList();

            for (int i = 0; i < doneNot.Count; i++)
            {
                OnIzlemeForm notGoster = new OnIzlemeForm();
                pnlDone.Controls.Add(notGoster.pnlOnIzleme);
                notGoster.pnlOnIzleme.BackColor = doneNot[i].Kategori.Renk;
                notGoster.pnlOnIzleme.Top = (i * notGoster.pnlOnIzleme.Height) + 10;
                notGoster.pnlOnIzleme.Left = (pnlDone.Width - notGoster.pnlOnIzleme.Width) / 2;
                notGoster.txtKategoriOnIzleme.Text = doneNot[i].Kategori.ToString();
                notGoster.txtAciklamaOnIzleme.Text = doneNot[i].Aciklama.ToString();
                notGoster.txtOlusturulmaZamaniOnIzleme.Text = doneNot[i].OlusturulmaZamani.ToShortDateString() + " - " + doneNot[i].OlusturulmaZamani.ToShortTimeString();
                notGoster.btnSil.Click += BtnSil_Click;
                notGoster.btnSil.Tag = doneNot[i].Id;
                notGoster.pnlOnIzleme.MouseDown += PnlOnIzleme_MouseDown;
                notGoster.pnlOnIzleme.Tag = doneNot[i].Id;
            }
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            Button tıklananButon = (Button)sender;
            Guid silinecekNotId = (Guid)tıklananButon.Tag;
            Not silinecekNot = _kanbanProje.Notlar.FirstOrDefault(x => x.Id == silinecekNotId);
            _kanbanProje.Notlar.Remove(silinecekNot);
            PanelleriListele();
        }

        private void PnlOnIzleme_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && sender is Panel)
            {
                ((Panel)sender).DoDragDrop((Panel)sender, DragDropEffects.Move);
            }
            if(e.Button == MouseButtons.Right && sender is Panel)
            {
                cms.Show((Panel)sender, new Point(e.X, e.Y));
                cms.Tag = ((Panel)sender).Tag;
            }
        }

        private void pnlToDo_DragDrop(object sender, DragEventArgs e)
        {
            Panel panel = (Panel)e.Data.GetData(typeof(Panel));
            Not not = _kanbanProje.Notlar.FirstOrDefault(x => x.Id == (Guid)panel.Tag);

            if (pnlToDo.Controls.Count == 0)
            {
                panel.Top = 20;
            }
            else
            {
                Panel sonPanel = (Panel)pnlToDo.Controls[pnlToDo.Controls.Count - 1];
                panel.Top = sonPanel.Bottom;
            }

            if (not.DurumEnum == DurumEnum.Doing)
            {
                pnlDoing.Controls.Remove(panel);
            }
            else if (not.DurumEnum == DurumEnum.Done)
            {
                pnlDone.Controls.Remove(panel);
            }
            not.DurumEnum = DurumEnum.ToDo;
            pnlToDo.Controls.Add(panel);
            PanelleriListele();
        }

        private void pnlDoing_DragDrop(object sender, DragEventArgs e)
        {
            Panel panel = (Panel)e.Data.GetData(typeof(Panel));
            Not not = _kanbanProje.Notlar.FirstOrDefault(x => x.Id == (Guid)panel.Tag);

            if (pnlDoing.Controls.Count == 0)
            {
                panel.Top = 20;
            }
            else
            {
                Panel sonPanel = (Panel)pnlDoing.Controls[pnlDoing.Controls.Count - 1];
                panel.Top = sonPanel.Bottom;
            }

            if (not.DurumEnum == DurumEnum.ToDo)
            {
                pnlToDo.Controls.Remove(panel);
            }
            else if (not.DurumEnum == DurumEnum.Done)
            {
                pnlDone.Controls.Remove(panel);
            }
            not.DurumEnum = DurumEnum.Doing;
            pnlDoing.Controls.Add(panel);
            PanelleriListele();
        }

        private void pnlDone_DragDrop(object sender, DragEventArgs e)
        {
            Panel panel = (Panel)e.Data.GetData(typeof(Panel));
            Not not = _kanbanProje.Notlar.FirstOrDefault(x => x.Id == (Guid)panel.Tag);

            if (pnlDone.Controls.Count == 0)
            {
                panel.Top = 20;
            }
            else
            {
                Panel sonPanel = (Panel)pnlDone.Controls[pnlDone.Controls.Count - 1];
                panel.Top = sonPanel.Bottom;
            }

            if (not.DurumEnum == DurumEnum.ToDo)
            {
                pnlToDo.Controls.Remove(panel);
            }
            else if (not.DurumEnum == DurumEnum.Doing)
            {
                pnlDoing.Controls.Remove(panel);
            }
            not.DurumEnum = DurumEnum.Done;
            pnlDone.Controls.Add(panel);
            PanelleriListele();
        }

        private void pnlToDo_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void PanelleriListele()
        {
            ToDoListele();
            DoingListele();
            DoneListele();
        }

        private void tsmiKopyalaToDo_Click(object sender, EventArgs e)
        {
            Guid kopyalanacakId = (Guid)cms.Tag;
            Not kopyalanacakNot = _kanbanProje.Notlar.FirstOrDefault(x => x.Id == kopyalanacakId);
            _kanbanProje.Notlar.Add(new Not()
            {
                Aciklama = kopyalanacakNot.Aciklama,
                DurumEnum = DurumEnum.ToDo,
                Kategori = kopyalanacakNot.Kategori,
                OlusturulmaZamani = kopyalanacakNot.OlusturulmaZamani
            });
            PanelleriListele();
        }

        private void tsmiKopyalaDoing_Click(object sender, EventArgs e)
        {
            Guid kopyalanacakId = (Guid)cms.Tag;
            Not kopyalanacakNot = _kanbanProje.Notlar.FirstOrDefault(x => x.Id == kopyalanacakId);
            _kanbanProje.Notlar.Add(new Not()
            {
                Aciklama = kopyalanacakNot.Aciklama,
                DurumEnum = DurumEnum.Doing,
                Kategori = kopyalanacakNot.Kategori,
                OlusturulmaZamani = kopyalanacakNot.OlusturulmaZamani
            });
            PanelleriListele();
        }

        private void tsmiKopyalaDone_Click(object sender, EventArgs e)
        {
            Guid kopyalanacakId = (Guid)cms.Tag;
            Not kopyalanacakNot = _kanbanProje.Notlar.FirstOrDefault(x => x.Id == kopyalanacakId);
            _kanbanProje.Notlar.Add(new Not()
            {
                Aciklama = kopyalanacakNot.Aciklama,
                DurumEnum = DurumEnum.Done,
                Kategori = kopyalanacakNot.Kategori,
                OlusturulmaZamani = kopyalanacakNot.OlusturulmaZamani
            });
            PanelleriListele();
        }
    }
}

