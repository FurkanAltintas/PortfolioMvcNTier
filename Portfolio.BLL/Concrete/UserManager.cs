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
    public class UserManager : IUserService
    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public void Add(User p)
        {
            _userDal.Add(p);
        }


        public void Delete(int id)
        {
            _userDal.Delete(id);
        }

        public void Delete(User p)
        {
            _userDal.Delete(p);
        }

        public User Get(Expression<Func<User, bool>> filter = null)
        {
            return filter == null ?
                _userDal.Get() :
                _userDal.Get(filter);
        }

        public User Get(int id)
        {
            return _userDal.Get(id);
        }

        public List<User> List(Expression<Func<User, bool>> filter = null)
        {
            return filter == null ?
                _userDal.List() :
                _userDal.List(filter);
        }

        public void Update(User p)
        {
            _userDal.Update(p);
        }

        public bool User(string email, string password)
        {
            var user = _userDal.Get(x => x.Email == email & x.Password == password & x.IsActive == true);
            if (user != null)
                return true;
            else
                return false;
        }
    }
}
