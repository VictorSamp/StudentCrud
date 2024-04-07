using Microsoft.EntityFrameworkCore;
using StudentCrud.Domain.Model;

namespace StudentCrud.Infraestructure.Repository
{
    public class StudentCrudDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        public StudentCrudDbContext(DbContextOptions<StudentCrudDbContext> options) : base(options)
        { }
    }
}