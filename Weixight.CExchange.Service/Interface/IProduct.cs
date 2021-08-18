using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Weixight.CExchange.Entity.Model;

namespace Weixight.CExchange.Service.Interface
{
    public  interface IProduct
    {
        Task CreateAsync(Product NewProduct);
        Product GetById(int id);
        Task UpdateAsync(Product product);
        Task UpdateAsync(int id);
        Task Delete(int id);
        IEnumerable<Product> GetAll();
    }
}
