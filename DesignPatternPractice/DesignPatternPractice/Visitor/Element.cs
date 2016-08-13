namespace DesignPatternPractice
{
    public abstract class Element
    {
        public abstract void Accept(Visitor visitor);
    }
}