using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Weixight.CExchange.Entity.ViewModels;

namespace Weixight.CExchange.Service.Interface
{
    public  interface IUserLogon
    {
        public Task Login(LoginViewModel loginViewModel);
        public Task Reset(LoginViewModel loginViewModel);

    }
}
