using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            ClientMethod(new VictorianFurnitureFactory());
            Console.WriteLine();
            ClientMethod(new ModernFurnitureFactory());
        }

        public static void ClientMethod(FurnitureFactory factory)
        {
            var chair = factory.CreateChair();
            var sofa = factory.CreateSofa();

            Console.WriteLine(chair.SitOn());
            Console.WriteLine(sofa.LieOn());
        }
    }
}
