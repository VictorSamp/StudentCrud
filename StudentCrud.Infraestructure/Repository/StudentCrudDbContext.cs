using Microsoft.EntityFrameworkCore;
using StudentCrud.Domain.Model;

namespace StudentCrud.Infraestructure.Repository
{
    public class StudentCrudDbContext : DbContext
    {
        private readonly string _connectionString = "Server=localhost;Database=StudentCrudWriteModelDb;User ID=studentcrud;Password=Senh4Fort3@360;";
        public DbSet<Student> Students { get; set; }

        public StudentCrudDbContext(DbContextOptions<StudentCrudDbContext> options) : base(options)
        { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }
    }
}