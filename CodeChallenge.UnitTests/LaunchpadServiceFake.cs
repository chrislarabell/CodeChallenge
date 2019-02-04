using CodeChallenge.API.Models;
using CodeChallenge.API.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace CodeChallenge.UnitTests
{
    public class LaunchpadServiceFake : ILaunchpadService
    {
        private readonly IEnumerable<LaunchpadDto> launchpads;
        public LaunchpadServiceFake()
        {
            launchpads = new List<LaunchpadDto>
            {
                new LaunchpadDto() { LaunchpadId = "vafb_slc_3w", LaunchpadName = "Vandenberg Air Force Base Space Launch Complex 3W", LaunchpadStatus = "retired"},
                new LaunchpadDto() { LaunchpadId = "ccafs_slc_40", LaunchpadName = "Cape Canaveral Air Force Station Space Launch Complex 40", LaunchpadStatus = "active"},
                new LaunchpadDto() { LaunchpadId = "stls", LaunchpadName = "SpaceX South Texas Launch Site", LaunchpadStatus = "under construction" },
                new LaunchpadDto() { LaunchpadId = "kwajalein_atoll", LaunchpadName = "Kwajalein Atoll Omelek Island", LaunchpadStatus = "retired" },
                new LaunchpadDto() { LaunchpadId = "vafb_slc_4e", LaunchpadName = "Vandenberg Air Force Base Space Launch Complex 4E", LaunchpadStatus = "active" },
                new LaunchpadDto() { LaunchpadId = "ksc_lc_39a", LaunchpadName = "Kennedy Space Center Historic Launch Complex 39A", LaunchpadStatus = "active" }
            };
        }
        public async Task<IEnumerable<LaunchpadDto>> GetAllLaunchpadsAsync()
        {
            return launchpads;
        }

        public async Task<LaunchpadDto> GetLaunchpadAsync(string id)
        {
            return launchpads.Where(x => x.LaunchpadId == id).FirstOrDefault();
        }
    }
}
