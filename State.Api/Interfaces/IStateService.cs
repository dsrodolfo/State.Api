using State.Api.Entities;

namespace State.Api.Interfaces
{
    public interface IStateService
    {
        string[] GetAllStates();
        IEnumerable<StateEntity> GetAllStateEntity();
        string[] GetAllStatesByName(string name);
        string DownloadFlags();
    }
}