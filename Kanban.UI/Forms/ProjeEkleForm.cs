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
    public partial class ProjeEkleForm : Form
    {
        private readonly KanbanProje _kanbanProje;

        public ProjeEkleForm(KanbanProje kanbanProje)
        {
            InitializeComponent();
            _kanbanProje = kanbanProje;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtProjeAdi.Text))
            {
                _kanbanProje.Ad = txtProjeAdi.Text;
                this.Close();
            }
        }
    }
}
