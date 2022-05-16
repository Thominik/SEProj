namespace API.DTOs;

public class MemberDto
{
    public int Id { get; set; }
    public string Username { get; set; }
    public string Firstname { get; set; }
    public string PhotoUrl { get; set; }
    public string City { get; set; }
    public string Street { get; set; }
    public string Country { get; set; }

    public ICollection<PhotoDto> Photos { get; set; }
    
}