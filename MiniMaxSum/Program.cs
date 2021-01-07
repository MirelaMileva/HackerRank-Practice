using System;
using System.Linq;

namespace MiniMaxSum
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            ;

            miniMaxSum(arr);
        }

        static void miniMaxSum(int[] arr)
        {
            Array.Sort(arr);

            long maxSum = 0;
            long minSum = 0;

            for (int i = 0; i < arr.Length; i++)
            {

                if (i > 0)
                {
                    maxSum += arr[i];
                }

                if (i < 4)
                {
                    minSum += arr[i];
                }

            }

            Console.WriteLine($"{minSum} {maxSum}");
        }
    }
}
