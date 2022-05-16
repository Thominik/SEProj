using System.Text.Json;
using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data;

public class ProductSeed
{
    public static async Task SeedUsers(DataContext context)
    {
        if (await context.Products.AnyAsync()) return;

        var productData = await System.IO.File.ReadAllTextAsync("Data/ProductSeedData.json");

        var products = JsonSerializer.Deserialize<List<Product>>(productData);

        foreach (var product in products)
        {
            context.Products.Add(product);
        }
    }
}