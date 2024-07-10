using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesigmPattern_PizzaDemo
{
    public class PizzaBuilder : IPizzaBuilder
    {
        private Pizza pizza = new Pizza();

        public void SetSize(string size)
        {
            pizza.Size = size;
        }

        public void SetCrust(string crust)
        {
            pizza.Crust = crust;
        }

        public void SetExtraCheese(bool extraCheese)
        {
            pizza.ExtraCheese = extraCheese;
        }

        public void SetToppings(List<string> toppings)
        {
            pizza.Toppings = toppings;
        }

        public Pizza GetPizza()
        {
            return pizza;
        }
    }

}
