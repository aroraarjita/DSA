using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
        }


        public int solution(int[] A, int[] B, int N)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)


            // group by value and count frequency
            var query = from i in A.ToList()
                        group i by i into g
                        select new { g.Key, Count = g.Count() };

            // compute the maximum frequency
            int whatsTheFrequencyKenneth = query.Max(g => g.Count);



        }
    }
}
