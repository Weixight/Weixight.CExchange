using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weixight.CExchange.Entity.Model;
using Weixight.CExchange.Entity.ViewModels;
using Weixight.CExchange.Service.Interface;

namespace Weixight.CExchange.Service.Implementation
{
    public class RoleViewService : IRoleView
    {
		private readonly RoleManager<IdentityRole> _roleManager;
		private readonly UserManager<ApplicationUser> _userManager;

		public RoleViewService(RoleManager<IdentityRole> roleManager, UserManager<ApplicationUser> userManager)
        {
			_roleManager = roleManager;
			_userManager = userManager;
        }
		public async Task  CreateAsync(string Name)
        {
			var result = await _roleManager.CreateAsync(new IdentityRole() { Name = Name });
		}

        public IEnumerable<RoleViewModel> GetAllAsync()
        {
			var roleViewModel = new List<RoleViewModel>();

			try
			{
				var roles =  _roleManager.Roles.ToList();
				foreach (var item in roles)
				{
					roleViewModel.Add(new RoleViewModel()
					{
						Id = item.Id,
						Name = item.Name,
					});
				}
				return roleViewModel;
			}
			catch (Exception ex)
			{
				string Error = ex.Message.ToString();
				return roleViewModel;
				//_logger?.LogError(ex, ex.GetBaseException().Message);
			}
		}

     
    }
}
