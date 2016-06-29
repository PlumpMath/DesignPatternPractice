using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPractice
{
    public class ConcreteFactoryB : IAbstractFactory
    {
        public AbstractProductA CreateProductA()
        {
            Console.WriteLine("ProductA2");
            return new ProductA2();
        }

        public AbstractProductB CreateProductB()
        {
            Console.WriteLine("ProductB2");
            return new ProductB2();
        }
    }
}
