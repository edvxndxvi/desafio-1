using MediatR;
using Hypesoft.Domain.Entities;
using Hypesoft.Domain.Repositories;
using Hypesoft.Application.Commands;

namespace Hypesoft.Application.Handlers;

public class UpdateProductHandler : IRequestHandler<UpdateProductCommand, Product>
{
    private readonly IProductRepository _productRepository;
    private readonly ICategoryRepository _categoryRepository;

    public UpdateProductHandler(IProductRepository productRepository, ICategoryRepository categoryRepository)
    {
        _productRepository = productRepository;
        _categoryRepository = categoryRepository;
    }

    public async Task<Product> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
    {
        var product = await _productRepository.GetById(request.Id);
        if (product == null)
        {
            throw new Exception("Product not found");
        }
        var category = await _categoryRepository.GetById(request.CategoryId);
        if (category == null)
        {
            throw new Exception("Category not found");
        }
        product.Name = request.Name;
        product.Description = request.Description;
        product.Price = request.Price;
        product.CategoryId = request.CategoryId;
        product.StockQuantity = request.StockQuantity;

        return await _productRepository.Update(product);
    }
}