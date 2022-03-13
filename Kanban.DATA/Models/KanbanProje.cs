using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kanban.DATA.Models
{
    public class KanbanProje
    {
        public KanbanProje()
        {
            Id = Guid.NewGuid();
            OlusturulmaZamani = DateTime.Now;
            Notlar = new List<Not>();
        }
        public Guid Id { get; set; }
        public string Ad { get; set; }
        public DateTime OlusturulmaZamani { get; set; }
        public List<Not> Notlar { get; set; }
    }
}
