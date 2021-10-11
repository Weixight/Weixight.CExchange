using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Weixight.CExchange.AgricGator.Data;
using Weixight.CExchange.AgricGator.Models.IRepository;
using Weixight.CExchange.AgricGator.Models.IRepository.IProduce;
using Weixight.CExchange.AgricGator.Models.Repository.Produce;

namespace Weixight.CExchange.AgricGator.Models.Repository
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private ApplicationDbContext _applicationDbContext;
        private ICartegory _Cartegory;


        public ICartegory cartegory
        {
            get
            {
                if (_Cartegory == null)
                {
                    _Cartegory = new CartegoryRepository(_applicationDbContext);

                }
                return _Cartegory;
            }



        }




        public RepositoryWrapper(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public int Save()
        {
            var RecCount = _applicationDbContext.SaveChanges();
            return RecCount;
        }
    }
}
