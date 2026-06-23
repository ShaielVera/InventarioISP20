using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop.Models
{
    public class Cliente
    {
            public int? id { get; set; }
            public DateTime? created_at { get; set; }
            public string first_name { get; set; }
            public string last_name { get; set; }
            public string dni { get; set; }
            public string address { get; set; }
    }
}
