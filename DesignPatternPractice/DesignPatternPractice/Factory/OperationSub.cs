using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPractice
{
    public class OperationSub : Calculator
    {
        public override string Operation
        {
            get { return OperationType.Sub.ToString(); }
        }
    }
}
