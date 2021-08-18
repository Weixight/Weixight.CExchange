using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Weixight.CExchange.Entity.Model;
using Weixight.CExchange.Service.Interface;

namespace Weixight.CExchange.Service.Implementation
{
    public class CategoryService : ICategory
    {
        public Task CreateAsync(Cartegory NewCartegory)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Cartegory> GetAll()
        {
            throw new NotImplementedException();
        }

        public Cartegory GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Cartegory Cartegory)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
