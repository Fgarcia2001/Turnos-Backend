using System.ComponentModel.DataAnnotations;

namespace GestionTurnos.Domain.Entities
{
    public abstract class BaseEntity
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        
        public bool IsDeleted { get; set; } = false;
        public DateTime CreatedDateTime { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedDateTime { get; set; } = DateTime.UtcNow;
        public DateTime? DeletedDateTime { get; set; }
    }
}
