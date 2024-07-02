using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern
{
    public sealed class EagerLoadingSingleton
    {
        private static int counter = 0;
        private static readonly EagerLoadingSingleton instance=new EagerLoadingSingleton();
        public static EagerLoadingSingleton GetLoadingInstance
        {
            get {

                return instance;
            }
        }
        private EagerLoadingSingleton()
        {
            counter++;
            Console.WriteLine("Total instance: " + counter);
        }
        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
}
