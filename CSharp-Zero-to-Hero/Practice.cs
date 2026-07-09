using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Zero_to_Hero
{
    public class Practice
    {
       //public static void Main(string[] args)
       // {
       //     int [] array = { 1, 2, 3, 4, 5, 2, 3 };
       //     Console.WriteLine(FindSecondLargest(array));
           
       // }
        public static string ReverseString(string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
        //Reverse a string without using built-in methods.
        public static string ReverseStringWithoutBuiltIn(string input)
        {
            StringBuilder reversed = new StringBuilder();
            for (int i = input.Length - 1; i >= 0; i--)
            {
                reversed.Append(input[i]);
            }
            return reversed.ToString();
        }
        //Find duplicate elements in an array.
        public static List<int> FindDuplicates(int[] array)
        {
            HashSet<int> seen = new HashSet<int>();
            List<int> duplicates = new List<int>();
            foreach (int number in array)
            {
                if (seen.Contains(number))
                {
                    if (!duplicates.Contains(number))
                    {
                        duplicates.Add(number);
                    }
                }
                else
                {
                    seen.Add(number);
                }
            }
            return duplicates;
        }
        //Find second largest number in an array.
        public static int FindSecondLargest(int[] array)
        {
            int largest = int.MinValue;
            int secondLargest = int.MinValue;
            foreach (int number in array)
            {
                if (number > largest)
                {
                    secondLargest = largest;
                    largest = number;
                }
                else if (number > secondLargest && number != largest)
                {
                    secondLargest = number;
                }
            }
            return secondLargest;
        }
        //Check if a string is palindrome.
        public static bool IsPalindrome(string input)
        {
            int left = 0;
            int right = input.Length - 1;
            while (left < right)
            {
                if (input[left] != input[right])
                {
                    return false;
                }
                left++;
                right--;
            }
            return true;
        }
    }
}
