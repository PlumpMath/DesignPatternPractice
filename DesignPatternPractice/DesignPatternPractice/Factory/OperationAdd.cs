using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPractice
{
    public class OperationAdd : Calculator
    {
        public override string Operation
        {
            get { return OperationType.Add.ToString(); }
        }
    }
}
