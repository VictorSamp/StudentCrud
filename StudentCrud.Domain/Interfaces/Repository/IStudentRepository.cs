using StudentCrud.Domain.Events;

namespace StudentCrud.Domain.Interfaces.Repository
{
    public interface IStudentRepository
    {
        Task<Student> GetStudentByEmail(string email);

        Task Save(Student student);
    }
}