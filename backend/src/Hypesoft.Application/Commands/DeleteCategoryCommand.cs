using MediatR;

namespace Hypesoft.Application.Commands
{
    public class DeleteCategoryCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}