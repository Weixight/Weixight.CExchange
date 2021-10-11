using Weixight.CExchange.Persistence;
using Weixight.CExchange.Service.IRepositotory.IProduce;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//using Weixight.CExchange.Service.IRepositotory.IProduce;
using Weixight.CExchange.Service.Repository.Produce;

namespace Weixight.CExchange.Service
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private ApplicationDbContext _applicationDbContext;
        private ICartegory _cartegory;
        //private INextOfKin _nextofKin;
        //private IDegree _degree;
        //private IProcert _procert;
        //private IWorkExp _workExp;
        //private IChildren _children;
        //private IRefrence _refrence;
        //private IGarantor _garantor;

        public ICartegory cartegory
        {
            get
            {
                if (_cartegory == null)
                {
                    _cartegory = new CartegoryRepository(_applicationDbContext);

                }
                return _cartegory;
            }



        }

        //public INextOfKin nextofKin
        //{
        //    get
        //    {
        //        if (_nextofKin == null)
        //        {
        //            _nextofKin = new NexOfKinRepository(_applicationDbContext);

        //        }
        //        return _nextofKin; 
        //    }
        //}

        //public IDegree degree
        //{
        //    get
        //    {
        //        if (_degree == null)
        //        {
        //            _nextofKin = new NexOfKinRepository(_applicationDbContext);

        //        }
        //        return _degree;
        //    }
        //}

        //public IDegree degree
        //{
        //    get
        //   {
        //       if (_degree == null)
        //       {
        //            _degree = new DegreeRepository(_applicationDbContext);

        //           }
        //           return _degree;
        //   }

        //}

        //public IProcert procert
        //{
        //    get
        //    {
        //        if (_procert == null)
        //        {
        //            _procert = new ProcertRepositoy(_applicationDbContext);

        //        }
        //        return _procert;
        //    }

        //}

        //public IWorkExp workExp
        //{
        //    get
        //    {
        //        if (_workExp == null)
        //        {
        //            _workExp = new WorkExRepository(_applicationDbContext);

        //        }
        //        return _workExp;
        //    }

        //}

        //public IChildren children
        //{
        //    get
        //    {
        //        if (_children == null)
        //        {
        //            _children = new ChildrenRepository(_applicationDbContext);

        //        }
        //        return _children;
        //    }

        //}

        //public IRefrence  refrence
        //{
        //    get
        //    {
        //        if (_refrence == null)
        //        {
        //            _refrence = new RefernceRepository(_applicationDbContext);

        //        }
        //        return _refrence;
        //    }

        //}
        //public IGarantor garantor
        //{
        //    get
        //    {
        //        if (_garantor == null)
        //        {
        //            _garantor = new GarantorRepository(_applicationDbContext);

        //        }
        //        return _garantor;
        //    }
        //}


        public RepositoryWrapper(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public int Save()
        {
          var RecCount =  _applicationDbContext.SaveChanges();
            return RecCount;
        }
    }
}
