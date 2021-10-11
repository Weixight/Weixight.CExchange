using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Weixight.CExchange.AgricGator.Models
{
    public class NewsItems
    {
        public int id { get; set; }
        public string Tittle { get; set; }
        public string Highlight { get; set; }
        public string Details { get; set; }
        public bool activate { get; set; }
        public DateTime PostedDate { get; set; }
        public byte[] Picture { get; set; }
    }
}
