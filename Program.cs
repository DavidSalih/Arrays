/*
 Author: David Salih
 Date: 9/19/2019
 Description: Arrays
 */

using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[25];
            for (int i = 0; i < 25; i++)
            {
                array[i] = i + 1;
            }
            foreach (int number in array)
            {
                int i = number;
                Console.WriteLine("value = {1}", i, number);
            }
        }
    }
}
