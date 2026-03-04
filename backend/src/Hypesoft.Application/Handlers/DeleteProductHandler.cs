using MediatR;
using Hypesoft.Application.Commands;
using Hypesoft.Domain.Repositories;

namespace Hypesoft.Application.Handlers;

public class DeleteProductHandler : IRequestHandler<DeleteProductCommand>
{
    private readonly IProductRepository _productRepository;

    public DeleteProductHandler(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public async Task Handle(DeleteProductCommand request, CancellationToken cancellationToken)
    {
        var product = await _productRepository.GetById(request.Id);
        if (product == null)
        {
            throw new Exception("Product not found");
        }
       await _productRepository.Delete(product.Id);
    }
}