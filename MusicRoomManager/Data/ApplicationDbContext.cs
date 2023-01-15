using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MusicRoomManager.Models;

namespace MusicRoomManager.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Equipment> Equipment { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<EquipmentRental> EquipmentRentals { get; set; }



        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public ApplicationDbContext() { }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<State>(x =>
            {
                x.HasData(
                    new State() { Id = 1, Name = "Alabama", Abbreviation = "AL" },
                    new State() { Id = 2, Name = "Alaska", Abbreviation = "AK" },
                    new State() { Id = 3, Name = "Arizona", Abbreviation = "AZ" },
                    new State() { Id = 4, Name = "Arkansas", Abbreviation = "AR" },
                    new State() { Id = 5, Name = "California", Abbreviation = "CA" },
                    new State() { Id = 6, Name = "Colorado", Abbreviation = "CO" },
                    new State() { Id = 7, Name = "Connecticut", Abbreviation = "CT" },
                    new State() { Id = 8, Name = "Delaware", Abbreviation = "DE" },
                    new State() { Id = 9, Name = "District of Columbia", Abbreviation = "DC" },
                    new State() { Id = 10, Name = "Florida", Abbreviation = "FL" },
                    new State() { Id = 11, Name = "Georgia", Abbreviation = "GA" },
                    new State() { Id = 12, Name = "Hawaii", Abbreviation = "HI" },
                    new State() { Id = 13, Name = "Idaho", Abbreviation = "ID" },
                    new State() { Id = 14, Name = "Illinois", Abbreviation = "IL" },
                    new State() { Id = 15, Name = "Indiana", Abbreviation = "IN" },
                    new State() { Id = 16, Name = "Iowa", Abbreviation = "IA" },
                    new State() { Id = 17, Name = "Kansas", Abbreviation = "KS" },
                    new State() { Id = 18, Name = "Kentucky", Abbreviation = "KY" },
                    new State() { Id = 19, Name = "Louisiana", Abbreviation = "LA" },
                    new State() { Id = 20, Name = "Maine", Abbreviation = "ME" },
                    new State() { Id = 21, Name = "Maryland", Abbreviation = "MD" },
                    new State() { Id = 22, Name = "Massachusetts", Abbreviation = "MS" },
                    new State() { Id = 23, Name = "Michigan", Abbreviation = "MI" },
                    new State() { Id = 24, Name = "Minnesota", Abbreviation = "MN" },
                    new State() { Id = 25, Name = "Mississippi", Abbreviation = "MS" },
                    new State() { Id = 26, Name = "Missouri", Abbreviation = "MO" },
                    new State() { Id = 27, Name = "Montana", Abbreviation = "MT" },
                    new State() { Id = 28, Name = "Nebraska", Abbreviation = "NE" },
                    new State() { Id = 29, Name = "Nevada", Abbreviation = "NV" },
                    new State() { Id = 30, Name = "New Hampshire", Abbreviation = "NH" },
                    new State() { Id = 31, Name = "New Jersey", Abbreviation = "NJ" },
                    new State() { Id = 32, Name = "New Mexico", Abbreviation = "NM" },
                    new State() { Id = 33, Name = "New York", Abbreviation = "NY" },
                    new State() { Id = 34, Name = "North Carolina", Abbreviation = "NC" },
                    new State() { Id = 35, Name = "North Dakota", Abbreviation = "ND" },
                    new State() { Id = 36, Name = "Ohio", Abbreviation = "OH" },
                    new State() { Id = 37, Name = "Oklahoma", Abbreviation = "OK" },
                    new State() { Id = 38, Name = "Oregon", Abbreviation = "OR" },
                    new State() { Id = 39, Name = "Pennsylvania", Abbreviation = "PA" },
                    new State() { Id = 40, Name = "Rhode Island", Abbreviation = "RI" },
                    new State() { Id = 41, Name = "South Carolina", Abbreviation = "SC" },
                    new State() { Id = 42, Name = "South Dakota", Abbreviation = "SD" },
                    new State() { Id = 43, Name = "Tennessee", Abbreviation = "TN" },
                    new State() { Id = 44, Name = "Texas", Abbreviation = "TX" },
                    new State() { Id = 45, Name = "Utah", Abbreviation = "UT" },
                    new State() { Id = 46, Name = "Vermont", Abbreviation = "VT" },
                    new State() { Id = 47, Name = "Virginia", Abbreviation = "VA" },
                    new State() { Id = 48, Name = "Washington", Abbreviation = "WA" },
                    new State() { Id = 49, Name = "West Virginia", Abbreviation = "WV" },
                    new State() { Id = 50, Name = "Wisconsin", Abbreviation = "WI" },
                    new State() { Id = 51, Name = "Wyoming", Abbreviation = "WY" }
                );
            });
            modelBuilder.Entity<Equipment>(x =>
            {
                x.HasData(
                    new Equipment() { Id = 1, Brand = "Fender", Model = "Stratocaster", Type = EquipmentType.ElectricGuitar, IsAvailable = true },
                    new Equipment() { Id = 2, Brand = "Gibson", Model = "Les Paul", Type = EquipmentType.ElectricGuitar, IsAvailable = true },
                    new Equipment() { Id = 3, Brand = "Taylor", Model = "214ce", Type = EquipmentType.AcousticGuitar, IsAvailable = true },
                    new Equipment() { Id = 4, Brand = "Fender", Model = "Telecaster", Type = EquipmentType.ElectricGuitar, IsAvailable = true },
                    new Equipment() { Id = 5, Brand = "Yamaha", Model = "Clavinova", Type = EquipmentType.Keyboard, IsAvailable = true },
                    new Equipment() { Id = 6, Brand = "Line6", Model = "JTV-89F", Type = EquipmentType.ElectricGuitar, IsAvailable = true },
                    new Equipment() { Id = 7, Brand = "Fender", Model = "Mustang GTX-100", Type = EquipmentType.Amplifier, IsAvailable = true },
                    new Equipment() { Id = 8, Brand = "Mesa", Model = "Boogie Mark V", Type = EquipmentType.Amplifier, IsAvailable = true },
                    new Equipment() { Id = 9, Brand = "Schecter", Model = "Stiletto Stealth 4", Type = EquipmentType.BassGuitar, IsAvailable = true },
                    new Equipment() { Id = 10, Brand = "Roland", Model = "VAD 706", Type = EquipmentType.Drums, IsAvailable = true }
                );
            });
            modelBuilder.Entity<Customer>(x =>
            {
                x.HasData(
                    new Customer() { Id = 1, FirstName = "Bob", LastName = "Ahsan", Street1 = "1757 Hayes Drive", Street2 = "Apt 138", City = "North Liberty", StateId = 15, Zip = "46508", HomePhone = "555-456-5790", MobilePhone = "555-489-5749", EmailAddress = "bahsan@mail.com", DateOfBirth = new DateTime(1982, 02, 03) },
                    new Customer() { Id = 2, FirstName = "Tom", LastName = "Chicurel", Street1 = "3349 Bailey Highway", Street2 = "NA", City = "South Bend", StateId = 15, Zip = "49804", HomePhone = "555-456-4570", MobilePhone = "555-415-4368", EmailAddress = "tchicurel@mail.com", DateOfBirth = new DateTime(1989, 01, 17) },
                    new Customer() { Id = 3, FirstName = "Elizabeth", LastName = "Koller", Street1 = "4502 Madison Drive", Street2 = "Apt 3B", City = "Walkerton", StateId = 15, Zip = "46984", HomePhone = "555-798-4596", MobilePhone = "555-789-4321", EmailAddress = "ekoller@mail.com", DateOfBirth = new DateTime(1985, 07, 10) },
                    new Customer() { Id = 4, FirstName = "Steve", LastName = "Humphreys", Street1 = "4565 Schroeder Forest Avenue", Street2 = "NA", City = "Leesville", StateId = 19, Zip = "68945", HomePhone = "555-786-8975", MobilePhone = "555-249-5792", EmailAddress = "shumphreys@mail.com", DateOfBirth = new DateTime(1979, 04, 14) },
                    new Customer() { Id = 5, FirstName = "Rose", LastName = "Voelkel", Street1 = "9807 Henderson Road", Street2 = "Apt 087", City = "Hope Mills", StateId = 34, Zip = "89707", HomePhone = "555-970-1456", MobilePhone = "555-798-0465", EmailAddress = "rvoelkel@mail.com", DateOfBirth = new DateTime(1972, 10, 30) },
                    new Customer() { Id = 6, FirstName = "Grace", LastName = "Greenfield", Street1 = "27384 Martin Avenue", Street2 = "NA", City = "Wasilla", StateId = 2, Zip = "16591", HomePhone = "555-579-5647", MobilePhone = "555-579-6780", EmailAddress = "ggreenfield@mail.com", DateOfBirth = new DateTime(1990, 12, 12) },
                    new Customer() { Id = 7, FirstName = "Joe", LastName = "Diederich", Street1 = "4809 Witting Parkway", Street2 = "NA", City = "Palmer", StateId = 2, Zip = "98705", HomePhone = "555-129-7980", MobilePhone = "555-978-5706", EmailAddress = "jdiederich@mail.com", DateOfBirth = new DateTime(1977, 08, 05) },
                    new Customer() { Id = 8, FirstName = "Scott", LastName = "Stewart", Street1 = "321 Bradtke Ville", Street2 = "Ste 101", City = "Indianapolis", StateId = 15, Zip = "59498", HomePhone = "555-678-5794", MobilePhone = "555-579-5749", EmailAddress = "sstewart@mail.com", DateOfBirth = new DateTime(1980, 08, 12) },
                    new Customer() { Id = 9, FirstName = "Gina", LastName = "Riesman", Street1 = "28907 Erdman Points", Street2 = "NA", City = "Lakeville", StateId = 15, Zip = "46898", HomePhone = "555-878-9713", MobilePhone = "555-789-6498", EmailAddress = "griesman@mail.com", DateOfBirth = new DateTime(1962, 09, 08) },
                    new Customer() { Id = 10, FirstName = "Bill", LastName = "Rhodes", Street1 = "2417 Schmidt Drive", Street2 = "NA", City = "Mishawaka", StateId = 15, Zip = "49849", HomePhone = "555-579-5914", MobilePhone = "555-789-8978", EmailAddress = "brhodes@mail.com", DateOfBirth = new DateTime(1985, 01, 22) }
                );
            });
        }
    }
}





