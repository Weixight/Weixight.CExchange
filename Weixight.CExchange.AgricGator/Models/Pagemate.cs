using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Weixight.CExchange.AgricGator.Models;
using Weixight.CExchange.AgricGator.Models.IRepository.IProduce;

namespace Weixight.CExchange.AgricGator.Models
{
    public class Pagemate
    {
        public int LastRowOnPage { get; set; }
        public int FirstRowOnPage { get; set; }
        public int CurrentPage { get; set; }
        public int PageCount { get; set; }
        public int PageSize { get; set; }
        public int RowCount { get; set; }
        public List<Registration> Myvehicles { get; set; }
        public ICartegory GetCategory { get; set; }
    }
}
