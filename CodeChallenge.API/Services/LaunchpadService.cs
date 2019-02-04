using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CodeChallenge.API.Models;
using CodeChallenge.Core.Entities;
using CodeChallenge.Core.Interfaces;

namespace CodeChallenge.API.Services
{
    public class LaunchpadService : ILaunchpadService
    {
        private readonly IRepository<Launchpad, string> _launchpadRepoistory;
        private readonly IMapper _mapper;

        public LaunchpadService(IRepository<Launchpad, string> launchpadRepository, IMapper mapper)
        {
            _launchpadRepoistory = launchpadRepository;
            _mapper = mapper;
        }
        public async Task<IEnumerable<LaunchpadDto>> GetAllLaunchpadsAsync()
        {
            var launchpads = await _launchpadRepoistory.GetAllAsync();

            return _mapper.Map<IEnumerable<LaunchpadDto>>(launchpads);
        }

        public async Task<LaunchpadDto> GetLaunchpadAsync(string id)
        {
            var launchpad = await _launchpadRepoistory.GetAsync(id);

            return _mapper.Map<LaunchpadDto>(launchpad);
        }
    }
}
