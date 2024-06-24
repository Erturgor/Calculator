using Calculator.Model.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Model
{
    public interface ICalculator
    {
        List<IOperation> Operations { get; }
        void AddOperation(IOperation operation);
        string[] SymbolsOfOperations { get; }
        decimal ExceuteOperationBySymbol(string symbol, decimal firstArg, decimal secondArg);
        decimal Calculate(IOperation operation, decimal firstArg, decimal secondArg);
    }
}
