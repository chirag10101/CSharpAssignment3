using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    public static class Program2
    {
        public static void IsEligible()
        {
            Console.WriteLine("Input the marks obtained in Physics");
            int p = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the marks obtained in chemistry");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the marks obtained in maths");
            int m = Convert.ToInt32(Console.ReadLine());
            if ((p >= 55 && m >= 65 && c >= 50) || ((p + m + c) >= 180) || ((p+m)>=140))
            {
                Console.WriteLine("The candidate is eligible for admission.");
            }
            else
            {
                Console.WriteLine("The candidate is not eligible for admission.");
            }
        }
    }
}
