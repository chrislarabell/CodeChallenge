namespace CodeChallenge.Core.Interfaces
{
    using CodeChallenge.Core.SharedKernel;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IRepository<TEntity, TKey>
    {
        Task<TEntity> GetAsync(TKey id);
        Task<IEnumerable<TEntity>> GetAllAsync();
        TEntity Get(TKey id);
        IEnumerable<TEntity> GetAll();
        TEntity Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
    }
}
