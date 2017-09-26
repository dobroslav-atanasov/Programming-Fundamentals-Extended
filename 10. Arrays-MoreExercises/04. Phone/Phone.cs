namespace _04.Phone
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;

    public class Phone
    {
        public static void Main()
        {
            var phoneNumbers = Console.ReadLine().Split(' ').ToArray();
            var names = Console.ReadLine().Split().ToArray();

            var input = Console.ReadLine().Split(' ').ToArray();

            while (input[0] != "done")
            {
                if (input[0] == "call")
                {
                    for (int i = 0; i < phoneNumbers.Length; i++)
                    {
                        if (input[1] == phoneNumbers[i])
                        {
                            Console.WriteLine($"calling {names[i]}...");

                            var sum = 0;
                            var numberString = phoneNumbers[i].Split(new[] { '+', '(', ')', '-' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                            for (int j = 0; j < numberString.Length; j++)
                            {
                                var number = long.Parse(numberString[j]);
                                while (number > 0)
                                {
                                    var lastDigit = number % 10;
                                    sum += (int)lastDigit;
                                    number /= 10;
                                }
                            }

                            if (sum % 2 != 0)
                            {
                                Console.WriteLine("no answer");
                            }
                            else
                            {
                                var seconds = TimeSpan.FromSeconds(sum);
                                string time = seconds.ToString(@"mm\:ss");
                                Console.WriteLine($"call ended. duration: {time}");
                            }
                        }
                        else if (input[1] == names[i])
                        {
                            Console.WriteLine($"calling {phoneNumbers[i]}...");

                            var sum = 0L;
                            var numberString = phoneNumbers[i].Split(new[] { '+', '(', ')', '-' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                            for (int j = 0; j < numberString.Length; j++)
                            {
                                var number = long.Parse(numberString[j]);
                                while (number > 0)
                                {
                                    var lastDigit = number % 10;
                                    sum += (int)lastDigit;
                                    number /= 10;
                                }
                            }

                            if (sum % 2 != 0)
                            {
                                Console.WriteLine("no answer");
                            }
                            else
                            {
                                var seconds = TimeSpan.FromSeconds(sum);
                                string time = seconds.ToString(@"mm\:ss");
                                Console.WriteLine($"call ended. duration: {time}");
                            }
                        }
                    }      
                }

                if (input[0] == "message")
                {
                    for (int i = 0; i < phoneNumbers.Length; i++)
                    {
                        if (input[1] == phoneNumbers[i])
                        {
                            Console.WriteLine($"sending sms to {names[i]}...");

                            var sum = 0;
                            var numberString = phoneNumbers[i].Split(new[] { '+', '(', ')', '-' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                            for (int j = 0; j < numberString.Length; j++)
                            {
                                var number = long.Parse(numberString[j]);
                                while (number > 0)
                                {
                                    var lastDigit = number % 10;
                                    sum += (int)lastDigit;
                                    number /= 10;
                                }
                            }

                            if (sum % 2 != 0)
                            {
                                Console.WriteLine("busy");
                            }
                            else
                            {
                                Console.WriteLine("meet me there");
                            }
                        }
                        else if (input[1] == names[i])
                        {
                            Console.WriteLine($"sending sms to {phoneNumbers[i]}...");

                            var sum = 0L;
                            var numberString = phoneNumbers[i].Split(new[] { '+', '(', ')', '-' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                            for (int j = 0; j < numberString.Length; j++)
                            {
                                var number = long.Parse(numberString[j]);
                                while (number > 0)
                                {
                                    var lastDigit = number % 10;
                                    sum += (int)lastDigit;
                                    number /= 10;
                                }
                            }

                            if (sum % 2 != 0)
                            {
                                Console.WriteLine("busy");
                            }
                            else
                            {
                                Console.WriteLine("meet me there");
                            }
                        }
                    }
                }

                input = Console.ReadLine().Split(' ').ToArray();
            }
        }
    }
}
