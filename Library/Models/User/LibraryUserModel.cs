using Library.Data.Entity;

namespace Library.Models.User
{
    public class LibraryUserModel
    {
        public LibraryUserModel(LibraryUser user, string role)
        {
            Id = user.Id;
            Email = user.Email;
            Name = user.Name;
            Surname = user.Surname;
            Address = user.Address;
            Role = role;
        }
        
        public int Id { get; set; }

        public string Email { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Address { get; set; }

        public string Role { get; set; }
    }
}