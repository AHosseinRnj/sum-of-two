﻿using System;
using System.Collections;

namespace sum_of_two
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = new int[] { 2, 7, 11, 15 };
            var target = 9;

            var output = SumOfTwoByBruteForce(input, target);
            Console.Write("Result of Bruteforce Method: ");
            foreach (var index in output)
            {
                Console.Write($"{index} ");
            }

            Console.WriteLine();

            output = SumOfTwoByPointers(input, target);
            Console.Write("Result of Two Pointers Method: ");
            foreach (var index in output)
            {
                Console.Write($"{index} ");
            }

            Console.WriteLine();

            output = SumOfTwoByHashTable(input, target);
            Console.Write("Result of Hashtable Method: ");
            foreach (var index in output)
            {
                Console.Write($"{index} ");
            }

            Console.ReadLine();
        }

        static int[] SumOfTwoByBruteForce(int[] input, int target)
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

        // Array has to be sorted before using this Method.
        static int[] SumOfTwoByPointers(int[] input, int target)
        {
            var leftPtr = 0;
            var rightPtr = input.Length - 1;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[leftPtr] + input[rightPtr] == target)
                    return new int[] { leftPtr, rightPtr };

                if (input[leftPtr] + input[rightPtr] > target)
                    rightPtr--;

                if (input[leftPtr] + input[rightPtr] < target)
                    leftPtr++;
            }

            return new int[] { };
        }

        static int[] SumOfTwoByHashTable(int[] input, int target)
        {
            var hashTable = new Hashtable();

            for (int i = 0; i < input.Length; i++)
            {
                if (hashTable.ContainsKey(target - input[i]))
                    return new int[] { (int)hashTable[target - input[i]], i };
                else
                    hashTable.Add(input[i], i);
            }

            return new int[] { };
        }
    }
}