using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesigmPattern_PizzaDemo
{
    public class PizzaDirector
    {
        private IPizzaBuilder pizzaBuilder;

        public PizzaDirector(IPizzaBuilder builder)
        {
            pizzaBuilder = builder;
        }

        public void BuildMargherita()
        {
            pizzaBuilder.SetSize("Medium");
            pizzaBuilder.SetCrust("Thin");
            pizzaBuilder.SetExtraCheese(true);
            pizzaBuilder.SetToppings(new List<string> { "Tomato", "Mozzarella" });
        }

        public void BuildPepperoni()
        {
            pizzaBuilder.SetSize("Large");
            pizzaBuilder.SetCrust("Thick");
            pizzaBuilder.SetExtraCheese(false);
            pizzaBuilder.SetToppings(new List<string> { "Pepperoni", "Cheese" });
        }

        public Pizza GetPizza()
        {
            return pizzaBuilder.GetPizza();
        }
    }

}
