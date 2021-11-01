using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.BLL.Abstract
{
    public interface IGenericService<T>
    {
        List<T> List();

        T Get(int id);

        void Add(T p);

        void Update(T p);

        void Delete(T p, int id);
    }
}
