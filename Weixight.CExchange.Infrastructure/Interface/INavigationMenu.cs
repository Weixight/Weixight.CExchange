using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Weixight.CExchange.Entity;

namespace Weixight.CExchange.Infrastructure.Interface
{
    public  interface INavigationMenu
    {
        Task CreateAsync(NavigationMenu navigationMenu);
        NavigationMenu GetById(int id);
        Task UpdateAsync(NavigationMenu navigationMenu);
        Task UpdateAsync(int id);
        Task Delete(int id);
        IEnumerable<NavigationMenu> GetAll();
    }
}
