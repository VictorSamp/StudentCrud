using StudentCrud.Domain.Dtos.Responses;
using StudentCrud.Domain.Interfaces.CommandHandlers;
using StudentCrud.Domain.Interfaces.Repository;
using StudentCrud.Domain.Queries;

namespace StudentCrud.Domain.CommandHandlers
{
    public class GetStudentByEmailCommandHandler : IGetStudentByEmailCommandHandler
    {
        private readonly IStudentRepository _studentRepository;

        public GetStudentByEmailCommandHandler(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public async Task<GetStudentByEmailResponseDto> Handle(GetStudentByEmail request, CancellationToken cancellationToken)
        {
            var student = await _studentRepository.GetStudentByEmail(request.Email);

            return new GetStudentByEmailResponseDto(student);
        }
    }
}