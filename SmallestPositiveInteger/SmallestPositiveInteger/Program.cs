using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallestPositiveInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] arrayOfNumbers = new int[] { -1, -3 };
            //int[] arrayOfNumbers = new int[] { 1, 2, 3 };

            int[] arrayOfNumbers = new int[] { 1, 3, 6, 4, 1, 2 };

            int number = Solution(arrayOfNumbers);
            Console.WriteLine("Minimum positive integer is {0}", number);
            Console.ReadLine();

        }

        private static int Solution(int[] A)
        {
            int maxNumber = A.Max();

            if (maxNumber < 0)
                return 1;
            else
            {
                int minNumber = A.Min();
                while (A.Contains(minNumber))
                {
                    minNumber++;
                }

                return minNumber;
            }




        }

    }
}
