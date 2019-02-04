namespace CodeChallenge.Infrastructure.ExternalServices
{
    using RestSharp;
    using System.Threading.Tasks;
    using CodeChallenge.Core.Entities;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    public class LaunchpadApiExternalService : IRestExternalService<Launchpad, string>
    {
        public Launchpad Get(string id)
        {
            var task = GetLaunchpad(id);

            task.Wait();

            return task.Result;
        }

        public IEnumerable<Launchpad> GetAll()
        {
            var task = GetAllLaunchpads();

            task.Wait();

            return task.Result;
        }

        public Task<IEnumerable<Launchpad>> GetAllAsync()
        {
            return GetAllLaunchpads();
        }

        public async Task<Launchpad> GetAsync(string id)
        {
            return await GetLaunchpad(id);
        }

        private async Task<IEnumerable<Launchpad>> GetAllLaunchpads()
        {
            var client = new RestClient("https://api.spacexdata.com/v2");

            var request = new RestRequest("launchpads");

            var response = await client.ExecuteGetTaskAsync(request);

            return JsonConvert.DeserializeObject<IEnumerable<Launchpad>>(response.Content);
        }

        private async Task<Launchpad> GetLaunchpad(string id)
        {
            var client = new RestClient("https://api.spacexdata.com/v2");

            var request = new RestRequest("launchpads/{id}");

            request.AddUrlSegment("id", id);

            var response = await client.ExecuteGetTaskAsync(request);

            return JsonConvert.DeserializeObject<Launchpad>(response.Content);
        }
    }
}
