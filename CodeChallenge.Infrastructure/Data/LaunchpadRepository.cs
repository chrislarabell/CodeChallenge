namespace CodeChallenge.Infrastructure.Data
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using CodeChallenge.Core.Interfaces;
    using CodeChallenge.Core.Entities;
    using CodeChallenge.Infrastructure.ExternalServices;

    public class LaunchpadRepository : IRepository<Launchpad, string>
    {

        private readonly IRestExternalService<Launchpad, string> _restExternalService;

        public  LaunchpadRepository(IRestExternalService<Launchpad, string> restDatasource)
        {
            _restExternalService = restDatasource;
        }

        public async Task<Launchpad> GetAsync(string id)
        {
            return await _restExternalService.GetAsync(id);
        }

        public async Task<IEnumerable<Launchpad>> GetAllAsync()
        {
            return await _restExternalService.GetAllAsync();
        }

        public Launchpad Get(string id)
        {
            return _restExternalService.Get(id);
        }

        public IEnumerable<Launchpad> GetAll()
        {
            return _restExternalService.GetAll();
        }

        public Launchpad Add(Launchpad entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Launchpad entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Launchpad entity)
        {
            throw new NotImplementedException();
        }
    }
}
