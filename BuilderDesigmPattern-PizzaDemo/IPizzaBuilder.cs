using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesigmPattern_PizzaDemo
{
    public interface IPizzaBuilder
    {
        void SetSize(string size);
        void SetCrust(string crust);
        void SetExtraCheese(bool extraCheese);
        void SetToppings(List<string> toppings);
        Pizza GetPizza();
    }

}
