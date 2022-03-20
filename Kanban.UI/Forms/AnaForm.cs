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
            ProjeAdlariniDoldur();
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
            ProjeAdlariniDoldur();
        }

        public void ProjeleriListele()
        {
            AnaFormTemizle();
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
            ProjeAdlariniDoldur();
        }

        private void ProjeAdlariniDoldur()
        {
            tscboProjeler.Items.Clear();
            tscboProjeler.Items.Add("");
            tscboProjeler.Items.Add("Hepsi");
            foreach (KanbanProje item in kanbanVeri.Projeler)
            {
                tscboProjeler.Items.Add(item);
            }
        }

        public void tscboProjeler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tscboProjeler.SelectedIndex == 0)
            {
                AnaFormTemizle();
            }
            else if (tscboProjeler.SelectedIndex == 1)
            {
                ProjeleriListele();
            }
            else
            {
                AnaFormTemizle();
                KanbanProje cboSeciliProje = (KanbanProje)tscboProjeler.SelectedItem;
                KanbanProje gosterilecekProje = new KanbanProje()
                {
                    Id = cboSeciliProje.Id,
                    Ad = cboSeciliProje.Ad,
                    Notlar = cboSeciliProje.Notlar,
                    OlusturulmaZamani = cboSeciliProje.OlusturulmaZamani
                };
                ProjeForm projeForm = new ProjeForm(gosterilecekProje, kanbanVeri);
                projeForm.MdiParent = this;
                projeForm.Show();
                LayoutMdi(MdiLayout.TileVertical);
            }
        }

        private void AnaFormTemizle()
        {
            foreach (var item in this.MdiChildren)
            {
                item.Dispose();
                item.Close();
            }
        }
    }
}

