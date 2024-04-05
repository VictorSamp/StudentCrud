using Microsoft.EntityFrameworkCore;
using StudentCrud.Domain.Interfaces.Repository;
using StudentCrud.Domain.Model;

namespace StudentCrud.Infraestructure.Repository
{
    public class StudentRepository : IStudentRepository
    {
        private readonly DbContext _dbContext;

        public StudentRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void CreateStudent(Student student)
        {
            _dbContext.Add(student);
        }
    }
}