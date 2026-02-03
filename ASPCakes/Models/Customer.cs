using Microsoft.AspNetCore.Identity;

namespace ASPCakes.Models
{
    public class Customer :IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public ICollection <Order> Orders { get; set; }
    }
}
