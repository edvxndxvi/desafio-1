using Hypesoft.Domain.Entities;
using MediatR;

namespace Hypesoft.Application.Commands
{
    public class CreateCategoryCommand : IRequest<Category>
    {
        public required string Name { get; set; }
    }
}