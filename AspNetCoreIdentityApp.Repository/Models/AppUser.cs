using AspNetCoreIdentityApp.Core.Models;
using Microsoft.AspNetCore.Identity;

namespace AspNetCoreIdentityApp.Repository.Models
{
    public class AppUser : IdentityUser
    {
        public string? City { get; set; }
        public string? Picture { get; set; }
        public DateTime? BirthDate { get; set; }
        public Gender? Gender { get; set; }
    }
}