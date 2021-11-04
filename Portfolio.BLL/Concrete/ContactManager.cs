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
    public class ContactManager : IContactService
    {
        IContactDal _contactDal;
        IInformationDal _informatinDal;

        public ContactManager(IContactDal contactDal, IInformationDal informatinDal)
        {
            _contactDal = contactDal;
            _informatinDal = informatinDal;
        }

        public void Add(Contact p)
        {
            _contactDal.Add(p);
        }

        public void Delete(Contact p, int id)
        {
            if (id > 0)
            {
                _contactDal.Delete(id);
            }
            else
            {
                _contactDal.Delete(p);
            }
        }

        public Contact Get(int id)
        {
            return _contactDal.Get(id);
        }

        public Information GetAddress()
        {
            return _informatinDal.Get();
        }

        public List<Contact> List()
        {
            return _contactDal.List();
        }

        public void Update(Contact p)
        {
            _contactDal.Update(p);
        }
    }
}
