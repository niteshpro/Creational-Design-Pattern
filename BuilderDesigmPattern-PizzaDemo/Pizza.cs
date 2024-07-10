using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesigmPattern_PizzaDemo
{
    public class Pizza
    {
        public string Size { get; set; }
        public string Crust { get; set; }
        public bool ExtraCheese { get; set; }
        public List<string> Toppings { get; set; }

        public override string ToString()
        {
            return $"Pizza [Size={Size}, Crust={Crust}, ExtraCheese={ExtraCheese}, Toppings={string.Join(", ", Toppings)}]";
        }
    }
}
