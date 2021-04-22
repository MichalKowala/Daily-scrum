using AutoMapper;
using DailyScrum.Model.Entities;
using DailyScrum.Model.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DailyScrum.Infrastructure
{

    public interface ILoadEntity<T>
    {
        Task<List<T>> LoadAsync();
    }

    public class LoadEntity<T> where T : BaseEntity, ILoadEntity<T>
    {
        private readonly IRepository<T> _repository;

        public LoadEntity(IRepository<T> repository)
        {
            _repository = repository;
        }
       
        public Task<List<T>> LoadAsync()
            => _repository.GetAll().ToListAsync();
    }

    public interface IModelMapper<T>
    {
        Task<List<T>> MapAsync();
    }

    public class ModelMapper<TEntity, TModel> : IModelMapper<TModel>
    {
        private readonly IMapper _mapper;
        private readonly ILoadEntity<TEntity> _loadEntity;

        public ModelMapper(IMapper mapper, ILoadEntity<TEntity> loadEntity)
        {
            _mapper = mapper;
            _loadEntity = loadEntity;
        }
       
        public async Task<List<TModel>> MapAsync()
        {
            var entities = await _loadEntity.LoadAsync();
            return _mapper.Map<List<TModel>>(entities);
        }
    }
}
