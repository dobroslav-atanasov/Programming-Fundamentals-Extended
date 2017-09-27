using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _05.Commits
{
    public class Commits
    {
        public static void Main()
        {
            var users = new Dictionary<string, Dictionary<string, List<Commit>>>();
            var input = Console.ReadLine();

            var pattern = @"https:\/\/github\.com\/([A-z\d\-]+)\/([A-z\-_]+)\/commit\/([a-f\d]{40})\,(.*?[^\n])\,(\d+)\,(\d+)";
            var regex = new Regex(pattern);

            while (input != "git push")
            {
                var matches = regex.Matches(input);
                var username = string.Empty;
                var repository = string.Empty;
                var commitHash = string.Empty;
                var message = string.Empty;
                var additions = 0;
                var deletions = 0;

                var isMatch = regex.IsMatch(input);

                if (isMatch)
                {
                    foreach (Match match in matches)
                    {
                        username = match.Groups[1].Value;
                        repository = match.Groups[2].Value;
                        commitHash = match.Groups[3].Value;
                        message = match.Groups[4].Value;
                        additions = int.Parse(match.Groups[5].Value);
                        deletions = int.Parse(match.Groups[6].Value);
                    }

                    if (!users.ContainsKey(username))
                    {
                        users[username] = new Dictionary<string, List<Commit>>();
                    }

                    if (!users[username].ContainsKey(repository))
                    {
                        users[username][repository] = new List<Commit>();
                        var newCommit = new Commit
                        {
                            CommitHash = commitHash,
                            Message = message,
                            Additions = additions,
                            Deletions = deletions
                        };

                        users[username][repository].Add(newCommit);
                    }
                    else
                    {
                        var newCommit = new Commit
                        {
                            CommitHash = commitHash,
                            Message = message,
                            Additions = additions,
                            Deletions = deletions
                        };

                        users[username][repository].Add(newCommit);
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var user in users.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{user.Key}:");

                var repos = user.Value;
                foreach (var repo in repos.OrderBy(x => x.Key))
                {
                    Console.WriteLine($"  {repo.Key}:");

                    var commits = repos.Values;
                    var totalAdd = 0;
                    var totalDelete = 0;

                    foreach (var commit in commits)
                    {
                        foreach (var element in commit)
                        {
                            totalAdd += element.Additions;
                            totalDelete += element.Deletions;

                            Console.WriteLine($"    commit {element.CommitHash}: {element.Message} ({element.Additions} additions, {element.Deletions} deletions)");
                        }
                    }

                    Console.WriteLine($"    Total: {totalAdd} additions, {totalDelete} deletions");
                }
            }
        }
    }
}
