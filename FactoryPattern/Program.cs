namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Charp Guitars!");
            ConsoleUi.Menu();
            string brand = ConsoleUi.GetBrand();

            IGuitar guitar = GuitarFactory.GetGuitar(brand);
            guitar.TestGuitar();
        }
    }
}
