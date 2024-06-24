using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.ViewModel
{
    using Calculator.Model.Operations;
    using Model;
    using System.Windows.Input;

    public class Calculating
    {
        private readonly ICalculator _calculator;

        public Calculating(ICalculator calculator)
        {
            _calculator = calculator ?? throw new ArgumentNullException(nameof(calculator));
        }

        public decimal Execute(string symbol, decimal firstArg, decimal secondArg)
        {
            return _calculator.ExceuteOperationBySymbol(symbol, firstArg, secondArg);
        }

    }
}
