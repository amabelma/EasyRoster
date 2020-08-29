using EasyRoster.API.Domains.Interface;
using System;

namespace EasyRoster.API.Domains
{
    public class BaseDomain<TEntity> : IDomain<TEntity> where TEntity : class
    {
        public void Delete(TEntity entityToDelete) { throw new NotImplementedException(); }
        public TEntity GetByID(object id) { throw new NotImplementedException(); }
        public void Insert(TEntity entity) { throw new NotImplementedException(); }
        public void Update(TEntity entityToUpdate) { throw new NotImplementedException(); }
    }
}
