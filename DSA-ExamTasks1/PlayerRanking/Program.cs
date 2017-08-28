using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wintellect.PowerCollections;

namespace PlayerRanking
{
    public class Player : IComparable<Player>
    {
        public string Name { get; set; }
        public string PlayerType { get; set; }
        public int Age { get; set; }

        public Player(string name, string playerType, int age)
        {
            this.Name = name;
            this.PlayerType = playerType;
            this.Age = age;
        }

        public int CompareTo(Player other)
        {
            int result = this.Name.CompareTo(other.Name);
            if (result == 0)
            {
                result = this.Age.CompareTo(other.Age) * (-1);
            }

            return result;
        }

        public override string ToString()
        {
            return string.Format(
                "{0}({1})",
                this.Name,
                this.Age);
        }
    }


    public class Program
    {
        static void Main(string[] args)
        {
            BigList<Player> playerRanking = new BigList<Player>();
            Dictionary<string, OrderedSet<Player>> typeToPlayerMap =
                new Dictionary<string, OrderedSet<Player>>();

            string command;

            while ((command = Console.ReadLine()) != "end")
            {
                string[] commandParams = command.Split();

                switch (commandParams[0])
                {
                    case "add":
                        string name = commandParams[1];
                        string type = commandParams[2];
                        int age = int.Parse(commandParams[3]);
                        int possition = int.Parse(commandParams[4]) - 1;

                        Player player = new Player(name, type, age);

                        if (!typeToPlayerMap.ContainsKey(type))
                        {
                            typeToPlayerMap.Add(type, new OrderedSet<Player>());
                        }
                        typeToPlayerMap[type].Add(player);

                        playerRanking.Insert(possition, player);

                        Console.WriteLine(
                            "Added player {0} to position {1}",
                            player.Name,
                            possition + 1);

                        break;

                    case "find":
                        string foundType = commandParams[1];

                        if (typeToPlayerMap.ContainsKey(foundType))
                        {
                            var players = typeToPlayerMap[foundType];
                            string result =
                               string.Format("Type {0}: {1}",
                                foundType,
                                 string.Join("; ", players.Take(5)));
                            Console.WriteLine(result.TrimEnd(';', ' '));

                        }
                        else
                        {
                            Console.WriteLine("Type {0}: ", foundType);
                        }

                        break;

                    case "ranklist":

                        int rankingIndex = int.Parse(commandParams[1]) - 1;
                        int rankingCount = int.Parse(commandParams[2]) - int.Parse(commandParams[1]) + 1;

                        int playerPosition = int.Parse(commandParams[1]);

                        string rankingResults = string.Join("; ",
                            playerRanking.Range(rankingIndex, rankingCount).
                            Select(p => string.Format("{0}. {1}", playerPosition++, p)));

                        Console.WriteLine(rankingResults);

                        break;
                }
            }

        }
    }
}
