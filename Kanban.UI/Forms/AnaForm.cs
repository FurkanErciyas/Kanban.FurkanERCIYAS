using Kanban.DATA.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kanban.UI.Forms
{
    public partial class AnaForm : Form
    {
        KanbanVeri kanbanVeri;
        public AnaForm()
        {
            InitializeComponent();
            try
            {
                string json = File.ReadAllText(KanbanVeri.path);
                kanbanVeri = JsonConvert.DeserializeObject<KanbanVeri>(json);
            }
            catch (Exception)
            {
                kanbanVeri = new KanbanVeri();
            }
            ProjeleriListele();
        }

        private void tsmiKategoriEkle_Click(object sender, EventArgs e)
        {
            KategoriEkleForm kategoriEkleForm = new KategoriEkleForm(kanbanVeri);
            kategoriEkleForm.ShowDialog();
        }

        private void AnaForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            string json = JsonConvert.SerializeObject(kanbanVeri);
            File.WriteAllText(KanbanVeri.path, json);
        }

        private void tsmiProjeEkle_Click(object sender, EventArgs e)
        {
            KanbanProje kanbanProje = new KanbanProje();
            ProjeEkleForm projeEkleForm = new ProjeEkleForm(kanbanProje);
            projeEkleForm.ShowDialog();

            if (kanbanProje.Ad != null)
            {
                kanbanVeri.Projeler.Add(kanbanProje);
                ProjeForm projeForm = new ProjeForm(kanbanProje, kanbanVeri);
                projeForm.MdiParent = this;
                projeForm.Show();
            }
            ProjeleriListele();
        }

        private void tsmiProjeler_Click(object sender, EventArgs e)
        {
            ProjeleriListele();
        }

        public void ProjeleriListele()
        {
            foreach (var item in this.MdiChildren)
            {
                item.Dispose();
                item.Close();
            }
            foreach (var item in kanbanVeri.Projeler)
            {
                ProjeForm projeForm = new ProjeForm(item, kanbanVeri);
                projeForm.ProjeSilindiginde += ProjeForm_ProjeSilindiginde;
                projeForm.MdiParent = this;
                projeForm.Show();
            }
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void ProjeForm_ProjeSilindiginde(KanbanProje kanbanProje)
        {
            kanbanVeri.Projeler.Remove(kanbanProje);
            ProjeleriListele();
        }
    }
}

