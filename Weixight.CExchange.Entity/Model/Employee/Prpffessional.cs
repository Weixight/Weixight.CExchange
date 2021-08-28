using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Weixight.CExchange.Entity.Model.Employee
{
    public  class Prpffessional : FileOnDatabaseModel
    {
        [Key]
        public int EmpProId { get; set; }
        public string EmpProName { get; set; }
        public string ValuDate { get; set; }
        public string EmpEmail { get; set; }
        public bool HrVerification { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public bool Lock { get; set; }
    }
}
