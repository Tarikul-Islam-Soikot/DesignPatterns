using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatorPattern.Interfaces;

namespace MediatorPattern.Implementation
{
    public class ChildMediator : IChildMediator
    {
        private IPerson _father;
        private IPerson _mother;

        public void SetFather(IPerson father)
        {
            _father = father;
        }

        public void SetMother(IPerson mother)
        {
            _mother = mother;
        }

        public void SendMessage(string message, IPerson person)
        {
            if (person == _father)
            {
                _mother.ReceiveMessage($"{nameof(Father)} says: " + message);
            }

            if (person == _mother)
            {
                _father.ReceiveMessage($"{nameof(Mother)} says: " + message);
            }
        }

    }
}
