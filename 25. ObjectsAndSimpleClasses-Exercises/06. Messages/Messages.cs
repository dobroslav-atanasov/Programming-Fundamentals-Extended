using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.Messages
{
    public class Messages
    {
        public static void Main()
        {
            var users = new List<string>();
            var senders = new Dictionary<string, Message>();

            var input = Console.ReadLine();

            while (input != "exit")
            {
                var tokens = input.Split(' ').ToArray();

                if (tokens[0] == "register")
                {
                    users.Add(tokens[1]);
                }
                else
                {
                    var sender = tokens[0];
                    var recipient = tokens[2];
                    var content = tokens[3];
                    var newUser = new User();
                    var message = new Message();

                    if (users.Contains(sender) && users.Contains(recipient))
                    {
                        if (!senders.ContainsKey(sender))
                        {
                            message.Sender = sender;
                            message.Content = new List<string>();
                            senders.Add(message.Sender, message);
                        }
                        if (!senders.ContainsKey(recipient))
                        {
                            var newMessage = new Message
                            {
                                Sender = recipient,
                                Content = new List<string>()
                            };
                            senders.Add(newMessage.Sender, newMessage);
                        }

                        senders[sender].Content.Add(content);
                    }
                }

                input = Console.ReadLine();
            }

            var newInput = Console.ReadLine().Split(' ').ToArray();
            var firstUser = newInput[0];
            var secondUser = newInput[1];
            var isNoMessage = false;

            if (senders.ContainsKey(firstUser) && senders.ContainsKey(secondUser))
            {
                var max = Math.Max(senders[firstUser].Content.Count, senders[secondUser].Content.Count);
                var firstCount = senders[firstUser].Content.Count;
                var secondCount = senders[secondUser].Content.Count;

                for (int i = 0; i < max; i++)
                {
                    if (senders.ContainsKey(firstUser) && firstCount > 0)
                    {
                        Console.WriteLine($"{senders[firstUser].Sender}: {senders[firstUser].Content[i]}");
                        isNoMessage = true;
                    }
                    if (senders.ContainsKey(secondUser) && secondCount > 0)
                    {
                        Console.WriteLine($"{senders[secondUser].Content[i]} :{senders[secondUser].Sender}");
                        isNoMessage = true;
                    }

                    firstCount--;
                    secondCount--;
                }
            }

            if (!isNoMessage)
            {
                Console.WriteLine("No messages");
            }
        }
    }
}
