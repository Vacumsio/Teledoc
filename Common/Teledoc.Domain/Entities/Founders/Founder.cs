using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Teledoc.Domain.Entities.Base;
using Teledoc.Domain.Entities.Clients;

namespace Teledoc.Domain.Entities.Founders
{
    [Table("ClientFounder")]
    public class Founder : BaseEntity
    {
        [Required]
        public string Firstname { get; set; }
        [Required]
        public string Surname { get; set; }

        public string Patronymic { get; set; }
    }
}
