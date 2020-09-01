using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ReziRoster.API.Models;

namespace ReziRoster.API.Domains.Interface
{
    public interface IEventDomain
    {
        void Delete(Event entityToDelete);
        Event GetByID(object id);
        void Insert(Event entity);
        void Update(Event entityToUpdate);
    }
}
