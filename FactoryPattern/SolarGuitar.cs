using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class SolarGuitar : IGuitar
    {
        public void TestGuitar()
        {
            Console.WriteLine("Brand retrieved: Solar\nTesting guitar....");
        }
    }
}
