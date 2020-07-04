using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Teledoc.Domain.Entities.Base;

namespace Teledoc.Domain.Entities.Founders
{
    [Table("Founders")]
    public class Founder : BaseEntity
    {
        [Required]
        public string Firstname { get; set; }
        [Required]
        public string Surname { get; set; }

        public string Patronymic { get; set; }

        public DateTime AddTime { get; set; }

        public DateTime UpdateTime { get; set; }
    }
}
