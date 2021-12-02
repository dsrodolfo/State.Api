using System.ComponentModel.DataAnnotations;

namespace State.Api.Entities
{
    public class StateEntity
    {
        public StateEntity()
        {

        }

        public int Id { get; set; }

        [MaxLength(100)]
        public string Name { get; set; }
    }
}