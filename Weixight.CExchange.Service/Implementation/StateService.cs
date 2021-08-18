using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Weixight.CExchange.Entity;
using Weixight.CExchange.Entity.Model;
using Weixight.CExchange.Service.Interface;

namespace Weixight.CExchange.Service.Implementation
{
    public class StateService : IState
    {
        public Task CreateAsync(state State)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<state> GetAll()
        {
            throw new NotImplementedException();
        }

        public state GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(state State)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
