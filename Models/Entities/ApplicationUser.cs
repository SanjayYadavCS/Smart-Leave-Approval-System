using Microsoft.AspNetCore.Identity;

namespace SLAS.Models.Entities
{
    public class ApplicationUser : IdentityUser<int>
    {
    }

    public class ApplicationRole : IdentityRole<int>
    {
        public ApplicationRole()
        {
        }

        public ApplicationRole(string roleName) : base(roleName)
        {
        }
    }
}
