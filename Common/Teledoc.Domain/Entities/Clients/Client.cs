using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Teledoc.Domain.Entities.Base;
using Teledoc.Domain.Entities.Founders;

namespace Teledoc.Domain.Entities.Clients
{
    [Table("Clients")]
    public class Client : BaseEntity
    {
        [Required]
        [Display(Name = "ИНН")]
        public long ClientsINN { get; set; }

        [Required]
        [Display(Name = "Название организации")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Тип организации")]
        public string Organization { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Время добавления")]
        public DateTime AddTime { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Время изменения")]
        public DateTime UpdateTime { get; set; }

        public int FounderId { get; set; }
        [ForeignKey(nameof(FounderId))]
        public virtual Founder Founder { get; set; }
    }
}
