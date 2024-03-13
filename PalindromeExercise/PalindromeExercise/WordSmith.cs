using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeExercise
{
    public class WordSmith
    {
        //In your WordSmith class, you will create a method (IsAPalindrome)
        //that will take a parameter of type string and return a value of type bool.
        //If the given input is a palindrome – return true, else return false.
        //You will finish this method after you write your tests.
        public bool IsAPalindrome(string word) 
        {
            var reversed = "";
            for (int i = word.Length - 1; i >= 0; i--)
            {
                reversed += word[i];
            }
            if (reversed == word) 
            {
                return true;
            }
            else 
            {
                return false;
            }
        }
    }
}
