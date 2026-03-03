namespace Hypesoft.Domain.Entitites;

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
        this.Id = Guid.NewGuid();
        this.Name = name;
        this.Description = description;
        this.Price = price;
        this.CategoryId = categoryId;
        this.StockQuantity = stockQuantity;
    }
}
