using Microsoft.AspNetCore.Identity;

namespace BlogV1.Identity
{
    public class BlogIdentityUser : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
    }
}
