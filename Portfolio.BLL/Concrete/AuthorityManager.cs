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
    public class AuthorityManager : IAuthorityService
    {
        IAuthorityDal _authorityDal;

        public AuthorityManager(IAuthorityDal authorityDal)
        {
            _authorityDal = authorityDal;
        }

        public void Add(Authority p)
        {
            _authorityDal.Add(p);
        }

        public void Delete(int id)
        {
            _authorityDal.Delete(id);
        }

        public void Delete(Authority p)
        {
            _authorityDal.Delete(p);
        }

        public Authority Get(Expression<Func<Authority, bool>> filter = null)
        {
            return filter == null ?
                _authorityDal.Get() :
                _authorityDal.Get(filter);
        }

        public Authority Get(int id)
        {
            return _authorityDal.Get(id);
        }

        public List<Authority> List(Expression<Func<Authority, bool>> filter = null)
        {
            return filter == null ?
                _authorityDal.List() :
                _authorityDal.List(filter);
        }

        public void Update(Authority p)
        {
            _authorityDal.Update(p);
        }
    }
}
