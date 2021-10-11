using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_3_PrimeNumber
{
    class P_3_PrimeNumber
    {
        static void Main(string[] args)
        {
            int N, i, remainder, a = 0;
            Console.Write("Enter number you want to check: ");
            N = int.Parse(Console.ReadLine());


            for (i = 2; i < N; i++)
            {
                remainder = N % i;


                if (remainder == 0)
                {
                    Console.WriteLine(+N + " is a not prime number.");
                    a = 1;
                    break;
                }

            }
            if (a == 0)
            {
                Console.WriteLine(+N + " is a prime number.");
            }

        }
    }
}