using State.Api.Models.Response;

namespace State.Api.Interfaces
{
    public interface IStateService
    {
        IEnumerable<StateResponse> GetAllStates();
        IEnumerable<StateResponse> GetAllStatesByName(string name);
        string DownloadFlags();
    }
}