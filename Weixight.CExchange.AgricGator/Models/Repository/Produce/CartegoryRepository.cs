using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Weixight.CExchange.AgricGator.Data;
using Weixight.CExchange.AgricGator.Models.IRepository;
using Weixight.CExchange.AgricGator.Models.IRepository.IProduce;

namespace Weixight.CExchange.AgricGator.Models.Repository.Produce
{
    public class CartegoryRepository : RepositoryBase<Cartegory>, ICartegory
    {
        public CartegoryRepository(ApplicationDbContext applicationDbContext)
           : base(applicationDbContext)

        {
        }
    }
}
