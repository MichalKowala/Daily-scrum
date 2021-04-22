using DailyScrum.Infrastructure.DatabaseContext;
using DailyScrum.Model.Entities;
using DailyScrum.Model.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DailyScrum.Infrastructure.Repositories
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly DailyScrumDbContext _dbContext;
        public Repository(DailyScrumDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void Create(T entity)
        {
            _dbContext.Set<T>().Add(entity);
            _dbContext.SaveChanges();
        }

        public void Delete(T entity)
        {

            _dbContext.Set<T>().Remove(entity);
            _dbContext.SaveChanges();
        }

        public void Delete(Guid id)
        {

            var recordToRemove = GetById(id);
            _dbContext.Remove(recordToRemove);
            _dbContext.SaveChanges();
        }

        public void Edit(T entity)
        {
            _dbContext.Set<T>().Update(entity);
            _dbContext.SaveChanges();
        }

        public IQueryable<T> Filter(Func<T, bool> predicate)
        {
            return _dbContext.Set<T>().Where(predicate).AsQueryable();
        }

        public IQueryable<T> GetAll()
        {
            return _dbContext.Set<T>();
        }

        public T GetById(Guid id)
        {
            return _dbContext.Set<T>().Find(id);
        }
    }
}
