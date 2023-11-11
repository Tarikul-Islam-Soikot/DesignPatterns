using CqrsPattern.Request;
using MediatR;

namespace CqrsPattern.RequestHandler
{
    public class CreateOrderHandler : IRequestHandler<CreateOrderCommand, int>
    {
        public Task<int> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
        {
            int id = 21232;

            return Task.FromResult(id);
        }
    }

}
