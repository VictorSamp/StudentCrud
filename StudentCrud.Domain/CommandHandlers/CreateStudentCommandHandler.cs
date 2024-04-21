using MediatR;
using StudentCrud.Domain.Commands;
using StudentCrud.Domain.Interfaces.Repository;
using StudentCrud.Domain.Events;

namespace StudentCrud.Domain.CommandHandlers
{
    public class CreateStudentCommandHandler : IRequestHandler<CreateStudent>
    {
        private readonly IEventStoreRepository _eventStoreRepository;
        private readonly IMediator _mediator;

        public CreateStudentCommandHandler(IMediator mediator, IEventStoreRepository eventStoreRepository)
        {
            _mediator = mediator;
            _eventStoreRepository = eventStoreRepository;
        }

        public async Task Handle(CreateStudent request, CancellationToken cancellationToken)
        {
            //TODO: Adicionar validação caso já exista
            var student = new Student(request.FullName, request.Email);

            var @event = new StudentCreated(student);

            await _eventStoreRepository.AddEventAsync(@event);
            await _mediator.Publish(@event, cancellationToken);
        }
    }
}