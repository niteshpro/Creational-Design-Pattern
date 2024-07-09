

namespace BuilderDesignPattern
{
    public class WoodenHouseBuilder : IHouseBuilder
    {
        private House house = new House();

        public void BuildWalls()
        {
            house.Walls = "Wooden Walls";
        }

        public void BuildRoof()
        {
            house.Roof = "Wooden Roof";
        }

        public void BuildDoors()
        {
            house.Doors = "Wooden Doors";
        }

        public void BuildWindows()
        {
            house.Windows = "Wooden Windows";
        }

        public House GetHouse()
        {
            return house;
        }
    }

    public class StoneHouseBuilder : IHouseBuilder
    {
        private House house = new House();

        public void BuildWalls()
        {
            house.Walls = "Stone Walls";
        }

        public void BuildRoof()
        {
            house.Roof = "Stone Roof";
        }

        public void BuildDoors()
        {
            house.Doors = "Stone Doors";
        }

        public void BuildWindows()
        {
            house.Windows = "Stone Windows";
        }

        public House GetHouse()
        {
            return house;
        }
    }

}

