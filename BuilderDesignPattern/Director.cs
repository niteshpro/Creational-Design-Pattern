using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern
{
    public class ConstructionDirector
    {
        private IHouseBuilder houseBuilder;

        public ConstructionDirector(IHouseBuilder builder)
        {
            houseBuilder = builder;
        }

        public void ConstructHouse()
        {
            houseBuilder.BuildWalls();
            houseBuilder.BuildRoof();
            houseBuilder.BuildDoors();
            houseBuilder.BuildWindows();
        }

        public House GetHouse()
        {
            return houseBuilder.GetHouse();
        }
    }

}
