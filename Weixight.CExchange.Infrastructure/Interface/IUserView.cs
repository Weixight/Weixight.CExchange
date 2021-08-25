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
        Task <UserViewModel> GetByIdAsync(string id);
        Task UpdateAsync(UserViewModel userViewModel);
        Task Delete(string id);
        Task  <IEnumerable<UserViewModel>> GetAll();
    }
}
