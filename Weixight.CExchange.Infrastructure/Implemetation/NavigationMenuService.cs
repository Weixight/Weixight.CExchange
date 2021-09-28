using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Weixight.CExchange.Entity;
using Weixight.CExchange.Service.Interface;

namespace Weixight.CExchange.Service.Implementation
{
    public class NavigationMenuService : INavigationMenu
    {
        public Task CreateAsync(NavigationMenu navigationMenu)
        {
            throw new NotImplementedException();
        }

        public Task Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<NavigationMenu> GetAll()
        {
            throw new NotImplementedException();
        }

        public NavigationMenu GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(NavigationMenu navigationMenu)
        {
            throw new NotImplementedException();
        }
    }
}
