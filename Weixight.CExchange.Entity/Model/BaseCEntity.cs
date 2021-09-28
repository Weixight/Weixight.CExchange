using System;
using System.Collections.Generic;
using System.Text;

namespace Weixight.CExchange.Entity.Model
{
    public  interface BaseCEntity 
    {
        public int id { get; set; }
        public int Appid { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public string IpAddress { get; set; }
        public string SystemName { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
