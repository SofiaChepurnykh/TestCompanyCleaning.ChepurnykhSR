namespace TestCompanyCleaning.Data.Interfaces
{
    public interface IDataService
    {
        Task<IEnumerable<RequestItem>> GetAllAsync();
        Task SaveAsync(RequestItem item);
        Task<RequestItem?> GetRequestAsync(int id);
        Task DeleteAsync(int id);
    }
}
