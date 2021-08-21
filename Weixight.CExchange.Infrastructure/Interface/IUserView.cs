using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Weixight.CExchange.Entity.ViewModels;

namespace Weixight.CExchange.Infrastructure.Interface
{
    public interface IUserView
    {
        Task CreateAsync(UserViewModel userViewModel);
        UserViewModel GetById(string id);
        Task UpdateAsync(UserViewModel userViewModel);
        Task UpdateAsync(string id);
        Task Delete(string id);
        IEnumerable<UserViewModel> GetAll();
    }
}
