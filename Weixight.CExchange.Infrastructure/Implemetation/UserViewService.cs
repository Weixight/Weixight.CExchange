using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Weixight.CExchange.Entity.ViewModels;
using Weixight.CExchange.Infrastructure.Interface;

namespace Weixight.CExchange.Service.Implementation
{
    public class UserViewService : IUserView
    {
        public Task CreateAsync(UserViewModel userViewModel)
        {
            throw new NotImplementedException();
        }

        public Task Delete(string id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UserViewModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public UserViewModel GetById(string id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(UserViewModel userViewModel)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(string id)
        {
            throw new NotImplementedException();
        }
    }
}
