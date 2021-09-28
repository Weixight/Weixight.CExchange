using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Weixight.CExchange.Entity.Model.Domain
{
    public  class State
    {
        [Key]
        public int state_id { get; set; }
        public string state_name { get; set; }
        public ICollection<Lga> lga { get; set; }
    }
}
