using System.ComponentModel.DataAnnotations;
using TestCompanyCleaning.Data;

namespace TestCompanyCleaning.Data
{
    public class RequestItem
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Поле 'ФИО' обязательно")]
        public string? FullName { get; set; } // ФИО сотрудника
        [Required(ErrorMessage = "Поле 'Телефон' обязательно")]
        [RegularExpression(@"^\d{11}$", ErrorMessage = "Номер телефона должен содержать ровно 11 цифр")]
        public string? PhoneNumber { get; set; } // Контактный номер
        [Required(ErrorMessage = "Поле 'Офис' обязательно")]
        public string? OfficeAddress { get; set; } // Адрес офиса (1 из 2)
        [Required(ErrorMessage = "Поле 'Кабинет' обязательно")]
        public string? Room { get; set; } // Кабинет (1 из 10)
        public bool WindowWashing { get; set; } // Мойка окон 
        public bool WetСleaning { get; set; } // Влажная уборка
        public bool CarpetСleaning { get; set; } // Чистка ковров
        public bool Disinfection { get; set; } // Дезинфекция
        public bool GarbageRemoval { get; set; } // Вынос мусора
        public bool OfficeEquipmentCleaning { get; set; } // Очистка офисной техники

        [Required(ErrorMessage = "Поле 'Дата и время' обязательно")]
        [FutureDate(ErrorMessage = "Дата должна быть не раньше текущей")]
        public DateTime? RequestedDateTime { get; set; } // Назначенная дата и время
        public string? Comment { get; set; } // Комментарий
        public DateTime CreatedDate { get; set; } = DateTime.Now; // Дата создания

        public bool InProgress { get; set; } = true; // В работе
        public bool IsCompleted { get; set; } = false; // Не завершена по умолчанию
        public string? Rating { get; set; } // Оценка (1 из 10)

        [MaxLength(200)]
        public string? ReviewComment { get; set; } // Комментарий к оценке

        // Статические списки для выбора (выпадающие списки в форме)
        public static List<string> AvailableOffices => new() { "Г. Тестовик, ул. Первая, д. 1", "Г. Тестовик, ул. Вторая, д. 2" };
        public static List<string> AvailableRooms => new() { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };
        public static List<string> AvailableRating => new() { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };

    }
}