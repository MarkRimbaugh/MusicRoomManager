using MusicRoomManager.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MusicRoomManager.Models
{
    public class EquipmentRental
    {
        [Key]
        public int Id { get; set; }

        [DataType(DataType.Date), Display(Name = "Rental Date")]
        public DateTime RentalDate { get; set; } = DateTime.Now;

        [DataType(DataType.Date), Display(Name = "Date Due")]
        public DateTime DueDate => RentalDate.AddDays(14);

        [DataType(DataType.Date)]
        public DateTime? CheckedInDate { get; set; } = null;

        [Required, Display(Name = "User")]
        public string UserId { get; set; }
        public virtual ApplicationUser User { get; set; }

        [Required, Display(Name = "Item"), ForeignKey("Equipment")]
        public int EquipmentId { get; set; }
        public virtual Equipment Equipment { get; set; }

        [Required, Display(Name = "Customer"), ForeignKey("Customer")]
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
