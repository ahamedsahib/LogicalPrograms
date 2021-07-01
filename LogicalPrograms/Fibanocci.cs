using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    class Fibanocci
    {
        public static void ReadInput()
        {
            Console.WriteLine("Enter the Number of the Fibanocci Series you want");
            int num = Convert.ToInt32(Console.ReadLine());//used to get the no of terms
            Fibanocci fibanocci = new Fibanocci();
            fibanocci.FibanocciSeries(num);

        }

        private void FibanocciSeries(int limit)
        {
            int sum=0;
            int previousTerm1 = 0;
            int previousTerm2 = 1;
            for (int i = 2; i <= limit; i++)//limit will be the Nth term provided by user
            {
                sum = previousTerm1 + previousTerm2;//sum is used to add the sum of previous 2 terms
                Console.WriteLine($"The sum of {previousTerm1} + {previousTerm2} ----> {sum}");
                previousTerm1 = previousTerm2;//previous 1st term is replaced by the next term(followed by the next of prevoius 1st term)
                previousTerm2 = sum;//the next term is replaced by sum to maintain the sum of prevoius results
            }
            Console.WriteLine($"The fibanocci Series of {limit} is {sum}");
        }
        
    }
}
