using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPractice
{
    public enum OperationType 
    {
        Add,
        Sub,
        Mul,
        Div
    }

    public static class CalculatorFactory
    {
        public static int CalculateAnswer(OperationType type, int numberA, int numberB) 
        {
            switch (type) 
            {
                case OperationType.Add:
                    return numberA + numberB;
                case OperationType.Sub:
                    return numberA - numberB;
                case OperationType.Mul:
                    return numberA * numberB;
                case OperationType.Div:
                    return numberA / numberB;
                default:
                    return 0;
            }
        }

        public static Calculator CreatOperation(string operater) 
        {
            switch (operater)
            {
                case "+":
                    return new OperationAdd();
                case "-":
                    return new OperationSub();
                case "*":
                    return new OperationMul();
                case "/":
                    return new OperationDiv();
                default:
                    return null;
            }
        }
    }
}
