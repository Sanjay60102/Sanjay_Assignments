using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class ReverseWord
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a word: ");
            string word = Console.ReadLine();

            // Reverse the word
            char[] charArray = word.ToCharArray();
            Array.Reverse(charArray);
            string reversedWord = new string(charArray);

            // Display the reversed word
            Console.WriteLine("The reverse of the word is: " + reversedWord);
        }
    }
}
