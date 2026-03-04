namespace Hypesoft.Domain.Entities;

public class Product
{
    public Guid Id {get; set;}
    public string Name {get; set;}
    public string Description {get;set;}
    public decimal Price {get;set;}
    public Guid CategoryId {get;set;}
    public int StockQuantity {get;set;}

    public Product(string name, string description, decimal price, Guid categoryId, int stockQuantity)
    {
        Id = Guid.NewGuid();
        Name = name;
        Description = description;
        Price = price;
        CategoryId = categoryId;
        StockQuantity = stockQuantity;
    }
}
