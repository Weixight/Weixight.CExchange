using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Weixight.CExchange.Entity.Model;

namespace Weixight.CExchange.Service.Interface
{
    public interface IUser
    {
        IQueryable<ApplicationUser> GetUsers();
        ApplicationUser GetUser(long id);
        void InsertUser(ApplicationUser user);
        void UpdateUser(ApplicationUser user);
        void DeleteUser(ApplicationUser user);
    }
}
