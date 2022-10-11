using System;

namespace A074
{
    class Program
    {
        static void Main(string[] args)
        {
            DrawPyramid(3);
            DrawPyramid(5);
            DrawPyramid(7);
        }

        static void DrawPyramid(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j < n; j++)
                    Console.Write(" ");
                for (int k = 1; k <= 2 * i - 1; k++)
                    Console.Write("*");
                Console.WriteLine();
            }
        }
    }
}
