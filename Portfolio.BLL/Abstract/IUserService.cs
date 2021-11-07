using Portfolio.ENTITY.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.BLL.Abstract
{
    public interface IUserService : IGenericService<User>
    {
        bool User(string email, string password);
    }
}
