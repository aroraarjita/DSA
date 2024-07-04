using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToptalQuestions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Greedy Algorithms Start
            //MaxNonoverlappingSegments

            //int[] A = new int[] { 1, 3, 7, 9, 9 };
            //int[] B = new int[] { 5, 6, 8, 9, 10 };


            //int maxNonOverlappingSegments = FindMaxNonoverlappingSegments(A, B);
            //Console.WriteLine("Maximum non overlapping segments are {0}", maxNonOverlappingSegments);

            //TieRopes

            //int[] A = new int[] { 1, 2, 3, 4, 1, 1, 3 };
            //int K = 4;
            //Console.WriteLine("Maximun number of ropes which can be tied are {0}", FindMaxNumberOfTiedRopes(K, A));

            //Greedy Algorithms End



            //Caterpillar Start

            //AbsDistinct
            //int[] A = new int[] { -5, -3, -1, 0, 3, 6 };
            //Console.WriteLine("Number of distinct values are {0}", FindAbsDistinctCount(A));

            //CountDistinctSlices
            //int[] A = new int[] { 3, 4, 5, 5, 2 };
            //Console.WriteLine("Number of slices are {0}", CountDistinctSlices(6, A));

            //CountTriangles
            //int[] A = new int[] { 10, 2, 5, 1, 8, 12 };
            //Console.WriteLine("Number of traingles that can be formed {0}", CountTriangles(A));

            //MinAbsSumOfTwo

            //int[] A = new int[] { 1, 4, -3 };
            //Console.WriteLine("Minimum absolute sum is {0}", MinAbsSumOfTwo(A));

            //Caterpillar End


            //Binary Search Algorithm Start
            int[] A = new int[] { 2, 1, 5, 1, 2, 2, 2 };
            int minOfMaxSum = FindMinMaxDivision(3, 5, A);
            Console.WriteLine("Minimum of max division is {0}", minOfMaxSum);




            //Binary Search Algorithm End




            Console.ReadLine();
        }

        //Greedy Algorithms Start
        //MaxNonoverlappingSegments
        public static int FindMaxNonoverlappingSegments(int[] A, int[] B)
        {
            if(A.Length == 0 || B.Length == 0)
            {
                return 0;
            }

            int count = 1;
            int i = 0;

            for(int j=1; j<A.Length; j++)
            {
                if(A[j] > B[i])
                {
                    count++;
                    i = j;
                }

            }

            return count;
        }

        //TieRopes
        public static int FindMaxNumberOfTiedRopes(int K, int[] A)
        {
            int previous = 0;
            int numberOfRopes = 0;

            for(int i = 0; i<A.Length; i++)
            {
                if(A[i] >= K || (previous+A[i]) >= K)
                {
                    numberOfRopes++;
                    previous = 0;
                }
                else
                {
                    previous += A[i];
                }

            }
            return numberOfRopes;

        }

        //Greedy Algorithms End


        //Caterpillar method start

        //AbsDistinct
        public static int FindAbsDistinctCount(int[] A)
        {
            if(A.Length == 0)
            {
                return 0;
            }

            HashSet<int> distinctNumbers = new HashSet<int>();

            for(int i=0; i<A.Length; i++)
            {
                distinctNumbers.Add(Math.Abs(A[i]));
            }

            return distinctNumbers.Count;
        }

        //CountDistinctSlices
        public static int CountDistinctSlices(int M, int[] A)
        {
            bool[] seen = new bool[M + 1];
            int numOfSlices = 0;
            int leftEnd = 0;
            int rightEnd = 0;


            while(leftEnd <A.Length && rightEnd < A.Length)
            {
                if(seen[A[rightEnd]] == false)
                {
                    seen[A[rightEnd]] = true;

                    //Count the number of slices
                    numOfSlices += (rightEnd - leftEnd + 1);
                    rightEnd++;
                }
                else
                {
                    seen[A[leftEnd]] = false;
                    leftEnd++;
                }


            }

            return numOfSlices;




        }

        //CountTriangles
        public static int CountTriangles(int[] A)
        {
            int count = 0;
            Array.Sort(A);

            for(int i=0; i<A.Length-2; i++)
            {
                int k = i + 2;

                for(int j=i+1; j<A.Length-1; j++)
                {
                    while(k<A.Length && A[i]+A[j] > A[k])
                    {
                        k++;
                        count += (k - j - 1);
                    }

                }               
            }
            return count;
        }

        //MinAbsSumOfTwo
        public static int MinAbsSumOfTwo(int[] A)
        {
            int minSum = Int32.MaxValue;
            int frontEnd = 0;
            int backEnd = A.Length - 1;

            while(frontEnd <= backEnd)
            {
                int currentSum = Math.Abs(A[frontEnd] + A[backEnd]);
                minSum = Math.Min(minSum, currentSum);

                if (frontEnd + 1 < A.Length && Math.Abs(A[frontEnd + 1] + A[backEnd]) <= minSum)
                {
                    frontEnd++;
                }
                else if (backEnd - 1 > 0 && Math.Abs(A[backEnd - 1] + A[frontEnd]) <= minSum)
                {
                    backEnd--;

                }
                else
                {
                    frontEnd++;
                    backEnd--;
                }


            }

            return minSum;


        }
        //Caterpillar Method End


        //Binary Search Algorithm Start

        //MinMaxDivision
        public static int FindMinMaxDivision(int k, int M, int[] A)
        {
            int minSum = Int32.MinValue;
            int maxSum = 0;

            

            for(int i =0; i < A.Length; i++)
            {
                maxSum += A[i];
                minSum = Math.Max(minSum, A[i]);

            }

            int possibleResult = maxSum;

            while (minSum <= maxSum)
            {
                int midSum = (minSum + maxSum) / 2;

                bool ok = checkIfCanBeDivided(midSum, k, A);

                if(ok == true)
                {
                    possibleResult = midSum;
                    maxSum = midSum - 1;
                }
                else
                {
                    minSum = minSum + 1;
                }


            }

            return possibleResult;

        }

        public static bool checkIfCanBeDivided(int mid, int k, int[] A)
        {
            int numOfBlocksAllowed = k;
            int currentBlockSum = 0;

            for(int i =0; i<A.Length; i++)
            {
                currentBlockSum = currentBlockSum + A[i];

                if(currentBlockSum > mid)
                {
                    numOfBlocksAllowed--;
                    currentBlockSum = A[i];

                }

                if(numOfBlocksAllowed == 0)
                {
                    return false;
                }

            }

            return true;


        }

        //Nailing Planks

      

   







    }
}
