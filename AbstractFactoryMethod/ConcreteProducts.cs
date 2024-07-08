namespace AbstractFactory
{
    // Concrete Product A1
    public class VictorianChair : Chair
    {
        public override string SitOn()
        {
            return "Sitting on a Victorian chair.";
        }
    }

    // Concrete Product A2
    public class ModernChair : Chair
    {
        public override string SitOn()
        {
            return "Sitting on a Modern chair.";
        }
    }

    // Concrete Product B1
    public class VictorianSofa : Sofa
    {
        public override string LieOn()
        {
            return "Lying on a Victorian sofa.";
        }
    }

    // Concrete Product B2
    public class ModernSofa : Sofa
    {
        public override string LieOn()
        {
            return "Lying on a Modern sofa.";
        }
    }
}
