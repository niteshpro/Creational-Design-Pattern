namespace BuilderDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // Build a wooden house
            IHouseBuilder woodenBuilder = new WoodenHouseBuilder();
            ConstructionDirector director = new ConstructionDirector(woodenBuilder);
            director.ConstructHouse();
            House woodenHouse = director.GetHouse();
            Console.WriteLine(woodenHouse.ToString());

            // Build a stone house
            IHouseBuilder stoneBuilder = new StoneHouseBuilder();
            director = new ConstructionDirector(stoneBuilder);
            director.ConstructHouse();
            House stoneHouse = director.GetHouse();
            Console.WriteLine(stoneHouse.ToString());
        }
    }

}