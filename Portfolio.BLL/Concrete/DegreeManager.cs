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
    public class DegreeManager : IDegreeService
    {
        IDegreeDal _degreeDal;

        public DegreeManager(IDegreeDal degreeDal)
        {
            _degreeDal = degreeDal;
        }

        public void Add(Degree p)
        {
            _degreeDal.Add(p);
        }

        public void Delete(int id)
        {
            _degreeDal.Delete(id);
        }

        public void Delete(Degree p)
        {
            _degreeDal.Delete(p);
        }

        public Degree Get(Expression<Func<Degree, bool>> filter = null)
        {
            return filter == null ?
                _degreeDal.Get() :
                _degreeDal.Get(filter);
        }

        public Degree Get(int id)
        {
            return _degreeDal.Get(id);
        }

        public List<Degree> List(Expression<Func<Degree, bool>> filter = null)
        {
            return filter == null ?
                 _degreeDal.List() :
                 _degreeDal.List(filter);
        }

        public void Update(Degree p)
        {
            _degreeDal.Update(p);
        }
    }
}
