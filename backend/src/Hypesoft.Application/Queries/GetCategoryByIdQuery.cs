using Hypesoft.Domain.Entities;
using MediatR;

namespace Hypesoft.Application.Queries;

public record GetCategoryByIdQuery(Guid Id) : IRequest<Category>;