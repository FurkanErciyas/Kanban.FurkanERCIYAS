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
    public partial class ProjeForm : Form
    {
        private readonly KanbanProje _kanbanProje;
        private readonly KanbanVeri _kanbanVeri;

        public ProjeForm(KanbanProje kanbanProje, KanbanVeri kanbanVeri)
        {
            InitializeComponent();
            _kanbanProje = kanbanProje;
            _kanbanVeri = kanbanVeri;
            this.Text = "Proje Adı: " + kanbanProje.Ad + " Olusturulma Zamanı: " + kanbanProje.OlusturulmaZamani.ToShortDateString();
            msProjeForm.AllowMerge = false;
            pnlToDo.HorizontalScroll.Visible = false;
            pnlDoing.HorizontalScroll.Visible = false;
            pnlDone.HorizontalScroll.Visible = false;

        }
    }
}
