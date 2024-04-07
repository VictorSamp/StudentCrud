using MediatR;
using StudentCrud.Domain.Commands;

namespace StudentCrud.Domain.Interfaces.CommandHandlers
{
    public interface ICreateStudentCommandHandler : IRequestHandler<CreateStudent>
    {
    }
}