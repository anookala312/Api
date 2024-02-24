using Microsoft.AspNetCore.Identity;
namespace shoppingLibrary.Models
{
    public class AppUser : IdentityUser
    {
        public DateTime DOB {get; set;}
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NickName { get; set; }
    }
}
