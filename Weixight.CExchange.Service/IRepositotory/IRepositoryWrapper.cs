using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Weixight.CExchange.Service.IRepositotory.IProduce;

namespace Weixight.CExchange.Service
{
    public interface IRepositoryWrapper
    {
        ICartegory cartegory { get; }
       //INextOfKin nextofKin { get; }
       //IDegree degree { get; }
       //IProcert procert { get;  }
       //IWorkExp workExp { get; }
       //IChildren children { get; }
       //IRefrence refrence { get; }
       //IGarantor garantor { get; }
        int Save();
    }
}
