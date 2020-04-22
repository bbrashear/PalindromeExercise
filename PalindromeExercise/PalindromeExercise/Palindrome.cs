using System;
using System.Collections.Generic;
using System.Text;

namespace PalindromeExercise
{
    public class Palindrome
    {

        public bool IsAPalindrome(string word)
        {
            bool isPalindrome;
            var arr = word.ToCharArray();
            Array.Reverse(arr);
            string reverseWord = new string(arr);
            if (word == reverseWord)
            {
                isPalindrome = true;
            }
            else
            {
                isPalindrome = false;
            }
            return isPalindrome;
        }

    }
}
