using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPractice
{
    public class ConcreteFactoryA : IAbstractFactory
    {
        public AbstractProductA CreateProductA()
        {
            Console.WriteLine("ProductA1");
            return new ProductA1();
        }

        public AbstractProductB CreateProductB()
        {
            Console.WriteLine("ProductB1");
            return new ProductB1();
        }
    }
}
