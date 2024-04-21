using MediatR;
using StudentCrud.Domain.Events;

namespace StudentCrud.Domain.Interfaces.EventHandlers
{
    public interface IStudentCreatedEventHandler : INotificationHandler<StudentCreated>
    {
    }
}