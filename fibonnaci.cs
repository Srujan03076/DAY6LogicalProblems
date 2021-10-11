using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


        namespace P_1_fibonacciSeries
    {
        class P_1_fibonacciSeries
        {
            static void Main(string[] args)
            {
                int num1 = 0, num2 = 1, num3, i, N;
                Console.Write("Enter the N: ");


                N = int.Parse(Console.ReadLine());
                Console.Write(num1 + " " + num2 + " ");


                for (i = 2; i < N; ++i)
                {
                    num3 = num1 + num2;
                    Console.Write(num3 + " ");
                    num1 = num2;
                    num2 = num3;
                }
            }
        }
    }


