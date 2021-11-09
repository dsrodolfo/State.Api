using System.Net;
using System.Threading.Tasks;
using Xunit;

namespace State.Api.Tests
{
    public class StateTest
    {
        [Fact]
        public async Task Get_All_States_ReturnsOk()
        {
            await using var stateApp = new StateApplication();

            var client = stateApp.CreateClient();
            var response = client.GetAsync("/State/getAll");

            Assert.Equal(HttpStatusCode.OK, response.Result.StatusCode);
        }

        [Fact]
        public async Task Get_All_States_By_Name_ReturnsOK()
        {
            await using var stateApp = new StateApplication();

            var client = stateApp.CreateClient();
            var response = client.GetAsync("/State/getAll/sao");

            Assert.Equal(HttpStatusCode.OK, response.Result.StatusCode);
        }

        [Fact]
        public async Task Get_All_States_By_Name_ReturnsNotFound()
        {
            await using var stateApp = new StateApplication();

            var client = stateApp.CreateClient();
            var response = client.GetAsync("/State/getAll/xxxxxxx");

            Assert.Equal(HttpStatusCode.NotFound, response.Result.StatusCode);
        }

        [Fact]
        public async Task Download_Flags_ReturnsOK()
        {
            await using var stateApp = new StateApplication();

            var client = stateApp.CreateClient();
            var response = client.GetAsync("/State/flags/download");

            Assert.Equal(HttpStatusCode.OK, response.Result.StatusCode);
        }
    }
}