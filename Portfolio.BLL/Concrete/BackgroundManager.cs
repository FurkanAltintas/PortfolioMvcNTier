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

        public void Delete(Background p, int id)
        {
            if (id > 0)
                _backgroundDal.Delete(id);
            else
                _backgroundDal.Delete(p);
        }

        public Background Get()
        {
            return _backgroundDal.Get();
        }

        public Background Get(int id)
        {
            return _backgroundDal.Get(id);
        }

        public List<Background> List()
        {
            return _backgroundDal.List();
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
