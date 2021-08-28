﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Weixight.CExchange.Entity.Model
{
    public abstract class BaseEntity
    {
        public Int64 ID { get; set; }
        public DateTime AddedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string IP { get; set; }
    }
}
