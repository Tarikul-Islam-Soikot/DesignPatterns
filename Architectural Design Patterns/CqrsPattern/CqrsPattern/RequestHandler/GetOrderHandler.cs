using CqrsPattern.Entity;
using MediatR;

namespace CqrsPattern.RequestHandler
{
    public class GetOrderHandler : IRequestHandler<GetOrderQuery, Product>
    {
        public Task<Product> Handle(GetOrderQuery request, CancellationToken cancellationToken)
        {
            var entity = new Product
            {
                Id = request.Id,
                Name = "Dummy Product",
            };

            return Task.FromResult(entity);
        }
    }
}
