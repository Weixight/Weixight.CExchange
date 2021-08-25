using System;
using System.Collections.Generic;
using System.Text;
using Weixight.CExchange.Entity.Model;
using System.Threading.Tasks;

namespace Weixight.CExchange.Service.Interface
{
    public  interface IEmployee
    {
       public  Task CreateAsync(EmployeeTbl NewEmployee);
        public EmployeeTbl GetById(int id);
        public  Task UpdateAsync(EmployeeTbl NewEmployee);
        public  Task UpdateAsync(int id);
        public  Task Delete(int id);
        public  IEnumerable<EmployeeTbl> GetAll();
    }
}
