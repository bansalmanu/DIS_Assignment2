using System;
using System.Collections.Generic;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question1:

            Console.WriteLine("Question 1");
            int[] heights = { -5, 1, 5, 0, -7 };
            int max_height = LargestAltitude(heights);
            Console.WriteLine("Maximum altitude gained is {0}", max_height);
            Console.WriteLine();

            //Question 2:
            Console.WriteLine("Question 2:");
            int[] nums = { 0, 1, 2, 3, 12 };
            Console.WriteLine("Enter the target number:");
            int target = Int32.Parse(Console.ReadLine());
            int pos = SearchInsert(nums, target);
            Console.WriteLine("Insert Position of the target is : {0}", pos);
            Console.WriteLine("");

            //Question3:
            Console.WriteLine("Question 3");
            string[] words1 = { "bella", "label", "roller" };
            List<string> commonWords = CommonChars(words1);
            Console.WriteLine("Common characters in all the strigs are:");
            for (int i = 0; i < commonWords.Count; i++)
            {
                Console.Write(commonWords[i] + "\t");
            }
            Console.WriteLine();

            //Question 4:
            Console.WriteLine("Question 4");
            int[] arr1 = { 1, 2, 2, 1, 1, 3 };
            bool unq = UniqueOccurrences(arr1);
            if (unq)
                Console.WriteLine("Number of Occurences of each element are same");
            else
                Console.WriteLine("Number of Occurences of each element are not same");

            Console.WriteLine();

            //Question 5:
            Console.WriteLine("Question 5");
            List<List<string>> items = new List<List<string>>();
            items.Add(new List<string>() { "phone", "blue", "pixel" });
            items.Add(new List<string>() { "computer", "silver", "lenovo" });
            items.Add(new List<string>() { "phone", "gold", "iphone" });

            string ruleKey = "color";
            string ruleValue = "silver";

            int matches = CountMatches(items, ruleKey, ruleValue);
            Console.WriteLine("Number of matches for the given rule :{0}", matches);

            Console.WriteLine();

            //Question 6:
            Console.WriteLine("Question 6");
            int[] Nums = { 2, 7, 11, 15 };
            int target_sum = 9;
            targetSum(Nums, target_sum);
            Console.WriteLine();

            //Question 7:

            Console.WriteLine("Question 7:");
            string allowed = "ab";
            string[] words = { "ad", "bd", "aaab", "baa", "badab" };
            int count = CountConsistentStrings(allowed, words);
            Console.WriteLine("Number of Consistent strings are : {0}", count);
            Console.WriteLine(" ");

            //Question 8:
            Console.WriteLine("Question 8");
            int[] num1 = { 12, 28, 46, 32, 50 };
            int[] num2 = { 50, 12, 32, 46, 28 };
            int[] indexes = AnagramMappings(num1, num2);
            Console.WriteLine("Mapping of the elements are");
            for (int i = 0; i < indexes.Length; i++)
            {
                Console.Write(indexes[i] + "\t");
            }
            Console.WriteLine();
            Console.WriteLine();

            //Question 9:
            Console.WriteLine("Question 9");
            int[] arr9 = { 7, 1, 5, 3, 6, 4 };
            int Ms = MaximumSum(arr9);
            Console.WriteLine("Maximun Sum contiguous subarray {0}", Ms);
            Console.WriteLine();

            //Question 10:
            Console.WriteLine("Question 10");
            int[] arr10 = { 2, 3, 1, 2, 4, 3 };
            int target_subarray_sum = 7;
            int minLen = minSubArrayLen(target_subarray_sum, arr10);
            Console.WriteLine("Minimum length subarray with given sum is {0}", minLen);
            Console.WriteLine();
        }


        /*
        Question 1:
        There is a biker going on a road trip. The road trip consists of n + 1 points at different altitudes. The biker starts his trip on point 0 with altitude equal 0.
        You are given an integer array gain of length n where gain[i] is the net gain in altitude between points i and i + 1  for all (0 <= i < n). Return the highest altitude of a point.
        Example 1:
        Input: gain = [-5,1,5,0,-7]
        Output: 1
        Explanation: The altitudes are [0,-5,-4,1,1,-6]. The highest is 1.
        */

        public static int LargestAltitude(int[] gain)
        {
            // in this question, I got to learn about iterating over an array and performing operations

            try
            {
                //creating a variable to store max altitude and initialising it with 0

                int max = 0;
                int currentAltitude = 0;
                if(gain.Length > 1)
                {
                    //iterating over the remaining values
                    for(int i =0; i < gain.Length; i++)
                    {
                        // storing the current altitude
                        currentAltitude = currentAltitude + gain[i];

                        // current is the max so far, storing it into max
                        if(currentAltitude> max)
                        {
                            max = currentAltitude;
                        }
                        
                    }
                }
                return max;
            }
            catch (Exception)
            {

                throw;
            }
        }

        /*
        
        Question 2:
        Given a sorted array of distinct integers and a target value, return the index if the target is found. If not, return the index where it would be if it were inserted in order.
        Note: The algorithm should have run time complexity of O (log n).
        Hint: Use binary search
        Example 1:
        Input: nums = [1,3,5,6], target = 5
        Output: 2
        Example 2:
        Input: nums = [1,3,5,6], target = 2
        Output: 1
        Example 3:
        Input: nums = [1,3,5,6], target = 7
        Output: 4
        */

        public static int SearchInsert(int[] nums, int target)
        {
            try
            {
                //in this question I understood the use of continue and break statements

                //setting the return index to length of the array to cover the case if number is not in the array and is greater than all of them
                int index = 0;

                for (int i =0; i < nums.Length; i++)
                {
                    // if number is smaller than the target number, we are continuing the loop
                    if(nums[i] < target)
                    {
                        continue;
                    }

                    // if number is either greater than or equal to the target number, we have found the desired index and we can exit the loop
                    else
                    {
                        index = i;
                        break;
                    }
                    
                }
                return index;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /*
         
        Question 3
       
        Given an array words of strings made only from lowercase letters, return a list of all characters that show up in all strings in words (including duplicates).  For example, if a character occurs 3 times in all strings but not 4 times, you need to include that character three times in the final answer.
        You may return the answer in any order.
        Example 1:
        Input: ["bella","label","roller"]
        Output: ["e","l","l"]
        Example 2:
        Input: ["cool","lock","cook"]
        Output: ["c","o"]
        
        */

        public static List<string> CommonChars(string[] words)
        {
            //This question taught me how to use a for loop to assign some variable and using it for some another task
            try
            {
                List<string> commonwords = new List<string>();
                

                foreach(char c in words[0])
                {
                    //creating a bool to store if c is in all words
                    bool isInAll = false;

                    //checking if character is in all the words and changing
                    for(int i =1; i < words.Length; i++)
                    {
                        if (words[i].Contains(c))
                        {
                            
                            isInAll = true;
                        }
                        else
                        {
                            
                            isInAll = false;
                            break;
                        }
                    }

                    // executing below code if c is in all words
                    if (isInAll)
                    {
                    
                        commonwords.Add(c.ToString());

                        //removing c from all the words
                        for (int i = 1; i < words.Length; i++)
                        {
                            int index = words[i].LastIndexOf(c);
                            words[i] = words[i].Remove(index,1);
             
                        }

                    }
                }
                
                
               

                return commonwords;
            }
            catch (Exception)
            {

                throw;
            }
        }

        /*
        Question 4:
        Given an array of integers arr, write a function that returns true if and only if the number of occurrences of each value in the array is unique.
        Example 1:
        Input: arr = [1,2,2,1,1,3]
        Output: true
        Explanation: The value 1 has 3 occurrences, 2 has 2 and 3 has 1. No two values have the same number of occurrences.
        Example 2:
        Input: arr = [1,2]
        Output: false
       
         */

        public static bool UniqueOccurrences(int[] arr)
        {
            // In this question, I learnt to use dictionaries better
            try
            {
                Dictionary<int, int> numberDict = new Dictionary<int, int>();

                // creating dictionary with number and its number of occurences
                foreach(int i in arr)
                {
                    if (numberDict.ContainsKey(i))
                    {
                        numberDict[i] = numberDict[i] + 1;
                    }
                    else
                    {
                        numberDict[i] = 1;
                    }
                }

                //adding the number of occurences to list and set
                HashSet<int> setOfValues = new HashSet<int>();
                List<int> listOfValues = new List<int>();

                foreach(int key in numberDict.Keys)
                {
                    setOfValues.Add(numberDict[key]);
                    listOfValues.Add(numberDict[key]);
                    

                }

                //if size of list and dict is same, all the occrences are unique
                return (setOfValues.Count == listOfValues.Count);
            }
            catch (Exception)
            {

                throw;
            }

        }

        /*
        
        Question 5:
        You are given an array items, where each items[i] = [type, color, name]  describes the type, color, and name of the ith item. You are also given a rule represented by two strings, ruleKey and ruleValue.
        The ith item is said to match the rule if one of the following is true:
        •	ruleKey == "type" and ruleValue == type.
        •	ruleKey == "color" and ruleValue == color.
        •	ruleKey == "name" and ruleValue == name.
        Return the number of items that match the given rule.
        Example 1:
        Input:  items = [["phone","blue","pixel"],["computer","silver","lenovo"],["phone","gold","iphone"]],  ruleKey = "color",  ruleValue = "silver".
        Output: 1
        Explanation: There is only one item matching the given rule, which is ["computer","silver","lenovo"].
        Example 2:
        Input: items = [["phone","blue","pixel"],["computer","silver","phone"],["phone","gold","iphone"]], ruleKey = "type",  ruleValue = "phone"
        Output: 2
        Explanation: There are only two items matching the given rule, which are ["phone","blue","pixel"]  and ["phone","gold","iphone"]. 
        Note that the item ["computer","silver","phone"] does not match.
        */

        public static int CountMatches(List<List<string>> items, string ruleKey, string ruleValue)
        {
            // this question helped me understand the use of switch case to reduce code complexity
            try
            {
                //initialising the number to be returned
                int numberOfMatches = 0 ;

                int indexTobeChecked = 0;
                //setting the index of items to be checked
                switch (ruleKey)
                {
                    case "type":
                        indexTobeChecked = 0;
                        break;
                    case "color":
                        indexTobeChecked = 1;
                        break;
                    case "name":
                        indexTobeChecked = 2;
                        break;

                }

                //checking the each item for that index
                foreach(List<string> item in items)
                {
                    if(item[indexTobeChecked] == ruleValue)
                    {
                        numberOfMatches++;
                    }
                }
                return numberOfMatches;
            }
            catch (Exception)
            {

                throw;
            }
        }

        /*
        
        Question 6:
        
        Given an array of integers numbers that is already sorted in non-decreasing order, find two numbers such that they add up to a specific target number.
        Print the indices of the two numbers (1-indexed) as an integer array answer of size 2, where 1 <= answer[0] < answer[1] <= numbers. Length.
        You may not use the same element twice, there will be only one solution for a given array.
        Note: Solve it in O(n) and O(1) space complexity.
        Hint: Use the fact that array is sorted in ascending order and there exists only one solution.
        Typically, in these cases it’s useful to use pointers tracking the two ends of the array.
        Example 1:
        Input: numbers = [2,7,11,15], target = 9
        Output: [1,2]
        Explanation: The sum of 2 and 7 is 9. Therefore index1 = 1, index2 = 2.
        Example 2:
        Input: numbers = [2,3,4], target = 6
        Output: [1,3]
        Example 3:
        Input: numbers = [-1,0], target = -1
        Output: [1,2]
        */

        public static void targetSum(int[] nums, int target)
        {
            // In this question , I learnt to use back iterations to reduce the total number of iterations and ultimately optimising the code 
            try
            {
                //write your code here.
                //print the answer in the function itself.

                //iterating numbers from front
                for (int i =0 ; i< nums.Length; i++)
                {
                    //iterating numbers from behind
                    for(int j = (nums.Length-1); j > i; j--)
                    {
                        //checking if sum is equal to target 
                        if(nums[i]+nums[j]== target)
                        {
                            //if true, print and return;
                            Console.Write((i + 1) + " , " + (j + 1));
                            return;
                        }
                    }
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        /*
         
        Question 7:
        You are given a string allowed consisting of distinct characters and an array of strings words. A string is consistent if every character in words[i] appears in the string allowed.
        Return the number of consistent strings in the array words.
        Note: The algorithm should have run time complexity of O(n).
        Hint: Use Dictionaries. 
        Example 1:
        Input: allowed = "ab", words = ["ad","bd","aaab","baa","badab"]
        Output: 2
        Explanation: Strings "aaab" and "baa" are consistent since they only contain characters 'a' and 'b'. string “bd” is not consistent since ‘d’ is not in string allowed.
        Example 2:
        Input: allowed = "abc", words = ["a","b","c","ab","ac","bc","abc"]
        Output: 7
        Explanation: All strings are consistent.
        */

        public static int CountConsistentStrings(string allowed, string[] words)
        {
            // This question taught mme concepts of set like subset
            

            try
            {
                //initialising a counter to count the number of consistent strings
                int count = 0;

                //iterating over list of strings
                foreach(string word in words)
                {
                    //converting each string to a set to avoid repetitive occurences
                    HashSet<char> setOfcharachtersInWord =  new HashSet<char>(word.ToCharArray());

                    //checking if all the characters are subset of allowed and increasing the counter
                    if (setOfcharachtersInWord.IsSubsetOf(allowed))
                    {
                        count++;
                    }
                    
                }
                return count;
            }
            catch (Exception)
            {

                throw;
            }
        }

        /*
        Question 8:
        You are given two integer arrays nums1 and nums2 where nums2 is an anagram of nums1. Both arrays may contain duplicates.
        Return an index mapping array mapping from nums1 to nums2 where mapping[i] = j indicates that  the ith element in nums1 appears in nums2 at index j. If there are multiple answers, return any of them.
        An array a is an anagram of array b if b is made by randomizing the order of the elements in a.
 
        Example 1:
        Input: nums1 = [12,28,46,32,50], nums2 = [50,12,32,46,28]
        Output: [1,4,3,2,0]
        Explanation: As mapping[0] = 1 because the 0th element of nums1 appears at nums2[1], and mapping[1] = 4 because the 1st element of nums1 appears at nums2[4], and so on.
        */

        public static int[] AnagramMappings(int[] nums1, int[] nums2)
        {
            // this taught me to use nested loops better
            try
            {
                //write your code here.

                //initialising output array to length of input array
                int[] ans = new int[nums1.Length];

                for(int i = 0; i < nums1.Length; i++)
                {
                    for(int j=0; j < nums2.Length; j++)
                    {
                        //if number in nums2 matches nums1, storing the index in output
                        if( nums1[i] == nums2[j])
                        {
                            ans[i] = j;
                        }
                    }
                }

                return ans;
            }
            catch (Exception)
            {
                throw;
            }
        }
        /*
        
        Question 9:
        Given an integer array nums, find the contiguous subarray (containing at least one number) which has the largest sum and return its sum.
        Note: Time Complexity should be O(n).
        Hint: Keep track of maximum sum as you move forward.
        Example 1:
        Input: nums = [-2,1,-3,4,-1,2,1,-5,4]
        Output: 6
        Explanation: [4,-1,2,1] has the largest sum = 6.
        Example 2:
        Input: nums = [1]
        Output: 1
        */

        public static int MaximumSum(int[] arr)
        {
         
            // this was a really great question and really had me scratching my head. I learnt alot of concepts about optimisation

            try
            {
                //maxSum keeps the ongoing Sum if it is greater than the current number
                int maxSum = arr[0];

                // if adding a number is decreasing the maxmum sum, I am storing the max sum in previous max sum
                int previousMax = arr[0];

                //iterating over the list of numbers
                for (int i =1; i < arr.Length; i++)
                {
                    //if on  adding a number to maxSum is still lower than that number then,
                    //I am changing the start point to that number and setting the maxsum and previousSum to that number
                    if(maxSum+arr[i] < arr[i])
                    {
                        maxSum = arr[i];
                        previousMax = arr[i];
                    }

                    //if on  adding a number to maxSum is lowering my maxSum but there is possibility of gradual increase,
                    // I am storing the maxSum in previousMax and continuing with addition
                    else if (maxSum + arr[i] < maxSum)
                    {
                        previousMax = maxSum;
                        maxSum = maxSum + arr[i];
                    }
                    //normal case
                    else
                    {
                        maxSum = maxSum + arr[i];
                    }
                }

                //returning the larger value between max sum and previous max
                if (previousMax > maxSum)
                {
                    return previousMax;
                }
                return maxSum;
            }
            catch (Exception)
            {

                throw;
            }
        }

        /*
         
        Question 10:
        Given an array of positive integers nums and a positive integer target, return the minimal length of a contiguous subarray [nums[l], nums[l+1], ..., nums[r-1], nums[r]] of which the sum is greater than or equal to target. If there is no such subarray, return 0 instead.
        Note: Try to solve it in O(n) time.
        Hint: Try to create a window and track the sum you have in the window.
        Example 1:
        Input: target = 7, nums = [2,3,1,2,4,3]
        Output: 2
        Explanation: The subarray [4,3] has the minimal length under the problem constraint.
        Example 2:
        Input: target = 4, nums = [1,4,4]
        Output: 1
        */

        public static int minSubArrayLen(int target_subarray_sum, int[] arr10)
        {

            // this was again a really great question and really had me scratching my head. I learnt alot of concepts about optimisation

            // I am defining a function to check the sum 
            bool isSumFine(int sum)
            {
                return (sum >= target_subarray_sum);
            }
          try
            {
                // This list is to capture the window
                List<int> window = new List<int>();

                //initialising everything with first element
                window.Add(arr10[0]);
                int sumOfNumbers = arr10[0];
                int currentGap = target_subarray_sum - sumOfNumbers;
               
                // if requirement is met at first element, returning the index
                if (isSumFine(sumOfNumbers))
                {
                    return window.Count;
                }

                //iterating over the remaining list
                for (int i = 1; i < arr10.Length; i++)
                {
                    //adding element to the list and sum
                    sumOfNumbers =sumOfNumbers+arr10[i];
                    window.Add(arr10[i]);

                    //checking if the requirement is met
                    if (isSumFine(sumOfNumbers))
                    {
                        int testNumber = sumOfNumbers - window[0];

                        //checking if deleting the first element will still keep the sum fine, if it does
                        // I am shrinking the list from starting point 
                        while (isSumFine(testNumber))
                        {
                            sumOfNumbers = sumOfNumbers - window[0];
                            window.RemoveAt(0);
                            testNumber = sumOfNumbers - window[0];

                            //if at any point the index is 1 and sum is fine, I am returning the length of list
                            if(isSumFine(sumOfNumbers) & (window.Count == 1)){
                                return window.Count;
                            }
                        }
                    }

                }

                if(sumOfNumbers > target_subarray_sum)
                {
                    int testNumber2 = sumOfNumbers - window[window.Count - 1];

                    //checking if deleting the last element will still keep the sum fine, if it does
                    // I am shrinking the list from ending point 
                    while (isSumFine(testNumber2))
                    {
                        sumOfNumbers = sumOfNumbers - window[window.Count - 1];
                        window.RemoveAt(window.Count - 1);
                        testNumber2 = sumOfNumbers - window[window.Count - 1];
                    }
                }
                

                //returning the length of list
                return window.Count;

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
