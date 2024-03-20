using Microsoft.EntityFrameworkCore;

namespace flutterapi.Models
{
    public class apidbcontext : DbContext
    {
        // Constructor to pass options to DbContext base class
        public apidbcontext(DbContextOptions<apidbcontext> options) : base(options)
        {
        }

        // DbSet property for User entity
        public DbSet<user> Users { get; set; }
    }
}
