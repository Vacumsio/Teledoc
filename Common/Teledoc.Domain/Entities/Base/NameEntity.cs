using System.ComponentModel.DataAnnotations;
using Teledoc.Domain.Entities.Base.Interfaces;

namespace Teledoc.Domain.Entities.Base
{
    public abstract class NameEntity : BaseEntity
    {
        [Required]
        public string Name { get; set; }
    }
}
