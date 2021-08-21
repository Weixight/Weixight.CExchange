using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Weixight.CExchange.Entity.ViewModels;

namespace Weixight.CExchange.Service.Interface
{
    public  interface IRoleView
    {
        Task CreateAsync(RoleViewModel roleViewModel);
       // RoleViewModel GetById(int id);  
        IEnumerable<RoleViewModel> GetAll();
    }
}
