using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeeksForGeeksProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            ReverseWordsInAString reverseWordsInAString = new ReverseWordsInAString();
            string reversedString = reverseWordsInAString.reverseWords("i.like.this.program.very.much");


            //Anagram anagram = new Anagram();
            //bool result = anagram.isAnagram("geeksforgeeks", "forgeeksgeeks");
            //bool outputValue = anagram.isAnagram("allergy", "allergic");


            //RotateAString rotateAString = new RotateAString();
            //bool resultRotated = rotateAString.isRotated("amazon", "azonam");

            //bool outputRotatedString = rotateAString.isRotated("fsbcnuvqhffbsaqxwp", "wpfsbcnuvqhffbsaqx");




        }
    }

    //Parenthesis Checker

    class Solution
    {

        //Complete this function
        public bool ispar(string s)
        {
            //Your code here
            Stack<char> stringStack = new Stack<char>();

            foreach (char c in s)
            {

                if (c == '[' || c == '{' || c == '(' || stringStack.Count == 0)
                {

                    stringStack.Push(c);
                }
                else if (stringStack.Count > 0)
                {

                    if (stringStack.Peek() == '(' && c == ')')
                    {

                        stringStack.Pop();
                    }

                    else if (stringStack.Peek() == '{' && c == '}')
                    {
                        stringStack.Pop();

                    }

                    else if (stringStack.Peek() == '[' && c == ']')
                    {
                        stringStack.Pop();

                    }

                    else
                        stringStack.Push(c);

                }
            }

            if (stringStack.Count > 0)
                return false;

            return true;

        }

    }

    //Reverse words in a given string
    class ReverseWordsInAString
    {
        //Complete this function
        public string reverseWords(string s)
        {
            //Your code here

            
            int startingPoint = s.Length-1;

            //if (s.Contains('.'))
            //{
            //    for (int i = startingPoint; i >= 0; i--)
            //    {
            //        if (s[i] == '.')
            //        {
            //            if (startingPoint == s.Length - 1)
            //                stringBuilder.Append(s.Substring(i + 1, (startingPoint - i)));
            //            else
            //            {
            //                stringBuilder.Append(s.Substring(i, (startingPoint - i)));
            //            }

            //            startingPoint = i;
            //        }

            //        if (i == 0)
            //        {
            //            stringBuilder.Append('.');
            //            stringBuilder.Append(s.Substring(i, startingPoint)); ;
            //        }
            //    }
            //}
            //else
            //    return s;

            int stringLength = s.Length - 1;
            string[] arrayOfString = new string[stringLength];
            StringBuilder stringBuilder = new StringBuilder();

            arrayOfString = s.Split('.');

            for(int i = arrayOfString.Length-1; i > 0; i--)
            {
                stringBuilder.Append(arrayOfString[i] + '.');
            }

            stringBuilder.Append(arrayOfString[0]);

            return stringBuilder.ToString();

        }

    }

    class Anagram
    {
        //Complete this function
        public bool isAnagram(string a, string b)
        {
            //Your code here
            if (a.Length != b.Length)
                return false;

            char[] charArrayA = new char[a.Length];
            char[] charArrayB = new char[b.Length];

            charArrayA = a.ToCharArray();
            charArrayB = b.ToCharArray();

            Array.Sort(charArrayA);
            Array.Sort(charArrayB);

           
            string modifiedStringA = new string(charArrayA);
            string modifiedStringB = new string(charArrayB);

            bool result = modifiedStringA == modifiedStringB ? true : false;

            return result;

        }

    }

    class RotateAString
    {

        public bool isRotated(string str1, string str2)
        {
            //Your code here
            if (str1.Length != str2.Length)
                return false;

            else if (str1.Length == 2)
                return true;
            else if (str1.Length == str2.Length
                && str1.Length == 1
                && str1 != str2)
                return false;

            else if (rotateAntiClockWise(str1, str2))
                return true;
            else if (rotateClockWise(str1, str2))
                return true;
            else
                return false;       
        }


        public bool rotateAntiClockWise(string str1, string str2)
        {


                string rotatedString = str1.Substring(2) + str1[0].ToString() + str1[1].ToString();
                if (str2 == rotatedString)
                    return true;
                else
                    return false;                  

        }

        public bool rotateClockWise(string str1, string str2)
        {
            int length = str1.Length;

                string rotatedString = str1[length - 2].ToString() + str1[length - 1].ToString() + str1.Substring(0, length - 2);

                if (str2 == rotatedString)
                    return true;
                else
                    return false;
          
        }

    }


}
