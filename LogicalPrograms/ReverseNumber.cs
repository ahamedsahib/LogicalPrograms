using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    class ReverseNumber
    {
        public static void ReadInput()
        {
            Console.WriteLine("Enter the Number You want to Reverse");
            int num = Convert.ToInt32(Console.ReadLine());
            Reverse(num);
        }
        private static void Reverse(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                int remainder = number % 10;//it is used to get remaider of no (i.e)123 % 10=3
                sum = sum * 10 + remainder;//sum=0+3=3
                number = number / 10;//123/10=12 and goes back loop until number becomes 0
            }
            Console.WriteLine($"The Number after reserved {sum} ");
        }
    }
}
