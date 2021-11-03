using Portfolio.DAL.Abstract;
using Portfolio.DAL.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.DAL.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        public void Add(T p)
        {
            using (var c = new Context())
            {
                c.Entry(p).State = EntityState.Added;
                c.SaveChanges();
            }
        }

        public void Delete(T p)
        {
            using (var c = new Context())
            {
                c.Entry(p).State = EntityState.Deleted;
                c.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (var c = new Context())
            {
                Delete(c.Set<T>().Find(id));
                c.SaveChanges();
            }
        }

        public T Get(Expression<Func<T, bool>> filter = null)
        {
            using (var c = new Context())
            {
                return filter == null ?
                    c.Set<T>().SingleOrDefault() :
                    c.Set<T>().SingleOrDefault(filter);
            }
        }

        public T Get(int id)
        {
            using (var c = new Context())
            {
                return c.Set<T>().Find(id);
            }
        }

        public List<T> List(Expression<Func<T, bool>> filter = null)
        {
            using (var c = new Context())
            {
                return filter == null ?
                    c.Set<T>().ToList() :
                    c.Set<T>().Where(filter).ToList();
            }
        }

        public void Update(T p)
        {
            using (var c = new Context())
            {
                c.Entry(p).State = EntityState.Modified;
                c.SaveChanges();
            }
        }
    }
}
