using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Weixight.CExchange.Entity.Model
{
    public class EmpReference : FileOnDatabaseModel
    {
        [Key]
        public new int Id { get; set; }
        public string Surname { get; set; }
        public string FirstName { get; set; }
        public string OtherName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string State { get; set; }
        public string LGA { get; set; }
        public string Gender { get; set; }
        public string MaritalStatus { get; set; }
        public virtual int Epid { get; set; }
        [ForeignKey("id")]
        public virtual EmployeeTbl EmployeeTbl { get; set; }
        public bool HrVerification { get; set; }
    }
}
