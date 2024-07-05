using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            //int longestLength = LongestLengthOfStick(10, 21);
            int longestLength = LongestLengthOfStick(13, 11);
            Console.WriteLine(longestLength);
            Console.ReadLine();

        }

        public static int LongestLengthOfStick(int A, int B)
        {
            if(A  ==  1 && B <= 2)
            {
                return 0;
            }
            else if( B == 1 && A <= 2)
            {
                return 0;
            }

            int highestNumber = A > B ? A : B;
            int secondNumber;
            if(highestNumber == A)
            {
                secondNumber = B;
            }
            else
            {
                secondNumber = A;
            }


                if((highestNumber / 4) > B)
                {
                    return (highestNumber / 4);
                }
                else if((highestNumber / 3) > (secondNumber / 2))
                {
                    return (highestNumber / 3);
                 }
              else
              {
                return (secondNumber / 2);
              }
        
        }
    }
}
