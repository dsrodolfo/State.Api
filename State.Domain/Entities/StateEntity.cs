using System.ComponentModel.DataAnnotations;

namespace State.Domain.Entities
{
    public class StateEntity
    {
        public StateEntity()
        {

        }

        [Required]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(2)]
        public string Abbreviation { get; set; }

        [Required]
        [MaxLength(14)]
        public string Capital { get; set; }

        public int Population { get; set; }
    }
}