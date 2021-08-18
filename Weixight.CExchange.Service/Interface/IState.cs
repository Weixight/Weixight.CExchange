using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Weixight.CExchange.Entity;
using Weixight.CExchange.Entity.Model;

namespace Weixight.CExchange.Service.Interface
{
    public  interface IState
    {
        Task CreateAsync(state State);
        state GetById(int id);
        Task UpdateAsync(state State);
        Task UpdateAsync(int id);
        Task Delete(int id);
        IEnumerable<state> GetAll();
    }
}
