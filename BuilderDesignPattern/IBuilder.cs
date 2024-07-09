using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern
{
    public interface IHouseBuilder
    {
        void BuildWalls();
        void BuildRoof();
        void BuildDoors();
        void BuildWindows();
        House GetHouse();
    }

}
