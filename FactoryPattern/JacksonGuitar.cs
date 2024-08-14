using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class JacksonGuitar : IGuitar
    {
        public void TestGuitar()
        {
            Console.WriteLine("Brand retrieved: Jackson\nTesting guitar....");
        }
    }
}
