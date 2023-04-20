using CalcCore.Interfaces;

namespace CalcVieja
{
    public class Calc : ICalc
    {
        public EventHandler Procesando { get; set; }
        public EventHandler Termino { get; set; }


        public int Suma(int a, int b)
        {
            if (Procesando != null)
            {
                Procesando.Invoke(this, new EventArgs());
            }

            //Thread.Sleep(5000);

            var resultado = a + b;

            if (Termino != null)
            {
                Termino.Invoke(this, new EventArgs());
            }


            return resultado;
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