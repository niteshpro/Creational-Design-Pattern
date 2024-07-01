
namespace SingletonDesignPattern
{
    public sealed class Singleton 
        //we have used seal do this class can't be inherited
        //and child class don't end up creting multiple obj or modify the constructor
    {

        private static int counter=0;
        
        private static Singleton instance = null;
        private static readonly object obj = new();

        public static Singleton GetInstance
            //this is a Property of Class Singleton which is having getter for the
            //constructor
        {
            get {
                if (instance == null) 
                {
                    lock (obj)
                    {
                        if (instance == null)
                        {
                            instance = new Singleton();

                        }
                    }
                }
                return instance;
            }
        
        }

        private Singleton()
            //we have made the Constructor private so it can't be accessed directly from 
            //other classes
        {
            counter++;
            Console.WriteLine("Number of objects " + counter);
        }
        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
}
