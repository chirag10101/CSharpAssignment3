using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    public static class Program3
    {
        public static void ElectricityBill()
        {
            Console.WriteLine("Enter customer Id :");
            int custId = Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("Enter name :");
            string name = Console.ReadLine();
            Console.WriteLine("Enter unit consumed :");
            int unit = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Customer ID : {custId}");
            Console.WriteLine($"Customer Name : {name}");
            Console.WriteLine($"Unit Consumed : {unit}");
            float price;
            double netPrice;
            if (unit <= 199)
            {
                price = (float)(unit * 1.20);
                Console.WriteLine($"Amount charges @Rs 1.20 per unit : {Math.Round(price, 2)}");
                Console.WriteLine($"Surcharge Amount : 0");
                Console.WriteLine($"Net Amount paid by customer : {Math.Round(price, 2)}");
                return;
            }else if(unit <= 400)
            {
                price = (float)(unit * 1.50);
                Console.WriteLine($"Amount charges @Rs 1.50 per unit : {Math.Round(price, 2)}");
                if (price > 400)
                {
                    netPrice = price + (price * (0.15));
                    Console.WriteLine($"Surcharge Amount : {Math.Round((price * (0.15)), 2)}");
                    Console.WriteLine($"Net Amount paid by customer : {Math.Round(netPrice, 2)}");
                }
                else
                {
                    Console.WriteLine($"Surcharge Amount : 0");
                    Console.WriteLine($"Net Amount paid by customer : {Math.Round(price, 2)}");
                }
            } else if (unit <= 600) 
            {
                price = (float)(unit * 1.80);
                Console.WriteLine($"Amount charges @Rs 1.80 per unit : {Math.Round(price, 2)}");
                netPrice = price + (price * (0.15));
                Console.WriteLine($"Surcharge Amount : {Math.Round((price * (0.15)), 2)}");
                Console.WriteLine($"Net Amount paid by customer : {Math.Round(netPrice, 2)}");
            }
            else
            {
                price = (float)(unit * 2.00);
                Console.WriteLine($"Amount charges @Rs 2.00 per unit : {Math.Round(price, 2)}");
                netPrice = price + (price * (0.15));
                Console.WriteLine($"Surcharge Amount : {Math.Round((price * (0.15)), 2)}");
                Console.WriteLine($"Net Amount paid by customer : {Math.Round(netPrice, 2)}");
            }
        }
    }
}
