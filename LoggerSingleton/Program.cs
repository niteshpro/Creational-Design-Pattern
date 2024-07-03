using System;

namespace LoggerSingleton
{
    public class Program
    {
        public static void Main()
        {
            Log Ilog = null;

            int num2 = 0;

            int GetDivide(int a, int b)
            {
                Ilog = Log.GetInstance;
                //Obj for Log class only gets created at the time of demand
                return a / b;
            }

            try
            {
                                
                int num1 = Convert.ToInt32(Console.ReadLine());
                var result = GetDivide(num1, num2);
                Console.WriteLine($"Multiplication Result: {result}");
            }
            catch (Exception ex)
            {
                Ilog.LogException(ex.ToString());
            }
        }
    }
}
