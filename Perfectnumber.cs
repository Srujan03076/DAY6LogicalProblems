using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfectNumber
{
    class P_2_PerfectNumber
    {
        static void Main(string[] args)
        {
            int number, i;
            Console.Write("Enter the number: ");
            number = int.Parse(Console.ReadLine());

            int sum = 0;
            for (i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    sum = sum + i;
                    Console.WriteLine("{0}", i);
                }
            }
            Console.WriteLine("The sum of the divisor is : {0}", sum);
            if (sum == number)
            {
                Console.WriteLine(+number + "Is Perfect number");
            }
            else
                Console.WriteLine(+number + "Is Not perfect");



        }
    }
}