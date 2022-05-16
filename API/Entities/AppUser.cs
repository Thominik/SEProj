using Microsoft.AspNetCore.Identity;

namespace API.Entities;

public class AppUser : IdentityUser<int>
{
    public string Firstname { get; set; }
    public string Lastname { get; set; }
    public string City { get; set; }
    public string Country { get; set; }
    public string Street { get; set; }

    public ICollection<Photo> Photos { get; set; }
    public ICollection<AppUserRole> UserRoles { get; set; }
}