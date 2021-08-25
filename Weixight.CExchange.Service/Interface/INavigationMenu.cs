using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Weixight.CExchange.Entity;

namespace Weixight.CExchange.Service.Interface
{
    public  interface INavigationMenu
    {
        public Task CreateAsync(NavigationMenu navigationMenu);
        public NavigationMenu GetByIdAsync(Guid  id);
        public Task UpdateAsync(NavigationMenu navigationMenu);

        public Task Delete(Guid id);
        public IEnumerable<NavigationMenu> GetAll();
       
    }
}
