using CqrsPattern.Entity;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace CqrsPattern
{
    public class GetOrderQuery : IRequest<Product>
    {
        public int Id { get; set; }
    }

}
