using Microsoft.EntityFrameworkCore;
using StudentCrud.Domain.Interfaces.Repository;
using StudentCrud.Domain.Model;

namespace StudentCrud.Infraestructure.Repository
{
    public class StudentRepository : IStudentRepository
    {
        private readonly StudentCrudDbContext _studentCrudContext;

        public StudentRepository(StudentCrudDbContext studentCrudContext)
        {
            _studentCrudContext = studentCrudContext;
        }

        public async Task<Student> GetStudentByEmail(string email)
        {
            return await _studentCrudContext.Students.FirstAsync(x => x.Email == email);
        }

        public async Task CreateStudent(Student student)
        {
            await _studentCrudContext.Students.AddAsync(student);
            await _studentCrudContext.SaveChangesAsync();
        }
    }
}