using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class User : IdentityUser
    {
        [Key]
        public string Email{ get; set; }
        public string Password { get; set; }



    }
}
