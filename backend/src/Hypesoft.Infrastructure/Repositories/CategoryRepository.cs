using Hypesoft.Domain.Entities;
using Hypesoft.Domain.Repositories;

namespace Hypesoft.Infrastructure.Repositories;

public class CategoryRepository : ICategoryRepository
{
    private readonly List<Category> _categories = new List<Category>();

    public Task<List<Category>> GetAll()
    {
        return Task.FromResult(_categories);
    } 


    public Task<Category> GetById(Guid id)
    {
        var category = _categories.Find(x => x.Id == id);
        if (category == null) { throw new Exception("Category not found"); }
        return Task.FromResult(category);
    } 

    public Task Create(Category category)
    {
        _categories.Add(category);
        return Task.CompletedTask;
    } 

    public Task<Category> Update(Category category)
    {
        var existingCategory = _categories.Find(x => x.Id == category.Id);
        if (existingCategory == null)
        {
            throw new Exception("Category not found");
        }
        existingCategory.Name = category.Name;
        
        return Task.FromResult(existingCategory);
    }

    public Task Delete(Guid id)
    {
        var existingCategory = _categories.Find(x => x.Id == id);
        if (existingCategory == null)
        {
            throw new Exception("Category not found");
        }
        _categories.RemoveAll(x => x.Id == id);
        return Task.CompletedTask;
    }
}