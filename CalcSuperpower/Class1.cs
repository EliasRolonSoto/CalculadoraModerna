using CalcCore.Interfaces;

namespace CalcSuperpower
{
    public class CalcSuperpower : ICalc
    {
        public int Suma(int a, int b)
        {
            return a + b + 10000;
        }

        public int Resta(int a, int b)
        {
            return a - b + 10000;
        }

        public int Mult(int a, int b)
        {
            return a * b + 10000;
        }

        public int Div(int a, int b)
        {
            return a / b + 10000;
        }
    }
}