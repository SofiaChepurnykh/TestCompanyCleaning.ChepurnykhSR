using Microsoft.EntityFrameworkCore;
using TestCompanyCleaning.Data.Interfaces;

namespace TestCompanyCleaning.Data.Services
{
    public class MSSQLDataService(ApplicationDbContext context) : IDataService
    {
        public async Task<IEnumerable<RequestItem>> GetAllAsync()
        {
            return await context.RequestItems.ToArrayAsync();
        }

        public async Task SaveAsync(RequestItem requestItem)
        {
            if (requestItem.Id == 0) 
            {
                await context.RequestItems.AddAsync(requestItem); 
            }
            else
            {
                context.RequestItems.Update(requestItem); 
            }
            await context.SaveChangesAsync();
        }
        public async Task<RequestItem?> GetRequestAsync(int id) 
        {
            return await context.RequestItems.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task DeleteAsync(int id)
        {
            var requestItem = await context.RequestItems.FirstAsync(x => x.Id == id);
            context.RequestItems.Remove(requestItem); 
            await context.SaveChangesAsync(); 
        }
    }
}
