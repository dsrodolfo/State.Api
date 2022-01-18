using ChoETL;
using Newtonsoft.Json;
using State.Application.Interfaces;
using System.Text;

namespace State.Application.Services
{
    public class StateServiceCsvAdapter : IStateServiceCsvTarget
    {
        private readonly IStateService _stateService;

        public StateServiceCsvAdapter(IStateService stateService)
        {
            _stateService = stateService;
        }

        public byte[] GetAllStatesAsBytes()
        {
            var states = _stateService.GetAllStates();
            var jsonContent = JsonConvert.SerializeObject(states);

            StringBuilder csv = new();
            using ChoJSONReader reader = new(new StringReader(jsonContent));
            using var writer = new ChoCSVWriter(new StringWriter(csv)).WithFirstLineHeader();
            writer.Write(reader);

            byte[] bytes = Encoding.Latin1.GetBytes(csv.ToString());

            return bytes;
        }
    }
}