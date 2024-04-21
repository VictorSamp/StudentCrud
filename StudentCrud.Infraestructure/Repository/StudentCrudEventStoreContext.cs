using Microsoft.EntityFrameworkCore;
using StudentCrud.Domain.Events;

namespace StudentCrud.Infraestructure.Repository
{
    public class StudentCrudEventStoreContext : DbContext
    {
        public DbSet<Event> Events { get; set; }

        public StudentCrudEventStoreContext(DbContextOptions<StudentCrudEventStoreContext> options) : base(options)
        { }
    }
}