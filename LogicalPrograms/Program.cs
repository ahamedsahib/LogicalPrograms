using System;

namespace LogicalPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Logical Programs");
            
            Console.WriteLine("Choose The Program You Want Run");
            Console.WriteLine("1)Fibanocci Series \n2)Perfect Number \n3)Exit");
            Console.WriteLine("Choose one");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Fibanocci.ReadInput();
                    break;
                case 2:
                    PerfectNumber.ReadInput();
                    break;
                default:
                    Console.WriteLine("Choose Correct Option");
                    break;
            }

        }
    }
}
