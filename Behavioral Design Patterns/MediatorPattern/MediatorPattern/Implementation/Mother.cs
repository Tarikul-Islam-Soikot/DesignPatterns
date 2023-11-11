using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatorPattern.Interfaces;

namespace MediatorPattern.Implementation
{
    public class Mother : IPerson
    {
        private readonly IChildMediator _mediator;

        public Mother(IChildMediator mediator)
        {
            _mediator = mediator;
        }

        public void SendMessage(string message)
        {
            _mediator.SendMessage(message, this);
        }

        public void ReceiveMessage(string message)
        {
            Console.WriteLine(message);
        }

    }
}
