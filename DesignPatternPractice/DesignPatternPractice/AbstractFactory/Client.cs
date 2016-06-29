namespace DesignPatternPractice
{
    public class Client
    {
        private AbstractProductA pa;
        private AbstractProductB pb;

        public Client(IAbstractFactory factory)
        {
            pa = factory.CreateProductA();
            pb = factory.CreateProductB();
        }
    }
}
