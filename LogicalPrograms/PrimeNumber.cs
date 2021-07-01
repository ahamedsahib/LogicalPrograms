using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    class PrimeNumber
    {
        public static void ReadInput()
        {
            Console.WriteLine("Enter the Number To check Prime or Not");
            int num = Convert.ToInt32(Console.ReadLine());
            FindPrimeNumber(num);

        }
        private static void FindPrimeNumber(int num)
        {
            int flag = 0;//used to check the no is prime
            for (int i = 2; i < num / 2; i++)
            {
                if (num % i == 0)//if num divisible by other than 1 and same no itself it terminates
                {
                    Console.WriteLine("{0} is not a prime number", num);
                    flag = 1;
                    break;
                }
            }
            if (flag == 0)
            {
                Console.WriteLine("{0} is a prime number", num);
            }
    }   }
}
