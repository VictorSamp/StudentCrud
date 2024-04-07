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

        public void CreateStudent(Student student)
        {
            _studentCrudContext.Add(student);
            _studentCrudContext.SaveChanges();
        }
    }
}