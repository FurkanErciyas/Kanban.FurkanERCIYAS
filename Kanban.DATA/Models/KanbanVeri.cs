using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kanban.DATA.Models
{
    public class KanbanVeri
    {
        public static string path = Environment.CurrentDirectory.Replace("bin\\Debug", "") + "\\veriler.json";
        public KanbanVeri()
        {
            Projeler = new List<KanbanProje>();
            Kategoriler = new List<Kategori>();
        }
        public List<KanbanProje> Projeler { get; set; }
        public List<Kategori> Kategoriler { get; set; }
    }
}
