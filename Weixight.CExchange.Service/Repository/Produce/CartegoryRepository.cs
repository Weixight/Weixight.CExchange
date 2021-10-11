using System;
using System.Collections.Generic;
using System.Text;
using Weixight.CExchange.Entity.Model;
using Weixight.CExchange.Persistence;
using Weixight.CExchange.Service.IRepositotory.IProduce;

namespace Weixight.CExchange.Service.Repository.Produce
{
    public class CartegoryRepository: RepositoryBase<Cartegory>, ICartegory
    {
        public CartegoryRepository(ApplicationDbContext applicationDbContext)
         : base(applicationDbContext)
        {
        }
    }
}
