using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment9
{
    class Participant
    {
        public string Name { get; set; }
        public string Country { get; set; }
    }
    internal class Exercise2
    {
        static void Main()
        {
            var participants = new List<Participant>
        {
            new Participant { Name = "Alice", Country = "USA" },
            new Participant { Name = "Bob", Country = "UK" },
            new Participant { Name = "Charlie", Country = "USA" },
            new Participant { Name = "David", Country = "UK" },
            new Participant { Name = "Rohith", Country = "USA" },
            new Participant { Name = "Virat", Country = "UK" }
        };

            var n = participants.Count / 2;
            var group1 = participants.Take(n).ToList();
            var group2 = participants.Skip(n).ToList();

            var matches = from p1 in group1
                          from p2 in group2
                          where p1.Country != p2.Country
                          select new { Player1 = p1.Name, Player2 = p2.Name };

            Console.WriteLine("Possible matches:");
            foreach (var match in matches)
            {
                Console.WriteLine($"{match.Player1} vs {match.Player2}");
            }
        }
    }
}
