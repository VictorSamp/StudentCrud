using StudentCrud.Domain.Commands;
using StudentCrud.Domain.Interfaces.CommandHandlers;
using StudentCrud.Domain.Interfaces.Repository;
using StudentCrud.Domain.Model;

namespace StudentCrud.Domain.CommandHandlers
{
    public class CreateStudentCommandHandler : ICreateStudentCommandHandler
    {
        private readonly IStudentRepository _studentRepository;

        public CreateStudentCommandHandler(IStudentRepository repository)
        {
            _studentRepository = repository;
        }

        public void Handle(CreateStudent command)
        {
            //Verifica se o e-mail já existe no banco

            //Se sim, emita um aviso de que já existe

            //Se não, adicione o student no banco
            var student = new Student(command.FullName, command.Email);

            _studentRepository.CreateStudent(student);
        }
    }
}