using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;
using Weixight.CExchange.Entity.Model;
using Weixight.CExchange.Persistence;

namespace Weixight.CExchange.Service.Implementation
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly IDbContext _context;
        private IDbSet<T> _entities;

        public Repository(IDbContext context)
        {
            this._context = context;
        }

    }
}
