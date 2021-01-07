using System;
using System.Linq;

namespace AVeryBigSum
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int arrCount = int.Parse(Console.ReadLine());

            long[] arr = Console.ReadLine()
                .Split(' ')
                .Select(long.Parse)
                .ToArray();

            long result = BigSum(arr, arrCount);

            Console.WriteLine(result);
        }

        public static long BigSum(long[] arr, int arrCount)
        {
            long result = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                result += arr[i];
            }

            return result;
        }
    }
}
