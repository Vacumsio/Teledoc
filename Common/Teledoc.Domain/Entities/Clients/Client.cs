using System;
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
        public long ClientsINN { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Organization { get; set; }

        [Required]
        public int FounderId { get; set; }

        [ForeignKey(nameof(FounderId))]
        public virtual Founder Founder { get; set; }

        public DateTime AddTime { get; set; }

        public DateTime UpdateTime { get; set; }
    }
}
