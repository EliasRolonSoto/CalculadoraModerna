﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcCore.Interfaces
{
    public interface ICalc
    {
        public EventHandler Procesando { get; set; }
        public EventHandler Termino { get; set; }

        int Suma (int a, int b);

        int Resta(int a, int b);

        int Mult(int a, int b);

        int Div(int a, int b);
    }
}
