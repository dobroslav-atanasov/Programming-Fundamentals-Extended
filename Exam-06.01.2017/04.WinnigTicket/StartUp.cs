namespace WinnigTicket
{
    using System;
    using System.Text.RegularExpressions;

    public class StartUp
    {
        public static void Main()
        {
            var tickets = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

            var pattern = @"(\${6,})|(\@{6,})|(\^{6,})|(\#{6,})";
            var regex = new Regex(pattern);

            foreach (var ticket in tickets)
            {
                if (ticket.Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                }
                else
                {
                    var firstPart = ticket.Substring(0, 10);
                    var secondPart = ticket.Substring(10, 10);

                    var isValidFirst = regex.IsMatch(firstPart);
                    var isValidSecond = regex.IsMatch(secondPart);
                    var firstMatch = regex.Match(firstPart);
                    var secondMatch = regex.Match(secondPart);

                    if (isValidFirst && isValidSecond)
                    {
                        var smaller = Math.Min(firstMatch.Length, secondMatch.Length);

                        if (smaller <= 9)
                        {
                            Console.WriteLine($"ticket \"{ticket}\" - {smaller}{firstMatch.Value.ToString().Substring(0, 1)}");
                        }
                        else if (smaller == 10)
                        {
                            Console.WriteLine($"ticket \"{ticket}\" - {smaller}{firstMatch.Value.ToString().Substring(0, 1)} Jackpot!");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"ticket \"{ticket}\" - no match");
                    }

                }
            }
        }
    }
}
