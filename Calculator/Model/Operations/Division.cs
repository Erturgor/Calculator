﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Model.Operations
{
    public class Division : IOperation
    {
        public string Name { get; private set; } = "Division";

        public string Symbol { get; private set; } = "/";

        public decimal Execute(decimal firstArg, decimal secondArg)
        {
            return (secondArg == 0.0M) ? throw new DivideByZeroException("Nie można dzielić przez zero") : firstArg / secondArg;

        }
    }
}
