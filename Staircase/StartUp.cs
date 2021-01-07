using System;

namespace Staircase
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            staircase(num);
        }

        public static void staircase(int num)
        {
            int col = 1;

            for (int row = 0; row < num; row++)
            {
                Console.WriteLine(new string(' ', num - row - 1) + new string('#', col));

                col++;
            }
        }
    }
}