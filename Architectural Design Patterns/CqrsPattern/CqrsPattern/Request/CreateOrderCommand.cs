using MediatR;

namespace CqrsPattern.Request
{
    public class CreateOrderCommand : IRequest<int>
    {
        public string Name { get; set; }
    }
}
