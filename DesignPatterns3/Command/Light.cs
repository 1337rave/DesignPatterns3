using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns3.Command
{
    public class Light
    {
        public void TurnOn()
        {
            Console.WriteLine("Світло увімкнено.");
        }

        public void TurnOff()
        {
            Console.WriteLine("Світло вимкнено.");
        }
    }

}