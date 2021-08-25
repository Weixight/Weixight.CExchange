using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Weixight.CExchange.Entity.Model;
using Weixight.CExchange.Service.Interface;
using Weixight.CExchange.Persistence;
using System.Linq;

namespace Weixight.CExchange.Service.Implementation
{
    public class EmployeeService : IEmployee
    {
        private readonly ApplicationDbContext _db;
        public EmployeeService(ApplicationDbContext db)
        {
            _db = db;
        }
        public  Task CreateAsync(EmployeeTbl NewEmployeeTbl)
        {
            _db.EmployeeTbls.Add(NewEmployeeTbl);
            return Task.CompletedTask;
        }

        public async Task Delete(int id)
        {
            var Employee = await _db.EmployeeTbls.FindAsync(id);
            _db.EmployeeTbls.Remove(Employee);
            _db.SaveChanges();

        }

        public  IEnumerable<EmployeeTbl> GetAll()
        {
            var MyEmployeeList =  _db.EmployeeTbls.ToList();
            return MyEmployeeList; 
        }

        public  EmployeeTbl GetById(int id)
        {
            var TheEmp =  _db.EmployeeTbls.FindAsync(id);
            return TheEmp.Result;
        }

        public Task UpdateAsync(EmployeeTbl employee)
        {
            _db.EmployeeTbls.Update(employee);
            _db.SaveChanges();
            return Task.CompletedTask;
        }

        public async Task UpdateAsync(int id)
        {
            var Employee = await _db.EmployeeTbls.FindAsync(id);
            if(Employee != null)
            {
                 _db.EmployeeTbls.Update(Employee);
                _db.SaveChanges();
                _ = Task.CompletedTask;
            }
            else
            {
                //Task.FromException;
            }
        }
    }
}
