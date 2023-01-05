using System.ComponentModel.DataAnnotations;

namespace MusicRoomManager.Models
{
    public enum EquipmentType
    {
        [Display(Name = "Electric Guitar")]
        ElectricGuitar,

        [Display(Name = "Acoustic Guitar")]
        AcousticGuitar,

        [Display(Name = "Bass Guitar")]
        BassGuitar,
        Keyboard,
        Drums,
        Amplifier
    }

    public class Equipment
    {
        [Key]
        public int Id { get; set; }
        [Required, StringLength(50)]
        public string Brand { get; set; }
        [Required, StringLength(50)]
        public string Model { get; set; }

        public EquipmentType Type { get; set; }

        [Display(Name = "Available?")]
        public bool IsAvailable { get; set; } = true;

        public string FriendlyName => $"{Brand} {Model}";

        public virtual List<EquipmentRental>? EquipmentRentals { get; set; }

    }
}
