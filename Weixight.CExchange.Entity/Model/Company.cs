using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Weixight.CExchange.Entity.Model
{
    public   class Company
    {
        [Key]
        public int id { get; set; }
        [Display(Name = "Company Name")]

        public string Name { get; set; }
        [Display(Name = "Address")]

        public string Address { get; set; }
        [Display(Name = "Local Govt")]

        public string LGA { get; set; }
        [Display(Name = "State")]

        public string State { get; set; }
        [Display(Name = "Phone")]

        public string Phone { get; set; }
        public string RegistrantEmail { get; set; }
        
    }
}
