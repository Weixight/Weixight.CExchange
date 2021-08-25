using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weixight.CExchange.Entity.Model;
using Weixight.CExchange.Entity.ViewModels;
using Weixight.CExchange.Infrastructure.Interface;

namespace Weixight.CExchange.Service.Implementation
{
    public class UserViewService : IUserView
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
       // private readonly ILogger<> _logger;
        public Task CreateAsync(UserViewModel userViewModel)
        {
            throw new NotImplementedException();
        }

        public async Task Delete(string id)
        {
            var viewModel = new UserViewModel();
            if (!string.IsNullOrWhiteSpace(id))
            {
                var user = await _userManager.FindByIdAsync(id);
                var userRoles = await _userManager.GetRolesAsync(user);

                viewModel.Email = user?.Email;
                viewModel.UserName = user?.UserName;

                var allRoles = await _roleManager.Roles.ToListAsync();
                viewModel.Roles = allRoles.Select(x => new RoleViewModel()
                {
                    Id = x.Id,
                    Name = x.Name,
                    Selected = userRoles.Contains(x.Name)
                }).ToArray();
                

            }

           // return viewModel;
        }

      

        public async Task <IEnumerable<UserViewModel>> GetAll()
        {
            var userViewModel = new List<ApplicationUser>();

            try
            {
                var users = await  _userManager.Users.ToListAsync();

                foreach (var item in users)
                {
                    var isConfirm =   _userManager.IsEmailConfirmedAsync(item);
                    userViewModel.Add(new ApplicationUser()
                    {
                        Id = item.Id,
                        Email = item.Email,
                        UserName = item.UserName,
                       // isConfirm = isConfirm
                    });
                }
                return (IEnumerable<UserViewModel>)userViewModel;
            }
            catch 
            {
                // _logger?.LogError(ex, ex.GetBaseException().Message);
                return null;
            }

          
        }

        public async Task<UserViewModel> GetByIdAsync(string id)
        {
            var viewModel = new UserViewModel();
            if (!string.IsNullOrWhiteSpace(id))
            {
                var user = await _userManager.FindByIdAsync(id);
                var userRoles = await _userManager.GetRolesAsync(user);

                viewModel.Email = user?.Email;
                viewModel.UserName = user?.UserName;
               // ViewBag.FullName = user?.FirstName + " " + user?.LastName;

                var allRoles = await _roleManager.Roles.ToListAsync();
                viewModel.Roles = allRoles.Select(x => new RoleViewModel()
                {
                    Id = x.Id,
                    Name = x.Name,
                    Selected = userRoles.Contains(x.Name)
                }).ToArray();

            }

            return viewModel;
        }
        public async Task UpdateAsync(UserViewModel viewModel)
        {
            try
            {
               
                    var user = await _userManager.FindByIdAsync(viewModel.Id);
                    var userRoles = await _userManager.GetRolesAsync(user);

                    var result = await _userManager.RemoveFromRolesAsync(user, userRoles);
                    var result1 = await _userManager.AddToRolesAsync(user, viewModel.Roles.Where(x => x.Selected).Select(x => x.Name));
               
            }
            catch 
            {
                
            }
        }

       

      
    }
}
