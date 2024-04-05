using StudentCrud.Domain.Commands;

namespace StudentCrud.Domain.Interfaces.CommandHandlers
{
    public interface ICreateStudentCommandHandler
    {
        void Handle(CreateStudent command);
    }
}