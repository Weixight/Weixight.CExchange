using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Weixight.CExchange.Entity.Model
{
    //IdentityUser
    public class Product
    {
        [Key]
        public int id { get; set; }
        [Display(Name = "Product Name")]
        public string Name { get; set; }
        [Display(Name = "Metric")]

        public string Metric { get; set; }
        [Display(Name = "Life Time")]

        public string ShelveLife { get; set; }
        [Display(Name =" Owner")]

        public string OwnerMail { get; set; }
        [Display(Name = "Quantity")]

        public decimal  Quantity { get; set; }
        [Display(Name = "Address")]

        public string Address { get; set; }
        [Display(Name = "Local Govt")]

        public string LGA { get; set; }
        [Display(Name = "State")]

        public string State { get; set; }
        [Display(Name = "Cartegory")]
        public virtual int CartegoryId { get; set; }
        [ForeignKey("id")]
        public virtual Cartegory Cartegory { get; set; }

        [Display(Name = "Owner")]
        public virtual string Email { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        [ForeignKey("id")]
        public virtual ApplicationUser ApplicationUser { get; set; }
    }
}
