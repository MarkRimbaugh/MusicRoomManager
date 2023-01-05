using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MusicRoomManager.Models
{
    public class Address
    {
        [Key]
        public int Id { get; set; }
        [Required, StringLength(50)]
        public string Street1 { get; set; }
        public string Street2 { get; set; }

        [Required, StringLength(50)]
        public string City { get; set; }

        [ForeignKey("State")]
        public int StateId { get; set; }
        public State State { get; set; }

        [RegularExpression("^\\d{5}(?:[-\\s]\\d{4})?$", ErrorMessage = "Invalid zip code")]
        public string Zip { get; set; }
    }
}
