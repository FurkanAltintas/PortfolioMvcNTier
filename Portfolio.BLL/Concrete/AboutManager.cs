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
    public class AboutManager : IAboutService
    {
        IAboutDal _aboutDal;

        public AboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }

        public void Add(About p)
        {
            _aboutDal.Add(p);
        }

        public void Delete(int id)
        {
            _aboutDal.Delete(id);
        }

        public void Delete(About p)
        {
            _aboutDal.Delete(p);
        }

        public About Get(Expression<Func<About, bool>> filter = null)
        {
            return filter == null ?
                _aboutDal.Get() :
                _aboutDal.Get(filter);
        }

        public About Get(int id)
        {
            return _aboutDal.Get(id);
        }

        public List<About> List(Expression<Func<About, bool>> filter = null)
        {
            return filter == null ?
                _aboutDal.List() :
                _aboutDal.List(filter);
        }

        public void Update(About p)
        {
            _aboutDal.Update(p);
        }
    }
}
