using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace P_4_reverseNumber
{
    class P_4_reverseNumber
    {
        static void Main(string[] args)
        {
            int number, reverse = 0;
            Console.Write("Enter the number: ");
            number = Convert.ToInt32(Console.ReadLine());

            int remainder;
            while (number != 0)
            {
                remainder = number % 10;
                reverse = (reverse * 10) + remainder;
                number = number / 10;

            }
            Console.Write("Reversed Number: " + reverse);
        }
    }
}