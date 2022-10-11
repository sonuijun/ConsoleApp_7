using System;

namespace A075
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 1; i <= 10; i++)
            {
                sum += Factorial(i);
                Console.WriteLine("{0,2}! : {1,10:NO}", i, Factorial(i));
            }
            Console.WriteLine("1!~10!의 합= {0,8:NO", sum);
        }

        private static int Factorial(int n)
        {
            int fact = 1;
            for (int i = 1; i <= n; i++)
                fact *= i;
            return fact;
        }
    }
}
  
