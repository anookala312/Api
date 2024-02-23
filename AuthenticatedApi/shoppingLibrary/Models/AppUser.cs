namespace shoppingLibrary.Models
{
    public class AppUser : IdentityUser
    {
        public DataTime DOB {get; set;}
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NickName { get; set; }
    }
}
