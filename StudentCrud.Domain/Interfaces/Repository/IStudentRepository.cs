using StudentCrud.Domain.Model;

namespace StudentCrud.Domain.Interfaces.Repository
{
    public interface IStudentRepository
    {
        Task<Student> GetStudentByEmail(string email);

        Task CreateStudent(Student student);
    }
}