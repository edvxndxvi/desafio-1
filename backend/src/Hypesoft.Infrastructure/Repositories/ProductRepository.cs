using Hypesoft.Domain.Entities;
using Hypesoft.Domain.Repositories;

namespace Hypesoft.Infrastructure.Repositories;

public class ProductRepository : IProductRepository
{
    private readonly List<Product> _products = new List<Product>();

    public Task<List<Product>> GetAll()
    {
        return Task.FromResult(_products);
    } 


    public Task<Product> GetById(Guid id)
    {
        var product = _products.Find(x => x.Id == id);
        if (product == null) { throw new Exception("Product not found"); }
        return Task.FromResult(product);
    } 

    public Task Create(Product product)
    {
        _products.Add(product);
        return Task.CompletedTask;
    } 

    public Task<Product> Update(Product product)
    {
        var existingProduct = _products.Find(x => x.Id == product.Id);
        if (existingProduct == null)
        {
            throw new Exception("Product not found");
        }
        existingProduct.Name = product.Name;
        existingProduct.Description = product.Description;
        existingProduct.Price = product.Price;
        existingProduct.CategoryId = product.CategoryId;
        existingProduct.StockQuantity = product.StockQuantity;

        return Task.FromResult(existingProduct);
    }

    public Task Delete(Guid id)
    {
        var existingProduct = _products.Find(x => x.Id == id);
        if (existingProduct == null)
        {
            throw new Exception("Product not found");
        }
        _products.RemoveAll(x => x.Id == id);
        return Task.CompletedTask;
    }
}