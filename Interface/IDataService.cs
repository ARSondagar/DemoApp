namespace DemoApp.Interface
{
    public interface IDataService
    {
        Task<int> GetStringCount(string request);
    }
}
