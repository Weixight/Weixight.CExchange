using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Weixight.CExchange.Entity;
using Weixight.CExchange.Persistence;
using Weixight.CExchange.Service.Interface;

namespace Weixight.CExchange.Service.Implementation
{
    public class NavigationMenuService : INavigationMenu
    {
        private readonly ApplicationDbContext _db;
        public NavigationMenuService (ApplicationDbContext db)
        {
            _db = db;
        }
#pragma warning disable CS1998 // Async method lacks 'await' operators and will run synchronously
        public async Task CreateAsync(NavigationMenu navigationMenu)
#pragma warning restore CS1998 // Async method lacks 'await' operators and will run synchronously
        {
             _db.AspNetNavigationMenu.Add(navigationMenu);
             _db.SaveChanges();
          
        }

        public async Task Delete(Guid id)
        {
            var navigationMenu = await _db.AspNetNavigationMenu.FindAsync(id);
            _db.AspNetNavigationMenu.Remove(navigationMenu);
            await _db.SaveChangesAsync();
        }

        public IEnumerable<NavigationMenu> GetAll()
        {
            var Menus = _db.AspNetNavigationMenu.Include(n => n.ParentNavigationMenu);
            return Menus;
        }

      

        public async Task UpdateAsync(NavigationMenu navigationMenu)
        {
            _db.Update(navigationMenu);
            await _db.SaveChangesAsync();
        }

      

       public async Task<NavigationMenu> GetByIdAsync(Guid id)
        {
            var navigationMenu = await _db.AspNetNavigationMenu
              .Include(n => n.ParentNavigationMenu)
              .FirstOrDefaultAsync(m => m.Id == id);
            return navigationMenu;
        }

        NavigationMenu INavigationMenu.GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
