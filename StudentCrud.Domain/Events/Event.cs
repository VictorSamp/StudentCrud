using MediatR;
using StudentCrud.Domain.Interfaces;

namespace StudentCrud.Domain.Events
{
    public class Event : IEvent, INotification
    {
        public Guid Id { get; init; }

        public DateTime Timestamp { get; init; }

        public string AggregateId { get; init; }

        public string EventType { get; init; }

        public string EventData { get; init; }

        public Event()
        {
            Id = Guid.NewGuid();
            Timestamp = DateTime.UtcNow;
        }
    }
}