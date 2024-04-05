using StudentCrud.Domain.Model;

namespace StudentCrud.Domain.Interfaces.Repository
{
    public interface IStudentRepository
    {
        void CreateStudent(Student student);
    }
}