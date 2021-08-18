using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Weixight.CExchange.Entity;

namespace Weixight.CExchange.Service.Interface
{
    public interface ILGA
    {
        Task CreateAsync(lga State);
        lga GetById(int id);
        Task UpdateAsync(lga State);
        Task UpdateAsync(int id);
        Task Delete(int id);
        IEnumerable<lga> GetAll();
    }
}
