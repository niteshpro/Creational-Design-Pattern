using SingletonDesignPattern;
using System;

namespace DesignPattern
{
    public class Program
    {
        public static void Main()
        {

            Console.WriteLine("Singleton Design Pattern");

            Parallel.Invoke( //adding this to invoke both method simultaneously 
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

        private static void GetEagerStudent()
        {
            EagerLoadingSingleton StudentClass = EagerLoadingSingleton.GetLoadingInstance;
            StudentClass.PrintDetails("From Student Class");
        }

        private static void GetEagerEmployee()
        {
            EagerLoadingSingleton EmployeeClass = EagerLoadingSingleton.GetLoadingInstance;
            EmployeeClass.PrintDetails("From Employee Class");
        }
    }
}