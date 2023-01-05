using System.ComponentModel.DataAnnotations;

namespace MusicRoomManager.Models
{
    public class State
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required, StringLength(2)]
        public string Abbreviation { get; set; }
    }
}
