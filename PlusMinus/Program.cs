using System;
using System.Linq;

namespace PlusMinus
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int[] arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            decimal p = 0M;
            decimal n = 0M;
            decimal z = 0M;

            for (int i = 0; i < number; i++)
            {
                if (arr[i] > 0)
                {
                    p++;
                }
                else if (arr[i] == 0)
                {
                    z++;
                }
                else if (arr[i] < 0)
                {
                    n++;
                }
            }

            decimal pos = p / number;
            decimal neg = n / number;
            decimal zeros = z / number;

            Console.WriteLine($"{pos:f6}");
            Console.WriteLine($"{neg:f6}");
            Console.WriteLine($"{zeros:f6}");
        }
    }
}