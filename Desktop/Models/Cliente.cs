using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop.Models
{
    [Table("clientes")]
    public class Cliente : BaseModel
    {
            [PrimaryKey("id", false)]
            public int? id { get; set; }
            
            [Column("created_at")]
            public DateTime? created_at { get; set; } = DateTime.Now;

            [Column("first_name")]
            public string first_name { get; set; }

            [Column("last_name")]
            public string last_name { get; set; }

            [Column("dni")]
            public string dni { get; set; }

            [Column("address")]
            public string address { get; set; }
    }
}
