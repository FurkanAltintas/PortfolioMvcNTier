using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class BaseEntity
    {
        public DateTime CreateDate { get; set; }
        public bool IsActive { get; set; }
    }
}
