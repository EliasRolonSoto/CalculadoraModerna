using ClassLibraryCalculadoras;

namespace App2
{
    internal class Program2
    {
        static void Main(string[] args)
        {
            var c = new Calc();

            Console.WriteLine($"[App2] Add {c.Suma(1, 1)}");

            Console.ReadKey();
        }
    }
}

