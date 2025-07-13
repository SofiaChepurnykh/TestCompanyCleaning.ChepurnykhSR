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
                FullName = "������ ���� ��������",
                PhoneNumber = "89111111111",
                OfficeAddress = "�. ��������, ��. ������, �. 1",
                Room = "1",
                WindowWashing = true,
                //Services = new List<string> { "������� ������", "����� ������" },
                RequestedDateTime = new DateTime(2025, 7, 3, 14, 0, 0),
                Comment = "����������, ������� �������� �����",
                CreatedDate = DateTime.Now },
            new() { Id = 2,
                FullName = "������ ���� ��������",
                PhoneNumber = "89222222222",
                OfficeAddress = "�. ��������, ��. ������, �. 2",
                Room = "2",
                WindowWashing = false,
                //Services = new List<string> { "������� ������� �������" },
                RequestedDateTime = new DateTime(2025, 7, 4, 15, 0, 0),
                Comment = "4 ����������",
                CreatedDate = DateTime.Now },
            ]);
        }
    }
}
