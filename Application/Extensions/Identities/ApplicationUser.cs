using Microsoft.AspNetCore.Identity;

namespace Application.Extensions.Identities{

    public class ApplicationUser : IdentityUser
    {
        public  string? Name {get ;  set;}
    }
}