using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kanban.DATA.Models
{
    public class Not
    {
        public Not()
        {
            Id = Guid.NewGuid();
            OlusturulmaZamani = DateTime.Now;
        }
        public Guid Id { get; set; }
        public string Aciklama { get; set; }
        public DateTime OlusturulmaZamani { get; set; }
        public DurumEnum DurumEnum { get; set; }
        public Kategori Kategori { get; set; }
        public override string ToString()
        {
            return Aciklama;
        }
    }
}
