using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    class PerfectNumber
    {
        public static void ReadInput()
        {
            Console.WriteLine("Enter the Number to check whether it is Perfect Number or Not");//
            int num = Convert.ToInt32(Console.ReadLine());
            FindPerfectNumber(num);
        }
        private static void FindPerfectNumber(int number)
        {
            int sum_of_divisors = 0;
            
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)//this loops used to check the divisors of Number
                {
                    sum_of_divisors += i;    
                }
            }
            //using ternary operator to check sum of divisors and number or equal
            Console.WriteLine((sum_of_divisors==number)?$"{number} is a perfect No": $"{number} is a not perfect No");
        }

    }
}
