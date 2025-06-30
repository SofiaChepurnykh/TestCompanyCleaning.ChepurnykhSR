using Microsoft.EntityFrameworkCore;
using TestCompanyCleaning.Data.Interfaces;

namespace TestCompanyCleaning.Data.Services
{
    public class MSSQLDataService(ApplicationDbContext context) : IDataService
    {
        public async Task<IEnumerable<RequestItem>> GetRequestItemsAsync()
        {
            return await context.RequestItems.ToArrayAsync();
        }
    }
}
