using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class ConsoleUi 
    {
        public static void Menu()
        {
            string menu = "1) Fender\n2) Gibson\n3) Solar\n4) Jackson\n";
            Console.Write(menu);
        }
        public static string GetBrand()
        {
            Console.Write("Enter the number to select a brand: ");
            string? brand = Console.ReadLine();
            return brand;
        }

        

        

    }
}
