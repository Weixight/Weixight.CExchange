using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Weixight.CExchange.Entity
{
    public class state
    {
        [Key]
        public int state_id { get; set; }
        public string state_name { get; set; }
        // public ICollection<lga> lga { get; set; }
    }

    public class lga
    {
        [Key]
        public int lga_id { get; set; }
        public string lga_name { get; set; }
        public int state_id { get; set; }
    }

}
