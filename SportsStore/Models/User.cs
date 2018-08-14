using Microsoft.AspNetCore.Identity;
namespace SportsStore.Models
{
    public class User:IdentityUser
    {
        public int Year { get; set; }
    }
}
