using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Weixight.CExchange.Entity.Model
{
    public class EmployeeTbl : FileOnDatabaseModel
    {
        public int Epid { get; set; }
        public string FirstName { get; set; }
        public string OtherName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public DateTime DOB { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string AltNumber { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string LGA { get; set; }
        public string Origin_State { get; set; }
        public string Origing_Lga { get; set; }
        public byte[] PassPort { get; set; }
        public virtual int EmpTypeId { get; set; }
        [ForeignKey("id")]
        public virtual EmployeeTypes EmployeeTypes { get; set; }

    }
}
