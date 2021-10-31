using Portfolio.ENTITY.Concrete;
using Portfolio.DAL.Abstract;
using Portfolio.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.DAL.EntityFramework
{
    public class EfUserRepository : GenericRepository<User>, IUserDal
    {
    }
}
