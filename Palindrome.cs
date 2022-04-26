using System;

namespace PalindromeConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String palindrome = "bob";
            String nonPalindrome = "søren";

            isPalindrome(palindrome);
            isPalindrome(nonPalindrome);
        }

        private static void isPalindrome(String value)
        {
            char[] ch = value.ToCharArray();
            Array.Reverse(ch);
            String rev = new string(ch);
            bool b = value.Equals(rev, StringComparison.OrdinalIgnoreCase);
            if (b == true)
            {
                Console.WriteLine("" + value + " is a Palindrome!");
            }
            else
            {
                Console.WriteLine(" " + value + " is not a Palindrome!");
            }
        }
    }
}
