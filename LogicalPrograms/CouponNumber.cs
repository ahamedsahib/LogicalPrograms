using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    class CouponNumber
    {
        public static void ReadInput()
        {
            Console.WriteLine("Enter the Number of Distinct Coupon You Want");//
            int num = Convert.ToInt32(Console.ReadLine());
            CouponNumberGenerator(num);
        }
        private static void CouponNumberGenerator(int num)
        {
            int count = 1;
            int coupon;
            List<int> distinct_coupon = new List<int>();
            Random random = new Random();
            do
            {
                coupon = random.Next(1, num);// to create random numbeer from specific range
                if (!distinct_coupon.Contains(coupon))//to check if generated no is already present in the list
                {
                    distinct_coupon.Add(coupon);
                    count++;
                }
            } while (count <= 10);//the loops goes until we get 10 different no
            Console.WriteLine("The Distinct Coupons are");
            Console.WriteLine("[");
            foreach (int i in distinct_coupon)//used to pick up one value and iterate till end of the list
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("]");

        }
    }
}
