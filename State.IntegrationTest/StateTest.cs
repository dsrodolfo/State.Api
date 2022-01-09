using Newtonsoft.Json;
using State.Application.Models.Responses;
using System.Net;
using System.Threading.Tasks;
using System.Xml;
using Xunit;

namespace State.IntegrationTest
{
    public class StateTest
    {
        [Fact]
        public async Task Get_XML_All_States_ReturnsXML()
        {
            await using var stateApp = new StateApplication();

            var client = stateApp.CreateClient();
            var response = client.GetAsync("/State/xml/getAll");
            var result = response.Result.Content.ReadAsStringAsync().Result;

            XmlDocument xmlFile = new();
            xmlFile.LoadXml(result);

            Assert.Contains("<BrazilianStates>", xmlFile.OuterXml);
        }

        [Fact]
        public async Task Get_All_States_Returns27States()
        {
            await using var stateApp = new StateApplication();

            var client = stateApp.CreateClient();
            var response = client.GetAsync("/State/getAll");
            var result = response.Result.Content.ReadAsStringAsync().Result;
            var stateResponse = JsonConvert.DeserializeObject<StateResponse[]>(result);

            int length = stateResponse != null? stateResponse.Length : 0;   

            Assert.Equal(27, length);
        }

        [Fact]
        public async Task Get_All_States_By_Name_Returns1State()
        {
            await using var stateApp = new StateApplication();

            var client = stateApp.CreateClient();
            var response = client.GetAsync("/State/getAll/sao");
            var result = response.Result.Content.ReadAsStringAsync().Result;
            var stateResponse = JsonConvert.DeserializeObject<StateResponse[]>(result);

            Assert.Single(stateResponse);
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