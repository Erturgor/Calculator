using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Model.Operations
{
    public class Addition
    {
        public string Name { get; private set; } = "Addition";
        public string Symbol { get; private set; } = "+";

        public decimal Execute(decimal firstArg, decimal secondArg)
        {
            return firstArg + secondArg;
        }
    }
}
