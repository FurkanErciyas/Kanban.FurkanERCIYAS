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
            kanbanVeri.Projeler.Add(kanbanProje);
            ProjeForm projeForm = new ProjeForm(kanbanProje, kanbanVeri);
            projeForm.MdiParent = this;
            projeForm.Show();


        }
    }
}
