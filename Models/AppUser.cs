using Microsoft.AspNetCore.Identity;

namespace fin_application.Models
{
    public class AppUser : IdentityUser
    {
        public List<Portfolio> Portfolios { get; set; } = new List<Portfolio>();
    }
}