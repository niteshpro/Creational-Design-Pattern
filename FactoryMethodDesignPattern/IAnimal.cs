using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDesignPattern
{
    public interface IAnimal
    {
        void Speak();
    }

    // Concrete Product classes
    public class Dog : IAnimal
    {
        public void Speak()
        {
            Console.WriteLine("Woof! Woof!");
        }
    }

    public class Cat : IAnimal
    {
        public void Speak()
        {
            Console.WriteLine("Meow! Meow!");
        }
    }
}
