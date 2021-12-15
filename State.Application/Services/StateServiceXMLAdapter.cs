using Newtonsoft.Json;
using State.Application.Interfaces;
using System.Xml;

namespace State.Application.Services
{
    public class StateServiceXMLAdapter : IStateServiceXMLTarget
    {
        private readonly IStateService _stateService;

        public StateServiceXMLAdapter(IStateService stateService)
        {
            _stateService = stateService;
        }

        public XmlDocument GetAllStatesAsXML()
        {
            var states = _stateService.GetAllStates();
            string jsonContent = JsonConvert.SerializeObject(states);

            return JsonConvert.DeserializeXmlNode("{\"State\":" + jsonContent + "}", "BrazilianStates", true);
        }
    }
}