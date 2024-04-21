using StudentCrud.Domain.Interfaces;
using StudentCrud.Domain.Interfaces.Repository;

namespace StudentCrud.Infraestructure.Repository
{
    public class EventStoreRepository : IEventStoreRepository
    {
        private readonly StudentCrudEventStoreContext _eventStoreContext;

        public EventStoreRepository(StudentCrudEventStoreContext eventStoreContext)
        {
            _eventStoreContext = eventStoreContext;
        }

        public async Task AddEventAsync(IEvent @event)
        {
            await _eventStoreContext.AddAsync(@event);
            await _eventStoreContext.SaveChangesAsync();
        }
    }
}