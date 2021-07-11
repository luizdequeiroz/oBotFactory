using System.ComponentModel.DataAnnotations;

namespace domain.Entities
{
    public class Chatter : Entity
    {
        [Required]
        public string Name { get; set; }
    }
}
