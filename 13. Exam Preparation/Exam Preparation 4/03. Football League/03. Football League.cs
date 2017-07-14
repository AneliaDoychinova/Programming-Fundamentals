using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Football_League
{
    class Program
    {
        static void Main(string[] args)
        {
            var key = Regex.Escape( Console.ReadLine());
            var pattern = new Regex(string.Format(@"{0}(?<firstTeam>.*?){0}.+?{0}(?<secondTeam>.*?){0}.+?(?<teamOneGoals>\d+):(?<teamTwoGoals>\d+)",key));

            var teams = new Dictionary<string, Team>();
            var input = Console.ReadLine();

            while (input != "final")
            {
                Match match = pattern.Match(input);
                if (match.Success)
                {
                    var firstTeam = match.Groups["firstTeam"].Value.ToUpper().Reverse().ToArray();
                var firstTeamName = new string(firstTeam);

                var secondTeam = match.Groups["secondTeam"].Value.ToUpper().Reverse().ToArray();
                var secondTeamName = new string(secondTeam);

                var firstGoals = long.Parse(match.Groups["teamOneGoals"].Value);
                var secondGoals = long.Parse(match.Groups["teamTwoGoals"].Value);

                FillScores(firstTeamName, firstGoals, secondGoals,teams);
                FillScores(secondTeamName,secondGoals, firstGoals,teams);
                }
                

                input = Console.ReadLine();
            }
            PrintStandings(teams);
            PrintTop3Goals(teams);
        }

        private static void PrintTop3Goals(Dictionary<string, Team> teams)
        {
            Console.WriteLine("Top 3 scored goals:");
            foreach (var team in teams.OrderByDescending(g => g.Value.Goals).ThenBy(n =>n.Value.Name).Take(3))
            {
                Console.WriteLine("- {0} -> {1}", team.Value.Name, team.Value.Goals);
  
            }
        }

        private static void PrintStandings(Dictionary<string, Team> teams)
        {
            Console.WriteLine("League standings:");
            var count = 0;
            foreach (var team in teams.OrderByDescending(p => p.Value.Points).ThenBy(n => n.Value.Name))
            {
                count++;
                Console.WriteLine("{0}. {1} {2}", count, team.Value.Name, team.Value.Points);
            }
        }

        private static void FillScores(string teamName, long teamGoals, long oponentGoals, Dictionary<string,Team>teams)
        {
            var goals = teamGoals;
            var points = 0;
            if (teamGoals > oponentGoals)
            {
                points = 3;
            }
            else if (teamGoals == oponentGoals)
            {
                points = 1;
            }

            if (!teams.ContainsKey(teamName))
            {
                teams[teamName] = new Team() {Name = teamName};
            }
            teams[teamName].Goals += goals;
            teams[teamName].Points += points;

        }

        class Team
        {
            public string Name { get; set; }

            public long Goals { get; set; }

            public int Points { get; set; }

        }
    }
}
