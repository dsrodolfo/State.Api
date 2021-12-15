using State.Application.Models.Response;

namespace State.Application.Interfaces
{
    public interface IStateService
    {
        IEnumerable<StateResponse> GetAllStates();
        IEnumerable<StateResponse> GetAllStatesByName(string name);
        string DownloadFlags();
    }
}