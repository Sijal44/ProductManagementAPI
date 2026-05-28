using MediatR;
using ProductManagement.Domain.Entities;

namespace ProductManagement.Application.Products.Queries.GetAllProducts;

public class GetAllProductsQuery : IRequest<List<Product>>
{
}