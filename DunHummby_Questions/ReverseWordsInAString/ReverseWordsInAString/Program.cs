using System;
using System.Linq;

namespace ReverseWordsInAString
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "Lead Software Developer";
            string output = ReverseWords(input);
            Console.WriteLine(output);
            Console.ReadLine();
        }

        static string ReverseWords(string str)
        {
            System.Collections.Generic.IEnumerable<string> arrayOfWords = str.Split(' ').Reverse();
            return string.Join(" ", arrayOfWords);

        }
    }
}
