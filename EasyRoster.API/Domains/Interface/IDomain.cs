using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyRoster.API.Domains.Interface
{
    public interface IDomain<TEntity> where TEntity : class
    {
        void Delete(TEntity entityToDelete);
        TEntity GetByID(object id);
        void Insert(TEntity entity);
        void Update(TEntity entityToUpdate);
    }
}
