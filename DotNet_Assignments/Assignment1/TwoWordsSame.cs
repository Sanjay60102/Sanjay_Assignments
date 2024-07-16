using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class TwoWordsSame
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first word: ");
            string word1 = Console.ReadLine();
            Console.Write("Enter the second word: ");
            string word2 = Console.ReadLine();

            // Compare the two words
            bool areSame = string.Equals(word1, word2, StringComparison.OrdinalIgnoreCase);

            // Display whether the words are the same
            if (areSame)
            {
                Console.WriteLine("The words are the same.");
            }
            else
            {
                Console.WriteLine("The words are different.");
            }
        }
    }
}
