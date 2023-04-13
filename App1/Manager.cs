using CalcCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    public class Manager
    {
        private ICalc _calc;

        public Manager (ICalc calc)
        {
            _calc = calc;
        }

        public void SetCalc(ICalc calc)
        {
            _calc = calc;
        }

        public void PrintSuma()
        {
            Console.WriteLine($"[App1] Suma {_calc.Suma(1, 1)}");
        }
        public void PrintResta()
        {
            Console.WriteLine($"[App1] Resta {_calc.Resta(4, 3)}");
        }
        public void PrintMult()
        {
            Console.WriteLine($"[App1] Multiplicacion {_calc.Mult(2, 8)}");
        }
        public void PrintDiv()
        {
            Console.WriteLine($"[App1] Division {_calc.Div(1, 1)}");
        }
    }
}
