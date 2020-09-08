using Microsoft.AspNetCore.Identity;

namespace Library.Data.Entity
{
    public class LibraryUser : IdentityUser
    {
        public string Address { get; set; }
    }
}