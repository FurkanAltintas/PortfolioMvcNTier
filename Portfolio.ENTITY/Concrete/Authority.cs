using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.ENTITY.Concrete
{
    public class Authority : BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<User> User { get; set; }
    }
}
