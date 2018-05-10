namespace FootballStandings
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class StartUp
    {
        public static void Main()
        {
            var leagueStandings = new Dictionary<string, int>();
            var topScores = new Dictionary<string, long>();

            var key = Console.ReadLine();
            key = Regex.Escape(key);

            var pattern = $@"{key}(.*?){key}.*?{key}(.*?){key}.*?(\d+)\:(\d+)";
            var regex = new Regex(pattern);

            var input = Console.ReadLine();

            while (input != "final")
            {
                var matches = regex.Matches(input);

                var firstTeam = string.Empty;
                var firstTeamScore = 0L;
                var firstTeamPoints = 0;
                var secondTeam = string.Empty;
                var secondTeamScore = 0L;
                var secondTeamPoints = 0;

                foreach (Match match in matches)
                {
                    firstTeam = new string(match.Groups[1].Value.ToUpper().Reverse().ToArray());
                    firstTeamScore = long.Parse(match.Groups[3].Value);

                    secondTeam = new string(match.Groups[2].Value.ToUpper().Reverse().ToArray());
                    secondTeamScore = long.Parse(match.Groups[4].Value);

                    if (!topScores.ContainsKey(firstTeam))
                        topScores[firstTeam] = 0;
                    topScores[firstTeam] += firstTeamScore;

                    if (!topScores.ContainsKey(secondTeam))
                        topScores[secondTeam] = 0;
                    topScores[secondTeam] += secondTeamScore;

                    if (firstTeamScore > secondTeamScore)
                    {
                        firstTeamPoints = 3;
                        secondTeamPoints = 0;
                    }
                    else if (firstTeamScore == secondTeamScore)
                    {
                        firstTeamPoints = 1;
                        secondTeamPoints = 1;
                    }
                    else if (firstTeamScore < secondTeamScore)
                    {
                        firstTeamPoints = 0;
                        secondTeamPoints = 3;
                    }

                    if (!leagueStandings.ContainsKey(firstTeam))
                        leagueStandings[firstTeam] = 0;
                    leagueStandings[firstTeam] += firstTeamPoints;

                    if (!leagueStandings.ContainsKey(secondTeam))
                        leagueStandings[secondTeam] = 0;
                    leagueStandings[secondTeam] += secondTeamPoints;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("League standings:");

            var leaguePlace = 1;
            foreach (var team in leagueStandings.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{leaguePlace}. {team.Key} {team.Value}");
                leaguePlace++;
            }

            Console.WriteLine("Top 3 scored goals:");

            foreach (var team in topScores.OrderByDescending(x => x.Value).ThenBy(x => x.Key).Take(3))
            {
                Console.WriteLine($"- {team.Key} -> {team.Value}");
            }
        }
    }
}