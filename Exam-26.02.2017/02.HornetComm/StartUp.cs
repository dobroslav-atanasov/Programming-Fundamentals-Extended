namespace HornetComm
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class StartUp
    {
        public static void Main()
        {
            List<Broadcast> broadcasts = new List<Broadcast>();
            List<Message> messages = new List<Message>();

            string privateMessagePattern = @"(^\d+)\s\<\-\>\s([A-Za-z0-9]+)$";
            string broadcastPattern = @"(^\D+)\s\<\-\>\s([A-Za-z0-9]+)$";

            Regex privateRegex = new Regex(privateMessagePattern);
            Regex broadcastRegex = new Regex(broadcastPattern);

            string input = Console.ReadLine();

            while (input != "Hornet is Green")
            {
                Match privateMatch = privateRegex.Match(input);
                Match broadcastMatch = broadcastRegex.Match(input);

                if (privateMatch.Success)
                {
                    string recipientCode = privateMatch.Groups[1].Value;
                    string message = privateMatch.Groups[2].Value;

                    var recipientCodeReverse = new string(recipientCode.Reverse().ToArray());

                    Message newMessage = new Message()
                    {
                        Recipient = recipientCodeReverse,
                        Mes = message
                    };

                    messages.Add(newMessage);
                }
                else if (broadcastMatch.Success)
                {
                    string message = broadcastMatch.Groups[1].Value;
                    string frequency = broadcastMatch.Groups[2].Value;

                    string newFrequency = string.Empty;

                    foreach (var symbol in frequency)
                    {
                        if (symbol >= 65 && symbol <= 90)
                        {
                            newFrequency += symbol.ToString().ToLower();
                        }
                        else if (symbol >= 97 && symbol <= 122)
                        {
                            newFrequency += symbol.ToString().ToUpper();
                        }
                        else
                        {
                            newFrequency += symbol;
                        }
                    }

                    Broadcast newBroadcast = new Broadcast()
                    {
                        Frequency = newFrequency,
                        Message = message
                    };

                    broadcasts.Add(newBroadcast);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("Broadcasts:");

            if (broadcasts.Count > 0)
            {
                foreach (Broadcast broadcast in broadcasts)
                {
                    Console.WriteLine($"{broadcast.Frequency} -> {broadcast.Message}");
                }
            }
            else
            {
                Console.WriteLine("None");
            }

            Console.WriteLine("Messages:");

            if (messages.Count > 0)
            {
                foreach (Message message in messages)
                {
                    Console.WriteLine($"{message.Recipient} -> {message.Mes}");
                }
            }
            else
            {
                Console.WriteLine("None");
            }
        }
    }
}