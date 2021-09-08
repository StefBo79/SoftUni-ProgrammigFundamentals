using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem3
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> userSent = new Dictionary<string, int>();
            Dictionary<string, int> userReceived = new Dictionary<string, int>();

            int capacity = int.Parse(Console.ReadLine());

            string command = Console.ReadLine();
            while (command != "Statistics")
            {
                string[] commandArgs = command.Split("=");
                string action = commandArgs[0];

                if (action == "Add")
                {
                    string username = commandArgs[1];
                    int sent = int.Parse(commandArgs[2]);
                    int received = int.Parse(commandArgs[3]);

                    if (!userSent.ContainsKey(username))
                    {
                        userSent.Add(username, sent);
                        userReceived.Add(username, received);
                    }
                    else
                    {
                        command = Console.ReadLine();
                        continue;
                    }                    
                }

                if (action == "Message")
                {
                    string sender = commandArgs[1];
                    string receiver = commandArgs[2];

                    if (userSent.ContainsKey(sender) && userReceived.ContainsKey(receiver))
                    {
                        userSent[sender] += 1;
                        userReceived[receiver] += 1;

                        if (userSent[sender] >= capacity || userReceived[sender] >= capacity || userSent[sender] + userReceived[sender] >= capacity)
                        {
                            Console.WriteLine($"{sender} reached the capacity!");
                            userSent.Remove(sender);
                            userReceived.Remove(sender);
                        }

                        if (userReceived[receiver] >= capacity || userSent[receiver] >= capacity || userSent[receiver] + userReceived[receiver] >= capacity)
                        {
                            Console.WriteLine($"{receiver} reached the capacity!");
                            userSent.Remove(receiver);
                            userReceived.Remove(receiver);
                        }                        
                    }
                }

                if (action == "Empty")
                {
                    string username = commandArgs[1];
                    if (userSent.ContainsKey(username))
                    {
                        userSent.Remove(username);
                        userReceived.Remove(username);
                    }
                    else if (username == "All")
                    {
                        userSent = new Dictionary<string, int>();
                        userReceived = new Dictionary<string, int>();
                    }                                       
                }

                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join("", $"Users count: {userSent.Count}"));

            userSent = userSent
                .OrderByDescending(u => userReceived[u.Key])
                .ThenBy(u => u.Key)
                .ToDictionary(u => u.Key, u => u.Value);


            foreach (var user in userSent)
            {
                Console.WriteLine($"{user.Key} - {user.Value + userReceived[user.Key]}");

            }
        }
    }
}