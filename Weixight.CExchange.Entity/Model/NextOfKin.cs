using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Weixight.CExchange.Entity.Model
{
    public  class NextOfKin :FileOnDatabaseModel
    {
        public int id { get; set; }
        public string FirstName { get; set; }
        public string OtherName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Lga { get; set; }
        public string State { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public string Relationship { get; set; }
        [Display(Name = "Cartegory")]
        public virtual int Epid { get; set; }
        [ForeignKey("id")]
        public virtual EmployeeTbl EmployeeTbl { get; set; }
        public virtual string UserEmail { get; set; }
        [ForeignKey("id")]
        public virtual ApplicationUser ApplicationUser { get; set; }

    }
}
