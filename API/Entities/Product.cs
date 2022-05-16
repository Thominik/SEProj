namespace API.Entities;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Details { get; set; }
    public string Price { get; set; }

    public ICollection<ProductPhoto> ProductPhotos { get; set; }
}