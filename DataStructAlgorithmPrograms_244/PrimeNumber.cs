using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructAlgorithmPrograms_244
{
    internal class PrimeNumber
    {
        public static void Prime()
        {
            int number, i, ctr, stno, enno;
            Console.Write("Input starting number : ");
            stno = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input ending number : ");
            enno = Convert.ToInt32(Console.ReadLine());
            Console.Write("The prime numbers between {0} and {1} are : \n", stno, enno);

            for (number = stno; number <= enno; number++)
            {
                ctr = 0;

                for (i = 2; i <= number / 2; i++)
                {
                    if (number % i == 0)
                    {
                        ctr++;
                        break;
                    }
                }

                if (ctr == 0 && number != 1)
                    Console.Write("{0} \n", number);
            }
        }
    }
}
