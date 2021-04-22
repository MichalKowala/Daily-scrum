using DailyScrum.Model.Entities;
using System;
using System.Linq;

namespace DailyScrum.Model.Repositories
{
    public interface IRepository<T> where T:BaseEntity
    {
        void Create(T entity);
        void Delete(T entity);
        void Edit(T entity);
        void Delete(Guid id);
        T GetById(Guid id);
        IQueryable<T> GetAll();
        IQueryable<T> Filter(Func<T, bool> predicate);
    }
}
