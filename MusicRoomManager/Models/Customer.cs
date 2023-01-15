using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MusicRoomManager.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(50), Display(Name = "Last")]
        public string LastName { get; set; }

        [Required, StringLength(50), Display(Name = "First")]
        public string FirstName { get; set; }

        [DataType(DataType.EmailAddress), Display(Name = "E-mail")]
        public string EmailAddress { get; set; }

        [Required, StringLength(50), Display(Name = "Street Address 1")]
        public string Street1 { get; set; }

        [StringLength(50), Display(Name = "Street Address 2")]
        public string Street2 { get; set; }

        [Required, StringLength(50)]
        public string City { get; set; }

        [ForeignKey("State"), Display(Name = "State")]
        public int StateId { get; set; }
        public State State { get; set; }

        [RegularExpression("^\\d{5}(?:[-\\s]\\d{4})?$", ErrorMessage = "Invalid zip code")]
        public string Zip { get; set; }


        [DataType(DataType.Date), Display(Name = "Date of Birth")]
        public DateTime DateOfBirth { get; set; }

        [DataType(DataType.PhoneNumber), Display(Name = "Home Phone")]
        public string HomePhone { get; set; }

        [DataType(DataType.PhoneNumber), Display(Name = "Mobile Phone")]
        public string MobilePhone { get; set; }

        public string FriendlyName => $"{FirstName} {LastName}";

    }
}
