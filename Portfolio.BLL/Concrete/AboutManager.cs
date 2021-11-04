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

        public void Delete(About p, int id)
        {
            if (id > 0)
                _aboutDal.Delete(id);
            else
                _aboutDal.Delete(p);
        }

        public About Get()
        {
            return _aboutDal.Get();
        }

        public About Get(int id)
        {
            return _aboutDal.Get(id);
        }

        public List<About> List()
        {
            return _aboutDal.List();
        }

        public void Update(About p)
        {
            _aboutDal.Update(p);
        }
    }
}
