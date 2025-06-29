namespace TestCompanyCleaning.Data
{
    public class RequestItem
    {
        public int Id { get; set; }
        public string? FullName { get; set; } // ФИО сотрудника

        public string? PhoneNumber { get; set; } // Контактный номер

        public string? OfficeAddress { get; set; } // Адрес офиса (1 из 2)

        public string? Room { get; set; } // Кабинет (1 из 10)

        public List<string> Services { get; set; } = new(); // Выбранные услуги (можно выбрать несколько)

        public DateTime? RequestedDateTime { get; set; } // Назначенная дата и время

        public string? Comment { get; set; } // Комментарий

        public DateTime CreatedDate { get; set; } = DateTime.Now; // Дата создания

        // Статические списки для выбора (выпадающие списки в форме)
        public static List<string> AvailableOffices => new() { "Г. Тестовик, ул. Первая, д. 1", "Г. Тестовик, ул. Вторая, д. 2" };
        public static List<string> AvailableRooms => new() { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };
        public static List<string> AvailableServices => new()
    {
        "Мойка окон",
        "Влажная уборка",
        "Чистка ковров",
        "Дезинфекция",
        "Вынос мусора",
        "Очистка офисной техники"
    };

    }
}
