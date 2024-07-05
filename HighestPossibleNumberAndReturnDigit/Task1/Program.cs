using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static int K;
        static void Main(string[] args)
        {
            K = 1;
            //int highestPossibleNumber = HighestPossibleNumber(285, K);
            //int highestPossibleNumber = HighestPossibleNumber(512, K);
            int highestPossibleNumber = HighestPossibleNumber(191, K);

            Console.WriteLine(highestPossibleNumber);
            Console.ReadLine();

            //OnesDigitNumber();
        }

        public static int HighestPossibleNumber(int N, int K)
        {

            int hundredsDigitNumber = N / 100;
            int tensDigitNumber = ((N / 10) % 10);
            int onesDigitNumber = (N % 10);



            if (hundredsDigitNumber < 9)
            {
                int numberToBeAdded;
                if ((hundredsDigitNumber + K) > 9)
                {
                    numberToBeAdded = (9 - hundredsDigitNumber);
                }
                else
                {
                    numberToBeAdded = K;
                }




                K = K - numberToBeAdded;
                hundredsDigitNumber = hundredsDigitNumber + numberToBeAdded;

                //hundredsDigitNumber = ReturnDigit(hundredsDigitNumber);

            }
            if(tensDigitNumber < 9 && K > 0)
            {
                int numberToBeAdded;
                if ((tensDigitNumber + K) > 9)
                {
                    numberToBeAdded = (9 - tensDigitNumber);
                }
                else
                {
                    numberToBeAdded = K;
                }
                K = K - numberToBeAdded;
                tensDigitNumber = tensDigitNumber + numberToBeAdded;


                //tensDigitNumber = ReturnDigit(tensDigitNumber);

            }
            if (onesDigitNumber < 9 && K > 0)
            {
                int numberToBeAdded;
                if ((onesDigitNumber + K) > 9)
                {
                    numberToBeAdded = (9 - onesDigitNumber);
                }
                else
                {
                    numberToBeAdded = K;
                }
                K = K - numberToBeAdded;
                onesDigitNumber = onesDigitNumber + numberToBeAdded;


                //onesDigitNumber = ReturnDigit(onesDigitNumber);
            }

            int newNumber = hundredsDigitNumber * 100 + tensDigitNumber * 10 + onesDigitNumber;
            return newNumber;


        }


        public static int ReturnDigit(int digitNumber)
        {
            if (digitNumber < 9 && K > 0)
            {
                int numberToBeAdded;
                if ((digitNumber + K) > 9)
                {
                    numberToBeAdded = (9 - digitNumber);
                }
                else
                {
                    numberToBeAdded = K;
                }
                K = K - numberToBeAdded;
                digitNumber = digitNumber + numberToBeAdded;

            }
            return digitNumber;
        }
           
    }
}
