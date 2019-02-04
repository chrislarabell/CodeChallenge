namespace CodeChallenge.Core.SharedKernel
{
    using CodeChallenge.Core.Interfaces;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    class BaseRepository : IRepository<IEntity, int>
    {
        public IEntity Add(IEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(IEntity entity)
        {
            throw new NotImplementedException();
        }

        public IEntity Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<IEntity>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEntity> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(IEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
