
using Microsoft.EntityFrameworkCore;
using Project.Models.Domain;

namespace Project.Data
{
    public class MVCDemodbcontext : DbContext
    {
        private DbSet<contact> myProperty;

        public MVCDemodbcontext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<contact> contact { get; set; }
    }
}
