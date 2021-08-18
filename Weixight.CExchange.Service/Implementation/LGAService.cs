using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Weixight.CExchange.Entity;
using Weixight.CExchange.Service.Interface;
using Weixight.CExchange.Persistence;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Weixight.CExchange.Service.Implementation
{
    public class LGAService : ILGA
    {
        private readonly ApplicationDbContext _db;
        public LGAService(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task CreateAsync(lga NewLga)
        {
            await _db.Lga.AddAsync(NewLga);
            await _db.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var Lga = GetById(id);
            _db.Remove(Lga);
            await _db.SaveChangesAsync();
        }

        public IEnumerable<lga> GetAll()
        {
           var LgaList = _db.Lga.AsNoTracking().OrderBy(emp => emp.lga_name);
            return LgaList;
        }

        public lga GetById(int id)
        {
          var lga =   _db.Lga.Where(e => e.lga_id == id).FirstOrDefault();
            return lga;
        }

        public async Task UpdateAsync(lga Lga)
        {
            _db.Update(Lga);
            await _db.SaveChangesAsync();
        }

        public async Task UpdateAsync(int id)
        {
            var Lga = GetById(id);
            _db.Update(Lga);
            await _db.SaveChangesAsync();
        }
    }
}
