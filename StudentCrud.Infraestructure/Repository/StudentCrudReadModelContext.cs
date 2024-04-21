using Microsoft.EntityFrameworkCore;
using StudentCrud.Domain.Events;

namespace StudentCrud.Infraestructure.Repository
{
    public class StudentCrudReadModelContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        public StudentCrudReadModelContext(DbContextOptions<StudentCrudReadModelContext> options) : base(options)
        { }
    }
}