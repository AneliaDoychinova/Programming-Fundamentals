using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Teamwork_Projects
{
    class Program
    {
        static void Main(string[] args)
        {
            var countOfTeams = int.Parse(Console.ReadLine());
            
            var teams = ReadTeams(countOfTeams);
            ReadMembers(teams);

            var teamsToDisband = teams
                .Where(x => x.Members.Count == 0)
                .OrderBy(x => x.Name)
                .ToList();

            var fullTeams = teams
            .Where(x => x.Members.Count > 0)
            .OrderByDescending(x => x.Members.Count)
            .ThenBy(x => x.Name)
            .ToList();

            PrintOutput(teamsToDisband, fullTeams);

        }

        private static void PrintOutput(List<Team> teamsToDisband, List<Team> fullTeams)
        {

            foreach (var team in fullTeams)
            {
                Console.WriteLine(team.Name);
                Console.WriteLine("- {0}", team.CreatorName);
                foreach (var member in team.Members.OrderBy(x => x))
                {
                    Console.WriteLine("-- {0}", member);
                }
            }
                Console.WriteLine("Teams to disband:");
            foreach (var team in teamsToDisband)
            {
                Console.WriteLine(team.Name);
            }
            
        }

        private static void ReadMembers(List<Team> teams)
        {
            var tokens = Console.ReadLine().Split(new char[] {'-', '>'}, StringSplitOptions.RemoveEmptyEntries);
            
            while (tokens[0] != "end of assignment")
            {
                var memberName = tokens[0];
                var teamToJoin = tokens[1];

                if (!teams.Select(x => x.Name).Contains(teamToJoin))
                {
                    Console.WriteLine("Team {0} does not exist!", teamToJoin);
                }
                else if (teams.Select(x => x.Members).Any(x => x.Contains(memberName)) || 
                    teams.Select(x => x.CreatorName).Contains(memberName))
                {
                    Console.WriteLine("Member {0} cannot join team {1}!", memberName, teamToJoin);
                }
                else
                {
                    int teamToJoinIndex = teams.FindIndex(x => x.Name == teamToJoin);
                    teams[teamToJoinIndex].Members.Add(memberName);
                }
                tokens = Console.ReadLine().Split(new char[] { '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
            }

        }

        private static List<Team> ReadTeams(int countOfTeams)
        {
            var teamsList = new List<Team>();

            for (int i = 0; i < countOfTeams; i++)
            {
                var tokens = Console.ReadLine().Split('-');
                var memberList = new List<string>();
                var team = new Team();

                team.CreatorName = tokens[0];
                team.Name = tokens[1];
                team.Members = memberList;

                if (!teamsList.Select(a => a.Name).Contains(team.Name))
                {
                    if (!teamsList.Select(a => a.CreatorName).Contains(team.CreatorName))
                    {
                        teamsList.Add(team);
                        Console.WriteLine("Team {0} has been created by {1}!", team.Name, team.CreatorName);
                    }
                    else
                    {
                        Console.WriteLine("{0} cannot create another team!", team.CreatorName);
                    }
                }
                else
                {
                    Console.WriteLine("Team {0} was already created!", team.Name);
                }
            }
            return teamsList;
        }

        class Team
        {
            public string Name { get; set; }

            public string CreatorName { get; set; }

            public List<string> Members { get; set; }
        }
    }
}
