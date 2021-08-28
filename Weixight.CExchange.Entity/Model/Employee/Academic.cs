using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Weixight.CExchange.Entity.Model
{
    public  class Academic : FileOnDatabaseModel
    {
        public int AcedemiceId { get; set; }
        public string Institurename { get; set; }
        public string Course { get; set; }
        public string DestartDate { get; set; }
        public string DeEndDate { get; set; }
        public string Degree { get; set; }
        public string DeGrade { get; set; }
        public string EmpEmail { get; set; }
        public bool HrVerification { get; set; }
        public bool Lock { get; set; }
    }
}
