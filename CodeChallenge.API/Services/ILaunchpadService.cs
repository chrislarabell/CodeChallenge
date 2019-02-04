namespace CodeChallenge.API.Services
{
    using CodeChallenge.API.Models;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    public interface ILaunchpadService
    {
        Task<LaunchpadDto> GetLaunchpadAsync(string id);

        Task<IEnumerable<LaunchpadDto>> GetAllLaunchpadsAsync();
    }
}
