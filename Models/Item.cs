using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tablet_blazor.Models
{
    public class Item
    {
        public int id { get; set; }
        public string name { get; set; }
        public string note { get; set; }
        public decimal qty { get; set; }
        public string table_number { get; set; }
        public int uid { get; set; }
        public string person_id { get; set; }
        public string uname { get; set; }
        public bool P { get; set; }
        public bool O { get; set; }

        public long rid { get; set; }

        public string location { get; set; }
    }
}
