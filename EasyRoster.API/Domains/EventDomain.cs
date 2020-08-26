using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EasyRoster.API.Domains.Interface;
using EasyRoster.API.Models;
using EasyRoster.API.Repositories;

namespace EasyRoster.API.Domains
{
    public class EventDomain : IEventDomain
    {
        private EventRepository _repository;

        public EventDomain()
        {
            //I believe I need to pass in context here?
            _repository = new EventRepository();
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
    }
}
