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
    public class BackgroundManager : IBackgroundService
    {
        IBackgroundDal _backgroundDal;
        IDegreeDal _degreeDal;

        public BackgroundManager(IBackgroundDal backgroundDal, IDegreeDal degreeDal)
        {
            _backgroundDal = backgroundDal;
            _degreeDal = degreeDal;
        }

        public void Add(Background p)
        {
            _backgroundDal.Add(p);
        }

        public void Delete(int id)
        {
            _backgroundDal.Delete(id);
        }

        public void Delete(Background p)
        {
            _backgroundDal.Delete(p);
        }

        public Background Get(Expression<Func<Background, bool>> filter = null)
        {
            return filter == null ?
                _backgroundDal.Get() :
                _backgroundDal.Get(filter);
        }

        public Background Get(int id)
        {
            return _backgroundDal.Get(id);
        }

        public List<Background> List(Expression<Func<Background, bool>> filter = null)
        {
            return filter == null ?
                _backgroundDal.List() :
                _backgroundDal.List(filter);
        }

        public List<Degree> ListDegree()
        {
            return _degreeDal.List();
        }

        public void Update(Background p)
        {
            _backgroundDal.Update(p);
        }
    }
}
