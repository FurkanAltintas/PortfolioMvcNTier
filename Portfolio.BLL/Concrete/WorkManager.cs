using Portfolio.BLL.Abstract;
using Portfolio.DAL.Abstract;
using Portfolio.ENTITY.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public void Delete(Work p, int id)
        {
            if (id > 0)
                _workDal.Delete(id);
            else
                _workDal.Delete(p);
        }

        public Work Get(int id)
        {
            return _workDal.Get(id);
        }

        public List<Work> List()
        {
            return _workDal.List();
        }

        public void Update(Work p)
        {
            _workDal.Update(p);
        }
    }
}
