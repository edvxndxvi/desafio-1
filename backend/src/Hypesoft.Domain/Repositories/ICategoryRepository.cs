using Hypesoft.Domain.Entities;

namespace Hypesoft.Domain.Repositories;

public interface ICategoryRepository
{
    Task<List<Category>> GetAll();
    Task<Category> GetById(Guid id);
    Task Create(Category category);
    Task<Category> Update(Category category);
    Task Delete(Guid id);
}