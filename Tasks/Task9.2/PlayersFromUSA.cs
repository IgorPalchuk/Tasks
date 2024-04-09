using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9._2
{
    public class PlayersFromUSA
    {
        public string Country { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int BirthYear { get; set; }
        public int Rating { get; set; }
        public int Id { get; set; }

        public override string ToString()
        {
            return $"Full Name = {FirstName} {LastName}, Rating = {Rating}, from {Country}, born in {BirthYear}";
        }

        public static PlayersFromUSA Parse(string line)
        {
            string[] split = line.Split(';');
            return new PlayersFromUSA()
            {
                Id = int.Parse(split[0]),
                LastName = split[1].Split(',')[0].Trim(),
                FirstName = split[1].Split(',')[1].Trim(),
                Country = split[3],
                Rating = int.Parse(split[4]),
                BirthYear = int.Parse(split[6])
            };
        }
         public static void AllPlayersFromUSA(string path)
        {
            IEnumerable<PlayersFromUSA> players = File.ReadAllLines(path)
                                                      .Skip(1)
                                                      .Select(x => PlayersFromUSA.Parse(x))
                                                      .Where(x => x.Country == "USA")
                                                      .OrderBy(x => x.BirthYear)
                                                      .ToList();
            foreach(var item in players)
            {
                Console.WriteLine(item);
            }


        }
    }
}
