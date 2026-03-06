using MediatR;
using Hypesoft.Domain.Entities;

namespace Hypesoft.Application.Commands
{
public class UpdateProductCommand : IRequest<Product>
    {
        public required Guid Id { get; set; }
        public required string Name { get; set; }
        public required string Description { get; set; }
        public decimal Price { get; set; }
        public Guid CategoryId { get; set; }
        public int StockQuantity { get; set; }
    }
}