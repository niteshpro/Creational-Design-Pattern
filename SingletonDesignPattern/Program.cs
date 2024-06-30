using SingletonDesignPattern;
using System;

namespace DesignPattern
{
    public class Program
    {
        public static void Main()
        {
            
            Console.WriteLine("Singleton Design Pattern");

            Singleton EmployeeClass = Singleton.GetInstance;
            EmployeeClass.PrintDetails("From Employee Class");

            Singleton StudentClass = Singleton.GetInstance;
            StudentClass.PrintDetails("From Student Class");

            Console.ReadLine();
        }
    }
}