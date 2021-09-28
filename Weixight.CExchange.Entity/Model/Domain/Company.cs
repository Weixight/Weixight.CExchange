using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Weixight.CExchange.Entity.Model.Domain
{
    public  class Company
    {
        public int id { get; set; }
        [Display(Name = "Name")]
        public string Name { get; set; }
        [Display(Name = "Address")]
        public string Address { get; set; }
        [Display(Name = "Phone")]
        public string Phone { get; set; }
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Display(Name = "Website")]
        public string Website { get; set; }
        [Display(Name = "Logo")]
        public byte Logo { get; set; }
        public int Appid { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public string IpAddress { get; set; }
        public string SystemName { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public ICollection<Lga> lga { get; set; }
        public ICollection<State> state { get; set; }
    }
}
