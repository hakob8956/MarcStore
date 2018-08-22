using Microsoft.AspNetCore.Identity;
namespace MarcStore.Models
{
    public class User:IdentityUser
    {
        public int Year { get; set; }
       
    }
}
