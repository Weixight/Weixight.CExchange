using Weixight.CExchange.Persistence;
using Weixight.CExchange.Service.IRepositotory.IProduce;
using OurHr.Models.IRepositotory;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Weixight.CExchange.Service.Interface;

namespace Weixight.CExchange.Service
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected ApplicationDbContext RepositoryContext { get; set; }
        private string _errorMessage = string.Empty;
        private bool _isDisposed;
        //public RepositoryBase(IUnitOfWork<ApplicationDbContext> unitOfWork)
        //   : this(unitOfWork.Context)
        //{

        //}
        public RepositoryBase(ApplicationDbContext repositoryContext)
        {
            this.RepositoryContext = repositoryContext;
            _isDisposed = false;
        }
        public IQueryable<T> FindAll()
        {
            return this.RepositoryContext.Set<T>().AsNoTracking();
        }
        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression)
        {
            return this.RepositoryContext.Set<T>().Where(expression).AsNoTracking();
        }
        public void Create(T entity)
        {
            this.RepositoryContext.Set<T>().Add(entity);
        }
        public void Update(T entity)
        {
            this.RepositoryContext.Set<T>().Update(entity);
        }
        public void Delete(T entity)
        {
            this.RepositoryContext.Set<T>().Remove(entity);
        }

       
    }
}
