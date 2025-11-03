//using System.Xml.Linq;

//namespace _05_TeamworkProjects
//{
//    internal class Program
//    {
//        class Team
//        {
//            public Team(string teamName, string creator)
//            {
//                TeamName = teamName;
//                Creator = creator;
//                Members = new List<string>();
//            }

//            public string TeamName { get; set; }
//            public string Creator { get; set; }
//            public List<string> Members { get; set; }


//            public override string ToString()
//            {
//                return $"{TeamName}\n" +
//                       $"- {Creator}\n" +
//                       $"{GetMembersString()}";
//            }

//            private string GetMembersString()
//            {
//                Members = Members
//                    .OrderBy(name => name)
//                    .ToList();

//                string result = "";
//                for (int i = 0; i < Members.Count - 1; i++)
//                {
//                    result += $"-- {Members[i]}\n";
//                }

//                result += $"-- {Members[Members.Count - 1]}";
//                return result;
//            }

//        }

//        static void Main(string[] args)
//        {
//            int countOfTeams = int.Parse(Console.ReadLine());

//            List<Team> teams = new List<Team>();

//            for (int i = 0; i < countOfTeams; i++)
//            {
//                string[] info = Console.ReadLine().Split("-");

//                string creator = info[0];
//                string teamName = info[1];

//                Team sameCreator = teams.Find(t => t.Creator == creator);

//                if (sameCreator != null)
//                {
//                    Console.WriteLine($"{creator} cannot create another team!");
//                }

//                Team sameTeam = teams.Find(t => t.TeamName == teamName);

//                if (sameTeam != null)
//                {
//                    Console.WriteLine($"Team {sameTeam.TeamName} was already created!");
//                    continue;
//                }

//                Team team = new Team(teamName, creator);
//                teams.Add(team);

//                Console.WriteLine($"Team {team.TeamName} has been created by {team.Creator}!");
//            }

//            string command;

//            while ((command = Console.ReadLine()) != "end of assignment")
//            {
//                string[] action = command.Split("->");

//                string memberName = action[0];
//                string teamName = action[1];

//                if (!teams.Any(team => team.TeamName == teamName))
//                {
//                    Console.WriteLine($"Team {teamName} does not exist!");
//                }

//                if (teams.Any(team => team.Creator == memberName) ||
//                    teams.Any(team => team.Members.Contains(memberName)))
//                {
//                    Console.WriteLine($"Member {memberName} cannot join team {teamName}!");
//                }

//                Team foundTeam = teams.Find(team => team.TeamName == teamName);
//                foundTeam.Members.Add(memberName);
//            }

//            List<Team> validTeams = teams.FindAll(team => team.Members.Count > 0);
//            List<Team> invalidTeams = teams.FindAll(team => team.Members.Count == 0);

//            validTeams = validTeams.OrderByDescending(team => team.Members.Count)
//                .ThenBy(team => team.TeamName)
//                .ToList();

//            invalidTeams = invalidTeams.
//                OrderBy(team => team.TeamName)
//                .ToList();


//            foreach (Team team in validTeams)
//            {
//                Console.WriteLine(team.ToString());
//            }

//            Console.WriteLine("Teams to disband:");
//            foreach (Team team in invalidTeams)
//            {
//                Console.WriteLine(team.TeamName);
//            }
//        }
//    }
//}

// Revisit 