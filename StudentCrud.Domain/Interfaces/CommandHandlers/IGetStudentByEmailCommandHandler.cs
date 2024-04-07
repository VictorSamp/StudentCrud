using MediatR;
using StudentCrud.Domain.Dtos.Responses;
using StudentCrud.Domain.Queries;

namespace StudentCrud.Domain.Interfaces.CommandHandlers
{
    public interface IGetStudentByEmailCommandHandler : IRequestHandler<GetStudentByEmail, GetStudentByEmailResponseDto>
    {
    }
}