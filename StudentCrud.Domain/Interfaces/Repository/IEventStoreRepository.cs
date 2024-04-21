namespace StudentCrud.Domain.Interfaces.Repository
{
    public interface IEventStoreRepository
    {
        Task AddEventAsync(IEvent @event);
    }
}