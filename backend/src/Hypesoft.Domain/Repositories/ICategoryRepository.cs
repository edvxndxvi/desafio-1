namespace Hypesoft.Domain.Repositories;

public interface ICategoryRepositoy
{
    Task<List<Category>> GetAll();
    Task<Category> GetById(Guid id);
    Task Create(Category category);
    Task Delete(Guid id);
}