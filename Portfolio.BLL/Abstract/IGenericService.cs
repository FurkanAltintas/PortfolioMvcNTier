using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.BLL.Abstract
{
    public interface IGenericService<T>
    {
        List<T> List(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter = null);

        T Get(int id);

        void Add(T p);
        void Update(T p);
        void Delete(int id);
        void Delete(T p);
    }
}
