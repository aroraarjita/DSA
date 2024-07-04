using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace LeetCodePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //string word1 = "abc", word2 = "pqr";

            //string word1 = "ab", word2 = "pqrs";

            //string outputString = MergeAlternately(word1, word2);

            //int gcdnumber = gcd(12, 6);

            //string s = "aA";
            //string reversedString = ReverseVowels(s);

            //string s = "a good   example";
            //string result = ReverseWords(s);

            //int[] nums = new int[] { 5, 4, 3, 2, 1 };
            //bool result = IncreasingTriplet(nums);

            //char[] chars =  new char[] { 'a', 'a', 'b', 'b', 'c', 'c', 'c' };

            //string[] chars = new string[] { "a", "a", "b", "b", "c", "c", "c" };
            //int countOfChars = Compress(chars);

            Program obj = new Program();
            //string s = "abc";
            //string t = "ahbgdc";

            //bool result = obj.IsSubsequence(s, t);

            //int[] height = { 1, 8, 6, 2, 5, 4, 8, 3, 7 };

            //int maxArea = obj.MaxArea(height);

            //int[] arrayOfInt = new int[] { 1, 2, 3, 4 };
            //int numOfOperations = obj.MaxOperations(arrayOfInt, 5);

            //int[] avg = new int[] { 1, 12, -5, -6, 50, 3 };
            //double maxAvg = obj.FindMaxAverage(avg, 4);

            //string s = "leetcode";
            //int k = 3;

            //int maxVowels = obj.MaxVowels(s, k);

            //int[] nums = new int[] { 1, 1, 1, 0, 0, 0, 1, 1, 1, 1, 0 };
            //int k = 2;

            //int longestOnes = obj.LongestOnes(nums, 2);

            //int[] nums = { 1, 1, 1 };
            //int maxValue = obj.longestSubarrayOptimized(nums);

            //int[] gain = new int[] { -4, -3, -2, -1, 4, 3, 2 };
            //int maxAltitude = obj.LargestAltitude(gain);

            //int[] nums1 = new int[] { 1, 2, 3, 3 };
            //int[] nums2 = new int[] { 1, 1, 2, 2 };

            //IList<IList<int>> result = new List<IList<int>>();
            //result = obj.FindDifference(nums1, nums2);

            //int[] arrayInt = new int[] { 1, 2 };
            //bool result = obj.UniqueOccurrences(arrayInt);

            //bool result = obj.CloseStrings("cabbba", "abbccc");

            //string s = "erase*****";
            //string output = obj.RemoveStars(s);

            //int[] asteroids = new int[] { -2, -2, 1, -2 };
            //int[] result = obj.AsteroidCollision(asteroids);

            //string s = "3[a]2[bc]";
            //string result = obj.DecodeStringV2(s);
            obj.RecentCounter();

            //int count = obj.Ping(1);
            //count = obj.Ping(100);
            //count = obj.Ping(3001);
            //count = obj.Ping(3002);


            string senate = "RDD";
            string result = obj.PredictPartyVictory(senate);



        }
        public static string MergeAlternately(string word1, string word2)
        {

            int i = 0;
            StringBuilder resultString = new StringBuilder();

            while (i <= word1.Length - 1 && i <= word2.Length - 1)
            {
                resultString.Append(word1[i]);
                resultString.Append(word2[i]);

                i++;
            }


          
            if (word1.Length < word2.Length)
            {
                resultString.Append(word2.Substring(i,word2.Length-i));


            }
            else if (word2.Length < word1.Length)
            {
                resultString.Append(word1.Substring(i, word1.Length - i));
            }

            return resultString.ToString();
    }
        public string GcdOfStrings(string str1, string str2)
        {

            if (!((str1 + str2).Equals(str2 + str1)))
                return "";

            int gcdLength = gcd(str1.Length, str2.Length);
            String gcdResult = str1.Substring(0, gcdLength);

            return gcdResult;
         }
        public static int gcd(int x, int y)
        {
            if (y == 0)
            {
                return x;
            }
            else
            {
                return gcd(y, x % y);
            }
        }
        public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
        {
            int maxCandy = candies.Max();
            IList<bool> resultList = new List<bool>();


            foreach (int numOfCandies in candies)
            {
                int sum = numOfCandies + extraCandies;

                if (sum >= maxCandy)
                    resultList.Add(true);
                else
                    resultList.Add(false);
            }

            return resultList;
        }
        public static string ReverseVowels(string s)
        {
            int startIndex = 0;
            int lastIndex = s.Length - 1;
            char[] originalString = s.ToCharArray();

            while(startIndex != lastIndex &&
                startIndex <= lastIndex)
            {
                if (isVowel(s[startIndex]))
                {
                    while (!isVowel(s[lastIndex]) && lastIndex >= 0)
                    {
                        lastIndex--;
                    }

                    char temp = originalString[startIndex];
                    originalString[startIndex] = originalString[lastIndex];
                    originalString[lastIndex] = temp;
                    lastIndex--;
                }                
                startIndex++;
            }

            String reversedString = new String(originalString);
            return reversedString;            
        }
        static bool isVowel(char c)
        {
            return (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u' ||
                c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U');
        }
        public static string ReverseWords(string s)
        {
            string trailedString = s.Trim();
            string[] stringArray = trailedString.Split(' ');
            int j = stringArray.Length - 1;
            
            StringBuilder resultString = new StringBuilder();
            while (j >= 0)
            {
                if(stringArray[j] != "")
                {
                    resultString.Append(stringArray[j]);
                    resultString.Append(" ");
                }             
                j--;
            }
          
            return resultString.ToString().Trim();
        }
        public int[] ProductExceptSelf(int[] nums)
        {
            int length = nums.Length;
            int[] L = new int[length];
            int[] R = new int[length];
            int[] answer = new int[length];

            L[0] = 1;

            for(int i=1; i< length; i++)
            {
                L[i] = nums[i - 1] * nums[i - 1];
                
            }

            R[length - 1] = 1;

            for(int i= length - 2; i >= 0; i--)
            {
                R[i] = R[i + 1] * nums[i + 1];
            }



            for(int i=0; i< length; i++)
            {
                answer[i] = L[i] * R[i];
            }

            return answer;
        }
        public int[] productExceptSelf(int[] nums)
            {

                // The length of the input array
                int length = nums.Length;

                // The left and right arrays as described in the algorithm
                int[] L = new int[length];
                int[] R = new int[length];

                // Final answer array to be returned
                int[] answer = new int[length];

                // L[i] contains the product of all the elements to the left
                // Note: for the element at index '0', there are no elements to the left,
                // so L[0] would be 1
                L[0] = 1;
                for (int i = 1; i < length; i++)
                {

                    // L[i - 1] already contains the product of elements to the left of 'i - 1'
                    // Simply multiplying it with nums[i - 1] would give the product of all
                    // elements to the left of index 'i'
                    L[i] = nums[i - 1] * L[i - 1];
                }

                // R[i] contains the product of all the elements to the right
                // Note: for the element at index 'length - 1', there are no elements to the right,
                // so the R[length - 1] would be 1
                R[length - 1] = 1;
                for (int i = length - 2; i >= 0; i--)
                {

                    // R[i + 1] already contains the product of elements to the right of 'i + 1'
                    // Simply multiplying it with nums[i + 1] would give the product of all
                    // elements to the right of index 'i'
                    R[i] = nums[i + 1] * R[i + 1];
                }

                // Constructing the answer array
                for (int i = 0; i < length; i++)
                {
                    // For the first element, R[i] would be product except self
                    // For the last element of the array, product except self would be L[i]
                    // Else, multiple product of all elements to the left and to the right
                    answer[i] = L[i] * R[i];
                }

                return answer;
            }
        public static bool IncreasingTriplet(int[] nums)
        {
            int i = 0;
            int first_num = Int32.MaxValue;
            int second_num = Int32.MaxValue;

            while (i < nums.Length)
            {

                if (nums[i] <= first_num)
                    first_num = nums[i];

                else if (nums[i] <= second_num)
                    second_num = nums[i];
                
                else
                    return true;

                i++;
            }

            return false;


        }
        public static int Compress(char[] chars)
        {
            int i = 0;
            int count = 0;
            List<char> compressedString = new List<char>();

            if (chars.Length == 1)
                return 1;

            while( i < chars.Length)
            {
                if (i > 0 && chars[i] != chars[i - 1])
                {                    
                   compressedString.Add(chars[i - 1]);                   
                    if (count > 1)
                        compressedString = UpdateCompressedString(count, compressedString);
                 
                    count = 0;
                }
                count++;
                i++;
            }

            compressedString.Add(chars[i-1]);
            if (count > 1)
                compressedString = UpdateCompressedString(count, compressedString);

              
            return compressedString.Count;
        }
        public static List<char> UpdateCompressedString(int count, List<char> compressedString)
        {
            if (count > 1)
            {
                foreach (char c in count.ToString().ToCharArray())
                {
                    compressedString.Add(c);
                }
            }

            return compressedString;
        }
        public static int Compress(string[] chars)
        {
            int i = 0;
            int count = 0;
            List<string> compressedString = new List<string>();

            if (chars.Length == 1)
                return 1;

            while (i < chars.Length)
            {
                if (i > 0 && chars[i] != chars[i - 1])
                {
                    compressedString.Add(chars[i - 1]);
                    if (count > 1)
                        compressedString = UpdateCompressedString(count, compressedString);

                    count = 0;
                }
                count++;
                i++;
            }

            compressedString.Add(chars[i - 1]);
            if (count > 1)
                compressedString = UpdateCompressedString(count, compressedString);


            return compressedString.Count;
        }
        public static List<string> UpdateCompressedString(int count, List<string> compressedString)
        {
            if (count > 1)
            {
                foreach (char c in count.ToString().ToCharArray())
                {
                    compressedString.Add(c.ToString());
                }
            }

            return compressedString;
        }

        string s, t;
        int sourceStringLength, targetStringLength;
        public bool IsSubsequence(string s, string t)
        {
            this.s = s;
            this.t = t;

            sourceStringLength = s.Length;
            targetStringLength = t.Length;

            return rec_isSubSequence(0, 0);

        }
        private bool rec_isSubSequence(int leftIndex, int rightIndex)
        {
            if (leftIndex == sourceStringLength)
                return true;

            if (rightIndex == targetStringLength)
                return false;

            if(s[leftIndex] == t[rightIndex])
                ++leftIndex;

                ++rightIndex;
       

            return rec_isSubSequence(leftIndex, rightIndex);
        }
        public void MoveZeroes(int[] nums)
        {
            int  writePointer = 0;

           for(int reader = 0; reader<nums.Length; reader++)
           {
                if (nums[reader] != 0)
                {
                    nums[writePointer] = nums[reader];
                    writePointer++;
                }
                   
           }
            
           while(writePointer < nums.Length)
            {
                nums[writePointer] = 0;
                writePointer++;
            }
        }
        public int MaxArea(int[] height)
        {
            int leftPointer = 0;
            int rightPointer = height.Length - 1;
            int maxArea = height[leftPointer] < height[rightPointer] ? height[leftPointer] * (rightPointer - leftPointer) : height[rightPointer] * (rightPointer - leftPointer);


            while (leftPointer < rightPointer)
            {
                int length = rightPointer - leftPointer;
                int area = 0;


                if (height[leftPointer] < height[rightPointer] ||
                    height[leftPointer] == height[rightPointer])
                {
                    area = height[leftPointer] * length;
                    leftPointer++;
                }
                    
                else if (height[leftPointer] > height[rightPointer])
                {
                    area = height[rightPointer] * length;
                    rightPointer--;
                }


                if (area > maxArea)
                    maxArea = area;


                
            }
            return maxArea;
        }
        public int MaxOperations(int[] nums, int k)
        {
            Array.Sort(nums);

            int startPointer = 0;
            int endPointer = nums.Length - 1;
            int count = 0;

            while(startPointer < endPointer)
            {
                if (nums[startPointer] + nums[endPointer] < k)
                {
                    startPointer++;
                }
                else if (nums[startPointer] + nums[endPointer] > k)
                {
                    endPointer--;
                }
                else
                {
                    startPointer++;
                    endPointer--;
                    count++;
                }
            }

            return count;
        }
        public double FindMaxAverage(int[] nums, int k)
        {
            double sum = 0;
            
            for(int i=0; i<k; i++)
            {
                sum += nums[i];

            }

            double res = sum;
            for(int i = k; i<nums.Length; i++) {
                sum += nums[i] - nums[i - k];

                res = Math.Max(res, sum);
            }

            return res / k;
        }
        public int MaxVowels(string s, int k)
        {

            int voWelCount = 0;
            int maxVowelCount;

            for(int i =0; i<k; i++)
            {
                if (isVowel(s[i]))
                    voWelCount++;
            }

            maxVowelCount = voWelCount;
            for(int i=k; i<s.Length; i++)
            {
                if (isVowel(s[i - k]))
                    voWelCount--;

                if (isVowel(s[i]))
                    voWelCount++;

                maxVowelCount = Math.Max(voWelCount, maxVowelCount);

            }


            return maxVowelCount;
        }
        private bool isVowelChar(char c)
        {
            bool result = false;
            if (c == 'a' || c == 'e' ||
              c == 'i' || c == 'o' || c == 'u'
               || c == 'A' || c == 'E' || c == 'I' ||
              c == 'O' || c == 'U')
            {
                result = true;
                return result;
            }
            return false;
        }
        public int LongestOnes(int[] nums, int k)
        {
            int OneCount = 0;
            int maxOneCount = Int32.MinValue;
            int flippedZeroes = k;
            int endPointer = 0;
            int startPointer = 0;

            while (endPointer<nums.Length)
            {

                if (nums[endPointer] == 0 || nums[endPointer] == 1 && flippedZeroes > 0)
                {
                    endPointer++;

                    if (nums[endPointer] == 0)
                        flippedZeroes--;
                }
                  

                if(flippedZeroes == 0)
                {
                    maxOneCount = Math.Max(maxOneCount, endPointer - startPointer);

                    while(flippedZeroes == 0)
                    {
                        if (nums[startPointer++] == 0)
                            flippedZeroes++;
                    }
                                                                                
                }

            }

            maxOneCount = Math.Max(maxOneCount, endPointer - startPointer);
            return maxOneCount;
        }
        public int longestSubarray(int[] nums)
        {
            int endPointer = 0;
            int startingPointer = 0;
            int maxLength = Int32.MinValue;
            int numberOfZeroesCanBeDeleted = 1;

            while(endPointer < nums.Length)
            {
                if (nums[endPointer++] == 0)
                    numberOfZeroesCanBeDeleted--;
                  

                if(numberOfZeroesCanBeDeleted >= 0)
                    maxLength = Math.Max(maxLength, endPointer - startingPointer-1);


                if (numberOfZeroesCanBeDeleted < 0)
                {

                    if (nums[startingPointer] == 0)
                        startingPointer++;

                    else if(nums[startingPointer] == 1)
                    {
                        while (nums[startingPointer++] == 1) ;
                    }

                    numberOfZeroesCanBeDeleted++;
                    maxLength = Math.Max(maxLength, endPointer - startingPointer - 1);

                }

            }

            return maxLength;
        }
        public int longestSubarrayOptimized(int[] nums)
        {
            int zeroCount = 0;
            int startingPoint = 0;
            int maxLength = Int32.MinValue;

            for(int i = 0; i< nums.Length; i++)
            {
                zeroCount += (nums[i] == 0 ? 1 : 0);
                while(zeroCount > 1)
                {
                    zeroCount = zeroCount - (nums[startingPoint] == 0 ? 1 : 0);
                    startingPoint++;
                }
                maxLength = Math.Max(maxLength, i - startingPoint);
            }
            return maxLength;
        }
        public int LargestAltitude(int[] gain)
        {
            int[] altitudeArray = new int[gain.Length + 1];

            altitudeArray[0] = 0;

            for(int i = 0; i<gain.Length; i++)
            {
                altitudeArray[i + 1] = altitudeArray[i] + gain[i];
            }

            int maxAltitude = altitudeArray.Max();

            return maxAltitude;
        }
        public int PivotIndex(int[] nums)
        {
            int sum = 0, leftSum = 0;

            foreach (int i in nums)
                sum += i;

            for(int i=0; i<nums.Length; i++)
            {
                if (leftSum == sum - leftSum - nums[i])
                    return i;

                leftSum = leftSum + nums[i];
            }

            return -1;
        }
        List<int> getElementsOnlyInFirstList(int[] nums1, int[] nums2)
        {
            HashSet<int> onlyInNums1 = new HashSet<int>();
            HashSet<int> existsInNums2 = new HashSet<int>();

            foreach(int i in nums2)
            {
                existsInNums2.Add(i);
            }

            foreach(int num in nums1)
            {
                if (!existsInNums2.Contains(num))
                    onlyInNums1.Add(num);

            }

            return onlyInNums1.ToList();

        }
        public IList<IList<int>> FindDifference(int[] nums1, int[] nums2)
        {
            IList<IList<int>> listObj = new List<IList<int>>();
            listObj.Add(getElementsOnlyInFirstList(nums1, nums2));
            listObj.Add(getElementsOnlyInFirstList(nums2, nums1));

            return listObj;
           
        }
        public bool UniqueOccurrences(int[] arr)
        {
            Dictionary<int, int> numberOfOccurences = new Dictionary<int, int>();
          
            foreach(int num in arr)
            {
                if (!numberOfOccurences.ContainsKey(num))
                    numberOfOccurences.Add(num, 1);
                else
                {
                    int count = numberOfOccurences[num];
                    numberOfOccurences[num] = count + 1;
                }
            }

            HashSet<int> freqSet = new HashSet<int>(numberOfOccurences.Values);

            return (numberOfOccurences.Count == freqSet.Count);
               
        }
        public bool CloseStrings(string word1, string word2)
        {
            Dictionary<char, int> keyValuePairsWord1 = new Dictionary<char, int>();
            Dictionary<char, int> keyValuePairsWord2 = new Dictionary<char, int>();

            foreach(char c in word1.ToCharArray())
            {
                if (!keyValuePairsWord1.ContainsKey(c))
                    keyValuePairsWord1.Add(c, 1);
                else
                {
                    int count = keyValuePairsWord1[c];
                    keyValuePairsWord1[c] = count + 1;
                }

            }

            foreach (char c in word2.ToCharArray())
            {
                if (!keyValuePairsWord2.ContainsKey(c))
                    keyValuePairsWord2.Add(c, 1);
                else
                {
                    int count = keyValuePairsWord2[c];
                    keyValuePairsWord2[c] = count + 1;
                }

            }


            List<char> keysWord1 = keyValuePairsWord1.Keys.ToList();
            keysWord1.Sort();

            List<char> keysWord2 = keyValuePairsWord2.Keys.ToList();
            keysWord2.Sort();

            if (!keysWord1.SequenceEqual(keysWord2))
                return false;



            List<int> freqValueWord1 = keyValuePairsWord1.Values.ToList();
            freqValueWord1.Sort();

            List<int> freqValueWord2 = keyValuePairsWord2.Values.ToList();
            freqValueWord2.Sort();

            return freqValueWord1.SequenceEqual(freqValueWord2);
        }
        public string RemoveStars(string s)
        {
            Stack<char> stackOfChars = new Stack<char>();

            for(int i=0; i<s.Length; i++)
            {
                if (s[i] == '*')
                {
                    if (stackOfChars.Count > 0)
                        stackOfChars.Pop();

                    continue;
                }
                else
                    stackOfChars.Push(s[i]);

            }

            StringBuilder answer = new StringBuilder();

            while (stackOfChars.Count > 0)
            {
                answer.Append(stackOfChars.Pop());
            }

            char[] reversedArray = answer.ToString().ToCharArray();

           Array.Reverse(reversedArray);
           return new string(reversedArray);
        }

        public int[] AsteroidCollision(int[] asteroids)
        {
            Stack<int> asteroidStack = new Stack<int>();

            foreach(int asteroid in asteroids)
            {
                bool toBeAdded = true;
                while(asteroidStack.Count > 0  && 
                    (asteroidStack.Peek() > 0 && asteroid < 0))
                {
                    if(Math.Abs(asteroidStack.Peek()) < Math.Abs(asteroid))
                    {
                        asteroidStack.Pop();
                        continue;
                    }
                    else if (Math.Abs(asteroidStack.Peek()) == Math.Abs(asteroid))
                      asteroidStack.Pop();

                    toBeAdded = false;
                    break;
                }

                if (toBeAdded)
                    asteroidStack.Push(asteroid);


            }

            int[] resultArray = asteroidStack.ToArray();

            Array.Reverse(resultArray);
            return resultArray;
        }

        public string DecodeString(string s)
        {
            Stack<string> stackOfChars = new Stack<string>();
            int count = 0;

            for (int i = 0; i<s.Length; i++)
            {
                
                StringBuilder substring = new StringBuilder();
                if (char.IsNumber(s[i]))
                {
                    count = Int32.Parse(s[i].ToString());
                    continue;
                }

                
                if (s[i] == '[')
                {                  
                    i++;
                    while (!(s[i] == ']'))
                    {
                        substring.Append(s[i]);
                        i++;
                    }

                }
                string sub = substring.ToString();
                while (count > 0)
                {
                    stackOfChars.Push(sub);
                    count--;

                }
            }
            string[] resultArray = stackOfChars.Reverse().ToArray();
            StringBuilder result = new StringBuilder();            
            foreach(string sub in resultArray)
            {
                result.Append(sub);
            }

            return result.ToString();

        }
        public string DecodeStringV2(string s)
        {
            Stack<int> countStack = new Stack<int>();
            Stack<StringBuilder> stringStack = new Stack<StringBuilder>();
            StringBuilder currentString = new StringBuilder();

            int count = 0;

            foreach(char ch in s)
            {
                if (char.IsDigit(ch))
                {
                    //count = Int32.Parse(ch.ToString());

                    count = count * 10 + ch - '0';
                }
                else if(ch == '[')
                {
                    countStack.Push(count);
                    stringStack.Push(currentString);

                    currentString = new StringBuilder();
                    count = 0;

                }
                else if(ch == ']')
                {
                    StringBuilder decodedString = stringStack.Pop();

                    for(int currentK = countStack.Pop(); currentK > 0; currentK--)
                    {
                        decodedString.Append(currentString);
                    }

                    currentString = decodedString;

                }
                else
                {
                    currentString.Append(ch);
                }
            }

            return currentString.ToString();
        }
        Queue<int> slideWindow;
        public void RecentCounter()
        {
            //this.slideWindow = new LinkedList<int>();

            this.slideWindow = new Queue<int>();
        }
        public int Ping(int t)
        {
            
            //this.slideWindow.AddLast(t);
            this.slideWindow.Enqueue(t);

            while (this.slideWindow.Count > 0 && this.slideWindow.Peek() < t - 3000)
                this.slideWindow.Dequeue();

            return this.slideWindow.Count();
        }
        public string PredictPartyVictory(string senate)
        {
            int n = senate.Length;

            Queue<int> rQueue = new Queue<int>();
            Queue<int> dQueue = new Queue<int>();

            for(int i=0; i<n; i++)
            {
                if (senate[i] == 'R')
                    rQueue.Enqueue(i);
                else
                    dQueue.Enqueue(i);
            }

            while(rQueue.Count > 0 && dQueue.Count > 0)
            {

                int rTurn = rQueue.Dequeue();
                int dTurn = dQueue.Dequeue();

                if (dTurn < rTurn)
                {
                    dQueue.Enqueue(dTurn + n);
                }
                else
                {
                    rQueue.Enqueue(dTurn + n);
                }

            }

            return rQueue.Count == 0 ? "Dire" : "Radiant";

        }
    }


}
