using Weixight.CExchange.Persistence;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace Weixight.CExchange.Service.Interface
{
    public interface IUnitOfWork<out TContext>
        where TContext : ApplicationDbContext, new()
    {
        TContext Context { get; }
        void CreateTransaction();
        void Commit();
        void Rollback();
        void Save();
    }
}
