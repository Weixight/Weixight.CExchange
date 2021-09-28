using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Weixight.CExchange.Entity.ViewModels;

namespace Weixight.CExchange.Infrastructure.Interface
{
    public  interface IRoleView 
    {
        Task CreateAsync(RoleViewModel userViewModel);
        //UserViewModel GetById(string id);
        //Task UpdateAsync(RoleViewModel userViewModel);
        //Task UpdateAsync(string id);
        //Task Delete(string id);
        IEnumerable<RoleViewModel> GetAll();
    }
}
