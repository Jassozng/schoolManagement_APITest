using Microsoft.EntityFrameworkCore;

namespace StudentsAPI_Test.Models
{
    public class IdentityModels
    {
        public class ApplicationDbContext : DbContext
        {
            public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
                : base(options)
            { }

            public DbSet<User> User { get; set; }
            public DbSet<Teacher> Teacher { get; set; }
            public DbSet<Coordinator> Coordinator { get; set; }
            public DbSet<Student> Student { get; set; }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {

                base.OnModelCreating(modelBuilder);
            }
        }
    }
}
