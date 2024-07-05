using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDesignPattern
{
    public class AnimalFactory
    {
        public IAnimal GetAnimal(string animalType)
        {
            switch (animalType.ToLower())
            {
                case "dog":
                    return new Dog();
                case "cat":
                    return new Cat();
                default:
                    throw new ArgumentException("Invalid animal type");
            }
        }
    }
}
