using Portfolio.ENTITY.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.DAL.Concrete
{
    public class Context : DbContext
    {
        public DbSet<About> Abouts { get; set; }
        public DbSet<Authority> Authorities { get; set; }
        public DbSet<Background> Backgrounds { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Degree> Degrees { get; set; }
        public DbSet<Information> Informations { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Work> Works { get; set; }
    }
}
