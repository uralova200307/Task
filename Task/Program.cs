﻿using System.ComponentModel.Design;

namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            Console.Write("Enter the length: ");
            int row = int.Parse(Console.ReadLine());
            Console.Write("Enter the K: ");
            int k = int.Parse(Console.ReadLine());
            int[] array1 = new int[row];
            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = random.Next(1, 20);
                Console.Write($" {array1[i]}");

            }
            Console.WriteLine();
            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] % k == 0)
                {
                    Console.Write($" {array1[i]}");
                }
            }
        }
    }
}