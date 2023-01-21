﻿using System;

namespace DataStructAlgorithmPrograms_244
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Data Structure Algorithm Problems");

            BinarySearch bs = new BinarySearch();
            string[] arr = { "apple", "ball", "cat", "dog", "egg", "fish" };
            Console.WriteLine("Please enter a string to be searched :");
            string key = Console.ReadLine();
            int result = bs.Binary_Search(arr, key);
            if (result == -1)
                Console.WriteLine("Element not present");
            else
                Console.WriteLine("Element found at " + "index " + result);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}

