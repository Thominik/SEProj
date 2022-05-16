namespace API.Entities;

public class ProductPhoto
{
    public int Id { get; set; }
    public string Url { get; set; }
    public string PublicId { get; set; }
    public Product Product { get; set; }
    public int FurnitureId { get; set; }
}