using Microsoft.AspNetCore.Identity;
using MusicRoomManager.Models;
using System.ComponentModel.DataAnnotations;

namespace MusicRoomManager.Data
{
    public class ApplicationUser : IdentityUser
    {
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }


        public string FriendlyName => $"{FirstName} {LastName}";

        public virtual List<EquipmentRental>? EquipmentRentals { get; set; }

    }
}
