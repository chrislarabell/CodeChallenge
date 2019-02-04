namespace CodeChallenge.Infrastructure.Data
{
    using CodeChallenge.Core.Interfaces;
    using CodeChallenge.Core.SharedKernel;
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class EfRepository : IRepository<BaseEntity, int>
    {
        private readonly AppDbContext _dbContext;

        public EfRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public BaseEntity Add(BaseEntity entity)
        {
            _dbContext.Set<BaseEntity>().Add(entity);
            _dbContext.SaveChanges();

            return entity;
        }

        public void Delete(BaseEntity entity)
        {
            _dbContext.Set<BaseEntity>().Remove(entity);
            _dbContext.SaveChanges();
        }

        public BaseEntity Get(int id)
        {
            return _dbContext.Set<BaseEntity>().SingleOrDefault(e => e.Id == id);
        }

        public IEnumerable<BaseEntity> GetAll()
        {
            return _dbContext.Set<BaseEntity>().AsEnumerable();
        }

        public Task<IEnumerable<BaseEntity>> GetAllAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<BaseEntity> GetAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Update(BaseEntity entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
            _dbContext.SaveChanges();
        }
    }
}
