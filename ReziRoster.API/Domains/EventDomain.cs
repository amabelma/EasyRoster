using ReziRoster.API.Context;
using ReziRoster.API.Domains.Interface;
using ReziRoster.API.Models;
using ReziRoster.API.Repositories;

namespace ReziRoster.API.Domains
{
    public class EventDomain : IEventDomain
    {
        public EventDomain(EventContext context)
        {
            _context = context;
            _repository = new EventRepository(_context);
        }

        public void Delete(Event entityToDelete)
        {
            _repository.Delete(entityToDelete);
        }

        public Event GetByID(object id)
        {
            return _repository.GetByID(id);
        }

        //public Event GetByName(string EventName)
        //{
            //Pass in WHERE clause as a lambda here
        //    List<Event> _eventsWithName = _repository.Get( e => e.Name == EventName).ToList();
        //    return 
        //}

        public void Insert(Event entity)
        {
            _repository.Insert(entity);
        }

        public void Update(Event entityToUpdate)
        {
            _repository.Update(entityToUpdate);
        }

        private readonly EventContext _context;
        private readonly EventRepository _repository;
    }
}
