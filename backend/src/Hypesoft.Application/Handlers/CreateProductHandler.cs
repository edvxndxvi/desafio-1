using MediatR;
using Hypesoft.Application.Commands;
using Hypesoft.Domain.Repositories;
using Hypesoft.Domain.Entities;

namespace Hypesoft.Application.Handlers;

public class CreateProductHandler : IRequestHandler<CreateProductCommand, Product>
{
    private readonly IProductRepository _productRepository;
    private readonly ICategoryRepository _categoryRepository;

    public CreateProductHandler(IProductRepository productRepository, ICategoryRepository categoryRepository)
    {
        _productRepository = productRepository;
        _categoryRepository = categoryRepository;
    }

    public async Task<Product> Handle(CreateProductCommand request, CancellationToken cancellationToken)
    {
        var category = await _categoryRepository.GetById(request.CategoryId);
        if (category == null)
        {
            throw new Exception("Category not found");
        }
        var product = new Product(request.Name, request.Description, request.Price, request.CategoryId, request.StockQuantity);
        await _productRepository.Create(product);
        return product;
    }
}