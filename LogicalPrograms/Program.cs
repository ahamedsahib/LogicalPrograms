using System;

namespace LogicalPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            int option;
            Console.WriteLine("Welcome to Logical Programs");
            do
            {
                Console.WriteLine("Choose The Program You Want Run");
                Console.WriteLine("1)Fibanocci Series \n2)Perfect Number \n3)PrimeNumber\n4)ReverseNumber\n5)CouponNumberGenerator\n6)Stopwatch\n7)Exit");
                Console.WriteLine("Choose one");
                option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Fibanocci.ReadInput();
                        break;
                    case 2:
                        PerfectNumber.ReadInput();
                        break;
                    case 3:
                        PrimeNumber.ReadInput();
                        break;
                    case 4:
                        ReverseNumber.ReadInput();
                        break;
                    case 5:
                        CouponNumber.ReadInput();
                        break;
                    case 6:
                        StopWatch.Stopwatch();
                        break;
                    default:
                        Console.WriteLine("Choose Correct Option");
                        break;
                }

            } while (option <= 6);
        }
    }
}
