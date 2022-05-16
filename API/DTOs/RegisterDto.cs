using System.ComponentModel.DataAnnotations;

namespace API.DTOs;

public class RegisterDto
{
    [Required]
    public string Firstname { get; set; }
    [Required]
    public string Lastname { get; set; }
    [Required]
    public string Username { get; set; }
    [Required] 
    public string City { get; set; }
    [Required] 
    public string Street { get; set; }
    [Required] 
    public string Country { get; set; }

    [Required]
    [StringLength(20, MinimumLength = 8)]
    public string Password { get; set; }
}