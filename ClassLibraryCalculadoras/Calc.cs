using CalcCore.Interfaces;

namespace ClassLibraryCalculadoras
{
    public class Calc : ICalc
    {
        public int Suma(int a, int b)
        {
            return a + b;
        }

        public int Resta(int a, int b)
        {
            return a - b;
        }

        public int Mult(int a, int b)
        {
            return a * b;
        }

        public int Div(int a, int b)
        {
            return a / b;
        }
    }
}