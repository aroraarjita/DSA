using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountStrinInterview
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputValue = "test";
            Dictionary<char, int> countOfChars = new Dictionary<char, int>();

            //foreach(char keyword in inputValue)
            //{
            //    int count = 1;
            //    if (countOfChars.ContainsKey(keyword))
            //    {
            //        count = countOfChars.FirstOrDefault(x => x.Key == keyword).Value;
            //        count++;
            //        countOfChars.Remove(keyword);
            //    }

            //    countOfChars.Add(keyword, count);

            //}

            //foreach(KeyValuePair<char,int> keyValuePair in countOfChars)
            //{
            //    Console.WriteLine("Count of character {0} is {1}", keyValuePair.Key, keyValuePair.Value);
            //}

            while(inputValue.Length > 0)
            {
                int count = 0;

                for(int i=0; i<inputValue.Length; i++)
                {
                    if (inputValue[0] == inputValue[i])
                        count++;
                }

                if (!countOfChars.ContainsKey(inputValue[0]))
                    countOfChars.Add(inputValue[0], count);

                inputValue = inputValue.Replace(inputValue[0].ToString(), String.Empty);
            }


            foreach(var keyValuePair in countOfChars)
            {

                Console.WriteLine("Key: " + keyValuePair.Key + " Value: "+ keyValuePair.Value);

            }
           
            Console.ReadLine();

        }
    }
}
