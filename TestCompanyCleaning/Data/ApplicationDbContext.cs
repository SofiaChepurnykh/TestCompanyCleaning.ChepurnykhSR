using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace TestCompanyCleaning.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public virtual DbSet<RequestItem> RequestItems { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<RequestItem>().HasData([
                new() { Id = 1,
                FullName = "Иванов Иван Иванович",
                PhoneNumber = "89111111111",
                OfficeAddress = "Г. Тестовик, ул. Первая, д. 1",
                Room = "1",
                WindowWashing = true,
                //Services = new List<string> { "Влажная уборка", "Вынос мусора" },
                RequestedDateTime = new DateTime(2025, 7, 3, 14, 0, 0),
                Comment = "Пожалуйста, уделите внимание углам",
                CreatedDate = DateTime.Now },
            new() { Id = 2,
                FullName = "Петров Петр Петрович",
                PhoneNumber = "89222222222",
                OfficeAddress = "Г. Тестовик, ул. Вторая, д. 2",
                Room = "2",
                WindowWashing = false,
                //Services = new List<string> { "Очистка офисной техники" },
                RequestedDateTime = new DateTime(2025, 7, 4, 15, 0, 0),
                Comment = "4 компьютера",
                CreatedDate = DateTime.Now },
            ]);
        }
    }
}
