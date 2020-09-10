using Microsoft.AspNetCore.Identity;

namespace Library.Data.Entity
{
    public class LibraryUser : IdentityUser<int>
    {
        public string Address { get; set; }

        public string Name { get; set; }
        
        public string Surname { get; set; }

        public override string UserName => Name;
    }
}