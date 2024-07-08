namespace AbstractFactory
{
    // Concrete Factory 1
    public class VictorianFurnitureFactory : FurnitureFactory
    {
        public override Chair CreateChair()
        {
            return new VictorianChair();
        }

        public override Sofa CreateSofa()
        {
            return new VictorianSofa();
        }
    }

    // Concrete Factory 2
    public class ModernFurnitureFactory : FurnitureFactory
    {
        public override Chair CreateChair()
        {
            return new ModernChair();
        }

        public override Sofa CreateSofa()
        {
            return new ModernSofa();
        }
    }
}
