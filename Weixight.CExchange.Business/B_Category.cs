using System;
using System.Collections.Generic;
using System.Text;
using Weixight.CExchange.Entity.Model;
using Weixight.CExchange.Service;
using Weixight.CExchange.Service.Interface;

namespace Weixight.CExchange.Business
{
  
    public  class B_Category
    {
        private readonly ICategory _category;

        public B_Category (ICategory category)
        {
            _category = category;
        }
        public IEnumerable<Cartegory> GetCategory ()
        {
            var MyCartegory = _category.GetAll();
            return MyCartegory;
        }
    }
}
