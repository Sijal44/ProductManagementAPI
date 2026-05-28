using MediatR;
using ProductManagement.Domain.Entities;

namespace ProductManagement.Application.Products.Queries.GetProductById;

public class GetProductByIdQuery : IRequest<Product?>
{
    public int Id { get; set; }

    public GetProductByIdQuery(int id)
    {
        Id = id;
    }
}