using StudentCrud.Domain.Model;

namespace StudentCrud.Domain.Interfaces.Repository
{
    public interface IStudentRepository
    {
        Task CreateStudent(Student student);
    }
}