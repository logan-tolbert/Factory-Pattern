using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public static class GuitarFactory
    {
        public static IGuitar GetGuitar(string userInput)
        {
            switch (userInput)
            {
                case("1"):
                    return new FenderGuitar();
                    break;
                case("2"):
                    return new GibsonGuitar();
                    break;
                case("3"):
                    return new SolarGuitar();
                    break;
                case("4"):
                    return new JacksonGuitar();
                    break;
                default:
                    return new FenderGuitar();
            }
        }
    }
}
