using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace Teledoc.Domain.ViewModels
{
    public class FounderViewModel
    {
        [HiddenInput(DisplayValue = false)]
        public int Id { get; set; }

        [Display(Name = "Имя")]
        [Required(ErrorMessage = "Имя обязательно")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "Длина имени должна быть от 3 до 60 символов")]
        [RegularExpression(@"([А-ЯЁ][а-яё]+)|([A-Z][a-z]+)", ErrorMessage = "Неверный формат данных")]
        public string Firstname { get; set; }

        [Display(Name = "Фамилия")]
        [Required(ErrorMessage = "Фамилия обязательна")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Длина фамилии должна быть от 3 до 100 символов")]
        [RegularExpression(@"([А-ЯЁ][а-яё]+)|([A-Z][a-z]+)", ErrorMessage = "Неверный формат данных")]
        public string Surname { get; set; }

        [Display(Name = "Отчество")]
        [Required(ErrorMessage = "Отчество обязательно")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Длина Отчества должна быть от 3 до 100 символов")]
        [RegularExpression(@"([А-ЯЁ][а-яё]+)|([A-Z][a-z]+)", ErrorMessage = "Неверный формат данных")]
        public string Patronymic { get; set; }
    }
}
