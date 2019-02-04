using CodeChallenge.API.Controllers;
using CodeChallenge.API.Services;
using System;
using Xunit;
using Microsoft.AspNetCore.Mvc;
using CodeChallenge.API.Models;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace CodeChallenge.UnitTests
{
    public class TestLaunchpadController
    {
        LaunchpadController _launchpadController;
        ILaunchpadService _launchpadService;

        public TestLaunchpadController()
        {
            _launchpadService = new LaunchpadServiceFake();
            _launchpadController = new LaunchpadController(_launchpadService);  
        }

        [Theory]
        [InlineData("vafb_slc_3w")]
        [InlineData("ccafs_slc_40")]
        [InlineData("stls")]
        [InlineData("kwajalein_atoll")]
        [InlineData("vafb_slc_4e")]
        [InlineData("ksc_lc_39a")]
        public void GetLaunchpadTest_ReturnsOkResult(string id)
        {
            var ok = _launchpadController.GetAsync(id);

            Assert.IsType<OkObjectResult>(ok.Result);
        }

        [Theory]
        [InlineData("")]
        [InlineData("invalid_id")]
        public void GetLaunchpadTest_ReturnsNotFoundResult(string id)
        {
            var notFound = _launchpadController.GetAsync(id);

            Assert.IsType<NotFoundResult>(notFound.Result);
        }

        [Theory]
        [InlineData(6)]
        public void GetAllLaunchpadsTest_ReturnsAllItems(int count)
        {
            var task = _launchpadController.GetAsync();

            var result = task.Result as OkObjectResult;

            var items = JsonConvert.DeserializeObject<List<LaunchpadDto>>(result.Value.ToString());

            Assert.IsType<List<LaunchpadDto>>(items);

            Assert.Equal(count, items.Count());
        }
    }
}
