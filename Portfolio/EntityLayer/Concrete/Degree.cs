using Portfolio.ENTITY.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.ENTITY.Concrete
{
    public class Degree : BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
