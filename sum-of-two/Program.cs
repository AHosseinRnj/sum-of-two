using System;

namespace sum_of_two
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = new int[] { 2, 7, 11, 15 };
            var target = 9;

            var output = SumOfTwoBruteForce(input, target);

            Console.Write("Result of Bruteforce Method: ");
            foreach (var index in output)
            {
                Console.Write($"{index} ");
            }
        }

        static int[] SumOfTwoBruteForce(int[] input, int target)
        {
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < input.Length; j++)
                {
                    if (input[i] + input[j] == target)
                        return new int[] { i, j };
                }
            }

            return new int[] { };
        }
    }
}