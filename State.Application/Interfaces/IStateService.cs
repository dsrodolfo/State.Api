using State.Application.Models.Responses;

namespace State.Application.Interfaces
{
    public interface IStateService
    {
        IEnumerable<StateResponse> GetAllStates();
        IEnumerable<StateResponse> GetAllStatesByName(string name);
        string DownloadFlags();
    }
}