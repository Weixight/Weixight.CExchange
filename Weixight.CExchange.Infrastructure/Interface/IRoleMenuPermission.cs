using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Weixight.CExchange.Entity;

namespace Weixight.CExchange.Infrastructure.Interface
{
    public  interface IRoleMenuPermission
    {
        Task CreateAsync(RoleMenuPermission navigationMenu);
        RoleMenuPermission GetById(int id);
        Task UpdateAsync(RoleMenuPermission navigationMenu);
        Task UpdateAsync(int id);
        Task Delete(int id);
        IEnumerable<RoleMenuPermission> GetAll();
    }
}
