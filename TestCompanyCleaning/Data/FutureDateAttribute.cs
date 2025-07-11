using System;
using System.ComponentModel.DataAnnotations;

namespace TestCompanyCleaning.Data
{
    public class FutureDateAttribute : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            if (value is DateTime dateTime)
            {
                // проверка: дата должна быть сегодня или позже
                return dateTime.Date >= DateTime.Now.Date;
            }

            return true; // если значение null — оставляем это [Required]
        }
    }
}
