using SingletonDesignPattern;
using System;

namespace DesignPattern
{
    public class Program
    {
        public static void Main()
        {

            Console.WriteLine("Singleton Design Pattern");

            Parallel.Invoke(
                () => GetEmployee(),
                () => GetStudent()
            );

            Console.ReadLine();
        }

        private static void GetStudent()
        {
            Singleton StudentClass = Singleton.GetInstance;
            StudentClass.PrintDetails("From Student Class");
        }

        private static void GetEmployee()
        {
            Singleton EmployeeClass = Singleton.GetInstance;
            EmployeeClass.PrintDetails("From Employee Class");
        }
    }
}