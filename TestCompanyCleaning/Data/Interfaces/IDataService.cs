namespace TestCompanyCleaning.Data.Interfaces
{
    public interface IDataService
    {
        Task<IEnumerable<RequestItem>> GetRequestItemsAsync();
    }
}
