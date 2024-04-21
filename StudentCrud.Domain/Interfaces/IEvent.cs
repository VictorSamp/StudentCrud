namespace StudentCrud.Domain.Interfaces
{
    public interface IEvent
    {
        Guid Id { get; }
        DateTime Timestamp { get; }
        string AggregateId { get; }
        string EventType { get; }
        string EventData { get; }
    }
}