using System.ComponentModel.DataAnnotations;

namespace State.Domain.Entities
{
    public class StateEntity
    {
        public StateEntity()
        {

        }

        public int Id { get; set; }

        [MaxLength(100)]
        public string Name { get; set; }

        [MinLength(2)]
        [MaxLength(2)]
        public string Abbreviation { get; set; }

        public int Population { get; set; }
    }
}