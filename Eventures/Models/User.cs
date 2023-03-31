using Microsoft.AspNetCore.Identity;

namespace Eventures.Models
{
    public class User : IdentityUser
    {
        public virtual ICollection<Order> Orders { get; set; }
    }
}
