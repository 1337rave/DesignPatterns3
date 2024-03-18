using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns3.Mediator
{
    public interface IMediator
    {
        void Send(string message, Colleague colleague);
    }
}