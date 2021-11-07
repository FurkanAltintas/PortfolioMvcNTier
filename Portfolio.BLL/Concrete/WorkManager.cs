using Portfolio.BLL.Abstract;
using Portfolio.DAL.Abstract;
using Portfolio.ENTITY.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.BLL.Concrete
{
    public class WorkManager : IWorkService
    {
        IWorkDal _workDal;

        public WorkManager(IWorkDal workDal)
        {
            _workDal = workDal;
        }

        public void Add(Work p)
        {
            _workDal.Add(p);
        }

        public void Delete(int id)
        {
            _workDal.Delete(id);
        }

        public void Delete(Work p)
        {
            _workDal.Delete(p);
        }

        public Work Get(Expression<Func<Work, bool>> filter = null)
        {
            return filter == null ?
                _workDal.Get() :
                _workDal.Get(filter);
        }

        public Work Get(int id)
        {
            return _workDal.Get(id);
        }

        public List<Work> List(Expression<Func<Work, bool>> filter = null)
        {
            return filter == null ?
                _workDal.List() :
                _workDal.List(filter);
        }

        public void Update(Work p)
        {
            _workDal.Update(p);
        }
    }
}
