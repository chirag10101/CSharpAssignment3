using System;
using System.Collections.Generic;

namespace Assignment3
{
    class Program
    {
        static void Main()
        {
            int[] arr = [1, 2, 2, 3, 3, 4, 4, 4, 5];
            Dictionary<int, int> elementCounts = [];
            int duplicateCount = 0;

            foreach (int num in arr)
            {
                if (elementCounts.ContainsKey(num))
                {
                    if (elementCounts[num] == 1) 
                    {
                        duplicateCount++;
                    }
                    elementCounts[num]++;
                }
                else
                {
                    elementCounts[num] = 1;
                }
            }

            Console.WriteLine("Total number of duplicate elements: " + duplicateCount);

            //Program2.IsEligible();
            Program3.ElectricityBill();
        }
    }

}
