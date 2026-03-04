using Hypesoft.Domain.Entities;
using MediatR;

namespace Hypesoft.Application.Commands;

public class CreateProductCommand : IRequest<Product>
{
    public required string Name { get; set; }
    public required string Description { get; set; }
    public required decimal Price { get; set; }
    public Guid CategoryId { get; set; }
    public required int StockQuantity { get; set; }
}