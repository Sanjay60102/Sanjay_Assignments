using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Palindrome
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a word: ");
            string word = Console.ReadLine();
            // Remove any spaces and convert the word to lowercase
            string processedWord = word.Replace(" ", "").ToLower();

            // Reverse the processed word
            char[] charArray = processedWord.ToCharArray();
            Array.Reverse(charArray);
            string reversedWord = new string(charArray);

            // Check if the word is a palindrome
            bool isPalindrome = processedWord.Equals(reversedWord, StringComparison.OrdinalIgnoreCase);

            // Display whether the word is a palindrome
            if (isPalindrome)
            {
                Console.WriteLine("The word is a palindrome.");
            }
            else
            {
                Console.WriteLine("The word is not a palindrome.");
            }
        }
    }
}
