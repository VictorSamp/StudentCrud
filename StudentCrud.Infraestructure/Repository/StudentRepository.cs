using Microsoft.EntityFrameworkCore;
using StudentCrud.Domain.Interfaces.Repository;
using StudentCrud.Domain.Events;

namespace StudentCrud.Infraestructure.Repository
{
    public class StudentRepository : IStudentRepository
    {
        private readonly StudentCrudReadModelContext _readModelContext;

        public StudentRepository(StudentCrudReadModelContext studentCrudContext)
        {
            _readModelContext = studentCrudContext;
        }

        public async Task<Student> GetStudentByEmail(string email)
        {
            return await _readModelContext.Students.FirstAsync(x => x.Email == email);
        }

        public async Task Save(Student student)
        {
            await _readModelContext.Students.AddAsync(student);
            await _readModelContext.SaveChangesAsync();
        }
    }
}