namespace Hypesoft.Domain.Repositories;

public interface IProductRepository
{
    Task<List<Product>> GetAll();
    Task<Product> GetById(Guid id);
    Task Create(Product product);
    Task<Product> Update(Product product);
    Task Delete(Guid id);
}
