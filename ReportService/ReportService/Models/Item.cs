using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReportService.Models
{
    public class Item
    {
        public long rid { get; set; }
        public int id { get; set; }
        public int table_number  { get; set; }
        public string note { get; set; }
        public string location { get; set; }
        public string uname { get; set; }
        public int uid { get; set; }
    }
}