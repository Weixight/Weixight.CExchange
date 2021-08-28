using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Weixight.CExchange.Entity.Model
{
    public  class EmployeeTypes
    {
        [Key]
        public int EmpTypeId { get; set; }
        public string EmployeeType { get; set; }
        public string DSC { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }

    }
}
