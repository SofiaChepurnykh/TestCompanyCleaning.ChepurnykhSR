using TestCompanyCleaning.Data.Interfaces;

namespace TestCompanyCleaning.Data.Services
{
    public class MemoryDataService : IDataService
    {
        private static IEnumerable<RequestItem> requests =
        [
            new() { Id = 1,
                FullName = "Иванов Иван Иванович",
                PhoneNumber = "89111111111",
                OfficeAddress = "Г. Тестовик, ул. Первая, д. 1",
                Room = "1",
                Services = new List<string> { "Влажная уборка", "Вынос мусора" },
                RequestedDateTime = new DateTime(2025, 7, 3, 14, 0, 0),
                Comment = "Пожалуйста, уделите внимание углам",
                CreatedDate = DateTime.Now },
            new() { Id = 2,
                FullName = "Петров Петр Петрович",
                PhoneNumber = "89222222222",
                OfficeAddress = "Г. Тестовик, ул. Вторая, д. 2",
                Room = "2",
                Services = new List<string> { "Очистка офисной техники" },
                RequestedDateTime = new DateTime(2025, 7, 4, 15, 0, 0),
                Comment = "Нет",
                CreatedDate = DateTime.Now },
        ];
        public async Task<IEnumerable<RequestItem>> GetRequestItemsAsync()
        {
            return await Task.FromResult(requests);
        }
    }
}
