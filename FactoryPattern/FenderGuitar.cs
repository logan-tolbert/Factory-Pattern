using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class FenderGuitar : IGuitar
    {
        public void TestGuitar()
        {
            Console.WriteLine("Brand retrieved: Fender\nTesting guitar....");
        }
    }
}
