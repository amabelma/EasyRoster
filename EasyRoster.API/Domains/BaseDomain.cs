using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EasyRoster.API.Domains.Interface;

namespace EasyRoster.API.Domains
{
    public class BaseDomain<TEntity> : IDomain<TEntity> where TEntity : class
    {
        public void Delete(TEntity entityToDelete);
        public TEntity GetByID(object id);
        public void Insert(TEntity entity);
        public void Update(TEntity entityToUpdate);
    }
}
