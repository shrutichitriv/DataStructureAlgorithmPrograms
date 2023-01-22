using System;

namespace DataStructAlgorithmPrograms_244
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Data Structure Algorithm Problems");

            //BinarySearch bs = new BinarySearch();
            //string[] arr = { "apple", "ball", "cat", "dog", "egg", "fish" };
            //Console.WriteLine("Please enter a string to be searched :");
            //string key = Console.ReadLine();
            //int result = bs.Binary_Search(arr, key);
            //if (result == -1)
            //    Console.WriteLine("Element not present");
            //else
            //    Console.WriteLine("Element found at " + "index " + result);
            //Console.WriteLine(result);
            //Console.ReadLine();

            //BubbleSort bubbleSort = new BubbleSort();
            //bubbleSort.CheckBubbleSort();
            //Console.ReadLine();

            int[] Array = { 2, 8, 9, 5, 6, 98, 45 };//Accept Array Value For Sorting
            Console.WriteLine("Before Sort Array Is");
            foreach (int i in Array)//Print Before Sort Elements
            {
                Console.WriteLine(i);
            }

            InsertionSort.Sort(Array);//Call Sort Function
            InsertionSort.DisplayArray(Array);//Call Display Function0
        }
    }
}

