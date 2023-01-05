using System.ComponentModel.DataAnnotations;

namespace MusicRoomManager.Models
{
    public enum PhoneType { Mobile, Home, Work }

    public class Phone
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public PhoneType Type { get; set; }

        [Required, DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
    }
}
