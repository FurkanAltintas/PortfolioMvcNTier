using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.ENTITY.Concrete
{
    public class Background
    {
        [Key]
        public int Id { get; set; }
        public string Image { get; set; }
    }
}
