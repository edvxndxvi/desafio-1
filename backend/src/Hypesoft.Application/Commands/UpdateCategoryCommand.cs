using Hypesoft.Domain.Entities;
using MediatR;

namespace Hypesoft.Application.Commands
{
    public class UpdateCategoryCommand : IRequest<Category>
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
    }
}