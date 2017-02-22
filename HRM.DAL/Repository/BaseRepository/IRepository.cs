using HRM.DAL;
using System.Collections.Generic;

namespace HRM.DAL
{
   public interface IRepository<TEntity> where TEntity : class
    {
        IUnitOfWork UnitOfWork { get; }
        TEntity Get(int id);
        IEnumerable<TEntity> GetAll();
        void Add(TEntity entity);
        void AddRange(IEnumerable<TEntity> entities);
        void RemoveStatus(TEntity entity);
        void RemoveRange(IEnumerable<TEntity> entities);

    }
}
