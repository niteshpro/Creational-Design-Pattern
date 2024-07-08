namespace AbstractFactory
{
    // Abstract Factory
    public abstract class FurnitureFactory
    {
        public abstract Chair CreateChair();
        public abstract Sofa CreateSofa();
    }
}
