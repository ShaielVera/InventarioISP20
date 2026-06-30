using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop.Models
{
    public class Vehiculos
    {
        public int? id { get; set; } = null;
        public DateTime? created_at { get; set; }
        public string patent { get; set; }
        public string vehicle { get; set; }
        public string brand { get; set; }
        public string model { get; set; }
        public string year { get; set; }
        public bool removed { get; set; }
    }
}
