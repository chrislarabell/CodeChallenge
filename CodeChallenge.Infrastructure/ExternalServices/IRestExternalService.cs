namespace CodeChallenge.Infrastructure.ExternalServices
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    public interface IRestExternalService<TEntity, TKey>
    {
        Task<TEntity> GetAsync(TKey id);

        TEntity Get(TKey id);

        Task<IEnumerable<TEntity>> GetAllAsync();

        IEnumerable<TEntity> GetAll();
    }
}
