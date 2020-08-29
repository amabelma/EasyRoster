using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EasyRoster.API.Domains.Interface;
using EasyRoster.API.Models;
using EasyRoster.API.Repositories;
using Microsoft.EntityFrameworkCore;

namespace EasyRoster.API.Domains
{
    public class EventDomain : IEventDomain
    {
        private EventRepository _repository;
        // ToDo: figure out whether we need to set this context options here, or pass in context in.
        private DbContext _context;

        public EventDomain()
        {
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
    }
}
