using CalcCore.Interfaces;
using CalcVieja;
using CalcSuperpower;

namespace App1
{
    internal class Program
    {
        private static ICalc _calc;
        static void Main(string[] args)
        {
            _calc = new CalcSuperpower.CalcSuperpower();

            //Console.WriteLine($"[App1] Add {_calc.Add (1,1)}");           

            var m = new Manager(_calc);
            m.PrintSuma();
            m.PrintResta();
            m.PrintMult();
            m.PrintDiv();

            m.SetCalc(new CalcVieja.Calc());
            m.PrintSuma();
            m.PrintResta();
            m.PrintMult();
            m.PrintDiv();

            Console.ReadKey();
        }
    }



}