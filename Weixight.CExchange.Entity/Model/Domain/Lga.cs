using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Weixight.CExchange.Entity.Model.Domain
{
    public  class Lga
    {
        [Key]
        public int lga_id { get; set; }
        public string lga_name { get; set; }
        public int state_id { get; set; }
    }
}
