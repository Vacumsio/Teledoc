using System.ComponentModel.DataAnnotations;
using Teledoc.Domain.Entities.Base.Interfaces;

namespace Teledoc.Domain.Entities.Base
{
    public abstract class BaseEntity : IBaseEntity
    {
        [Key]
        public int Id { get; set; }
    }
}
