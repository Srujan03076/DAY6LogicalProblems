using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace couponNumber
{
    class P_5_couponNumber
    {
        public static void couponNumber()
        {
            int N, count = 0;


            Console.Write("Enter number:");
            N = int.Parse(Console.ReadLine());

            int[] numbers = new int[N];

            for (int i = 1; i < N; i++)
            {
                Random random = new Random();
                numbers[i] = random.Next(1, N + 1);

                bool isDuplicate = false;
                for (int j = 0; j < i; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        isDuplicate = true;
                        break;
                    }
                }

                if (!isDuplicate)
                {
                    //Console.WriteLine(numbers[i]);                     //for checking
                    count++;
                }

            }
            Console.WriteLine("Total random number needed to have all distinct numbers is : " + count);

        }
        static void Main(string[] args)
        {
            P_5_couponNumber.couponNumber();
        }
    }

}
