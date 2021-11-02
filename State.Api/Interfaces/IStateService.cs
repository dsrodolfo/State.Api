namespace State.Api.Interfaces
{
    public interface IStateService
    {
        string[] GetAllStates();
        string[] GetAllStatesByName(string name);
    }
}