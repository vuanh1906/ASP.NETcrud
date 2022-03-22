using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using CourseMan.Models;

namespace CourseMan.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<CourseMan.Models.Instructor> Instructor { get; set; }
        public DbSet<CourseMan.Models.Student> Student { get; set; }
    }
}