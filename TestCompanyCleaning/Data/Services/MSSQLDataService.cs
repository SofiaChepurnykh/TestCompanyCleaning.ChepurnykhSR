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
                requestItem.InProgress = true;
                requestItem.IsCompleted = false;
                await context.RequestItems.AddAsync(requestItem);
            }
            else
            {
                var existing = await context.RequestItems.FirstOrDefaultAsync(x => x.Id == requestItem.Id);
                if (existing != null)
                {
                    existing.FullName = requestItem.FullName;
                    existing.PhoneNumber = requestItem.PhoneNumber;
                    existing.OfficeAddress = requestItem.OfficeAddress;
                    existing.Room = requestItem.Room;
                    existing.WindowWashing = requestItem.WindowWashing;
                    existing.WetСleaning = requestItem.WetСleaning;
                    existing.CarpetСleaning = requestItem.CarpetСleaning;
                    existing.Disinfection = requestItem.Disinfection;
                    existing.GarbageRemoval = requestItem.GarbageRemoval;
                    existing.OfficeEquipmentCleaning = requestItem.OfficeEquipmentCleaning;
                    existing.RequestedDateTime = requestItem.RequestedDateTime;
                    existing.Comment = requestItem.Comment;
                }
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