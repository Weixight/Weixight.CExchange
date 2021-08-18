using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Weixight.CExchange.Entity.Model;

namespace Weixight.CExchange.Service.Interface
{
    public interface ICategory
    {
        Task CreateAsync(Cartegory NewCartegory);
        Cartegory GetById(int id);
        Task UpdateAsync(Cartegory Cartegory);
        Task UpdateAsync(int id);
        Task Delete(int id);
        IEnumerable<Cartegory> GetAll();
    }
}
