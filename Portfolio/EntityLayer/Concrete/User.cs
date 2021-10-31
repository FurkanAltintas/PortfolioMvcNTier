using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.ENTITY.Concrete
{
    public class User : BaseEntity
    {
        [Key]
        public int Id { get; set; }
        public int AuthorityId { get; set; }
        [ForeignKey("AuthorityId")]
        public Authority Authority { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public virtual string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
