using System;
using System.Collections.Generic;
using System.Text;

namespace Day9_Assignments
{
    class FutureValue
    {
        public static void Value()
        {
            Console.WriteLine("Enter the amount of money in Dollars you will invest");
            double c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the time in years you will invest money");
            double t = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the rate at which you will invest money");
            double r = Convert.ToDouble(Console.ReadLine());
            double futureValue = c * Math.Pow((1 + r) , t );
            Console.WriteLine("Your Future Value will be :"+futureValue);

        }
    }
}
