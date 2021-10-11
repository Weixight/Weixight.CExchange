using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Weixight.CExchange.AgricGator.Models.IRepository.IProduce;

namespace Weixight.CExchange.AgricGator.Models.IRepository
{
   public interface IRepositoryWrapper
    {
        ICartegory cartegory { get; }

        int Save();
    }
}
