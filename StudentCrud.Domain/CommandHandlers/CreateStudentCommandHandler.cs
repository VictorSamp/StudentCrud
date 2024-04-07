using MediatR;
using StudentCrud.Domain.Commands;
using StudentCrud.Domain.Interfaces.Repository;
using StudentCrud.Domain.Model;

namespace StudentCrud.Domain.CommandHandlers
{
    public class CreateStudentCommandHandler : IRequestHandler<CreateStudent>
    {
        private readonly IStudentRepository _studentRepository;

        public CreateStudentCommandHandler(IStudentRepository repository)
        {
            _studentRepository = repository;
        }

        public async Task Handle(CreateStudent request, CancellationToken cancellationToken)
        {
            var student = new Student(request.FullName, request.Email);

            await _studentRepository.CreateStudent(student);
        }
    }
}