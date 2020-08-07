using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace Teledoc.Domain.ViewModels
{
    //[Obsolete("Abstract, dont't use",error:true)]
    public class ClientViewModel
    {
        [HiddenInput(DisplayValue = false)]
        public int Id { get; set; }

        [Display(Name = "ИНН")]
        [Required(ErrorMessage = "ИНН обязательно")]
        [StringLength(12, ErrorMessage = "Длина имени должна быть 12 символов")]
        [RegularExpression(@"(\d{1,9})", ErrorMessage = "Неверный формат данных")]
        public long ClientsINN { get; set; }

        [Display(Name = "Имя")]
        [Required(ErrorMessage = "Имя обязательно")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Длина имени должна быть от 2 до 100 символов")]
        [RegularExpression(@"([А-ЯЁ][а-яё]+)|([A-Z][a-z]+)", ErrorMessage = "Неверный формат данных")]
        public string Name { get; set; }

        [Display(Name = "Тип Организации")]
        [Required(ErrorMessage = "Тип обязателен")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Длина типа должна быть от 2 до 100 символов")]
        [RegularExpression(@"([А-ЯЁ][а-яё]+)|([A-Z][a-z]+)", ErrorMessage = "Неверный формат данных")]
        public string Organization { get; set; }
        [DataType(DataType.Date)]
        public DateTime AddTime { get; set; }
        [DataType(DataType.Date)]
        public DateTime UpdateTime { get; set; }
        
        public string Founder { get; set; }
    }
}
