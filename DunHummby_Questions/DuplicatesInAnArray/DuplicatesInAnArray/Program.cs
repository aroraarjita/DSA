using System;
using System.Collections.Generic;
using System.Linq;

namespace DuplicatesInAnArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4, 2, 5, 1 };
            List<int> duplicates = FindDuplicates(nums);
            Console.WriteLine(string.Join("," , duplicates));

            Console.ReadLine();
        }

        static List<int> FindDuplicates(int[] nums)
        {

            return nums.GroupBy(x => x)
                       .Where(g => g.Count() > 1)
                        .Select(g => g.Key)
                        .ToList();
        }
    }
}
