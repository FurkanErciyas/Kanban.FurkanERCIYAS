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
            ToDoListele();
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
            ToDoListele();
        }

        public void ToDoListele()
        {
            pnlToDo.Controls.Clear();
            pnlToDo.Controls.Add(lblToDo);

            List<Not> not = _kanbanProje.Notlar.Where(x => x.DurumEnum == DurumEnum.ToDo).ToList();

            for (int i = 0; i < not.Count; i++)
            {
                NotEkleForm notGoster = new NotEkleForm(_kanbanProje, _kanbanVeri); // NotEkleForm'da oluşturulan ön izleme tasarımını panellerde kullanabilmek için notGoster nesnesi oluşturuldu.
                pnlToDo.Controls.Add(notGoster.grpOnIzleme);
                notGoster.grpOnIzleme.BackColor = not[i].Kategori.Renk;
                notGoster.grpOnIzleme.Top = 70 + (i * notGoster.grpOnIzleme.Height);
                notGoster.grpOnIzleme.Left = (pnlToDo.Width - notGoster.grpOnIzleme.Width) / 2;
                notGoster.txtKategoriOnIzleme.Text = not[i].Kategori.ToString();
                notGoster.txtAciklamaOnIzleme.Text = not[i].Aciklama.ToString();
                notGoster.txtOlusturulmaZamaniOnIzleme.Text = not[i].OlusturulmaZamani.ToShortDateString() + " - " + not[i].OlusturulmaZamani.ToShortTimeString();
                notGoster.btnSil.Click += BtnSil_Click;
                notGoster.btnSil.Tag = not[i].Id;
            }
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            Button tıklananButon = (Button)sender;
            Guid silinecekNotId = (Guid)tıklananButon.Tag;
            Not silinecekNot = _kanbanProje.Notlar.FirstOrDefault(x => x.Id == silinecekNotId);
            _kanbanProje.Notlar.Remove(silinecekNot);
            ToDoListele();
        }
    }
}

