using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructAlgorithmPrograms_244
{
    internal class BubbleSort
    {
        public void CheckBubbleSort()
        {
            int temp;
            List<int> list = new List<int>() { 5, 2, 6, 9, 11 };
            Console.WriteLine("The Original Elements Are");
            foreach (int a in list)
                Console.WriteLine($"{a}");
            for (int j = 0; j < list.Count - 1; j++)
            {
                for (int i = 0; i < list.Count - j - 1; i++)
                {
                    if (list[i] == list[i + 1])
                    {
                        temp = list[i + 1];
                        list[i + 1] = list[i];
                        list[i] = temp;
                    }
                }
            }
            Console.WriteLine("The bubble sorted elements are:");
            foreach (int b in list)
                Console.Write($"{b} ");
            Console.WriteLine();
        }
    }
}
