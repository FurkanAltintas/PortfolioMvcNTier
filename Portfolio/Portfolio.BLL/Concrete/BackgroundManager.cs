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
    public class BackgroundManager : IGenericService<Background>
    {
        IBackgroundDal _backgroundDal;

        public BackgroundManager(IBackgroundDal backgroundDal)
        {
            _backgroundDal = backgroundDal;
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

        public Background Get(int id)
        {
            return _backgroundDal.Get(id);
        }

        public List<Background> List()
        {
            return _backgroundDal.List();
        }

        public void Update(Background p)
        {
            _backgroundDal.Update(p);
        }
    }
}
