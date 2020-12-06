using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05.TeamworkProjects
{
    class Program
    {
        static void Main(string[] args)
        {
            int teamsCount = int.Parse(Console.ReadLine());
            List<Team> teams = new List<Team>();

            for (int i = 0; i < teamsCount; i++)
            {
                string[] newTeam = Console.ReadLine().Split("-");
                string creator = newTeam[0];
                string teamName = newTeam[1];

                Team team = new Team(teamName, creator);

                bool isTeamNameExist = teams.Select(x => x.TeamName)
                                            .Contains(teamName);
                bool isCreatorExist = teams.Select(x => x.Creator)
                                            .Contains(creator);

                if (!isTeamNameExist)
                {
                    if (!isCreatorExist)
                    {
                        teams.Add(team);
                        Console.WriteLine($"Team {teamName} has been created by {creator}!");
                    }
                    else
                    {
                        Console.WriteLine($"{creator} cannot create another team!");
                    }
                }
                else
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                }

            }

            string teamMembers = Console.ReadLine();

            while (teamMembers != "end of assignment")
            {
                string[] currentCommand = teamMembers.Split("->");
                string newUser = currentCommand[0];
                string teamName = currentCommand[1];

                bool isTeamExist = teams.Select(x => x.TeamName)
                                        .Contains(teamName);
                bool isCreatorExist = teams.Select(x => x.Creator)
                                           .Contains(newUser);
                bool isMemberExist = teams.Select(x => x.Members)
                                          .Any(x => x.Contains(newUser));

                if (!isTeamExist)
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                }
                else if (isCreatorExist || isMemberExist)
                {
                    Console.WriteLine($"Member {newUser} cannot join team {teamName}!");
                }
                else
                {
                    int index = teams.FindIndex(x => x.TeamName == teamName);
                    teams[index].Members.Add(newUser);
                }
                
                teamMembers = Console.ReadLine();
            }

            Team[] teamsToDisband = teams.OrderBy(x => x.TeamName)
                                         .Where(x => x.Members.Count == 0)
                                         .ToArray();
            
            Team[] fullTeam = teams.OrderByDescending(x => x.Members.Count)
                                   .ThenBy(x => x.TeamName)
                                   .Where(x => x.Members.Count > 0)
                                   .ToArray();

            StringBuilder sb = new StringBuilder();

            foreach (Team team in fullTeam)
            {
                sb.AppendLine($"{team.TeamName}");
                sb.AppendLine($"- {team.Creator}");

                foreach (var currentMember in team.Members.OrderBy(x=>x))
                {
                    sb.AppendLine($"-- {currentMember}");
                }
            }

            sb.AppendLine("Teams to disband:");

            foreach (Team team in teamsToDisband)
            {
                sb.AppendLine(team.TeamName);
            }

            Console.WriteLine(sb.ToString());
        }
    }
    class Team
    {
        public Team(string teamName, string creator)
        {
            TeamName = teamName;
            Creator = creator;
            Members = new List<string>();
        }
        public string TeamName { get; set; }
        public string Creator { get; set; }
        public List<string> Members { get; set; }
    }
}
