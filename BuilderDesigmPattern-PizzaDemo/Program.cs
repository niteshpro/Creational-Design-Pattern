

namespace BuilderDesigmPattern_PizzaDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a Margherita pizza
            IPizzaBuilder builder = new PizzaBuilder();
            PizzaDirector director = new PizzaDirector(builder);
            director.BuildMargherita();
            Pizza margherita = director.GetPizza();
            Console.WriteLine(margherita.ToString());

            // Create a Pepperoni pizza
            builder = new PizzaBuilder();
            director = new PizzaDirector(builder);
            director.BuildPepperoni();
            Pizza pepperoni = director.GetPizza();
            Console.WriteLine(pepperoni.ToString());
        }
    }

}