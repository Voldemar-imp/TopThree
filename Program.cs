using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopThree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Database database = new Database();
            int topNumber = 3;

            database.ShowLevelTop(topNumber);
            Console.WriteLine();
            database.ShowPowerTop(topNumber);            
        }
    }

    class Database
    {
        private List<Player> _players = new List<Player>(); 

        public Database()
        {
            _players.Add(new Player("Gordon", 10, 1500));
            _players.Add(new Player("Lillian", 70, 5600));
            _players.Add(new Player("Hernandez", 50, 7400));
            _players.Add(new Player("James", 53, 7600));
            _players.Add(new Player("Tiffany", 87, 7300));
            _players.Add(new Player("Jeremy", 84, 2300));
            _players.Add(new Player("Ernest", 55, 6500));
            _players.Add(new Player("Caroline", 34, 7800));
            _players.Add(new Player("Shawn", 97, 8900));
            _players.Add(new Player("King", 21, 5400));
        }

        public void ShowLevelTop(int topNumber)
        {
            Console.WriteLine("Топ-3 игроков по уровню");
            var sortedPlayers = _players.OrderByDescending(player => player.Level).Take(topNumber).ToList();
            ShowInfo (sortedPlayers);
        }

        public void ShowPowerTop(int topNumber)
        {
            Console.WriteLine("Топ-3 игроков по силе");
            var sortedPlayers = _players.OrderByDescending(player => player.Power).Take(topNumber).ToList();
            ShowInfo(sortedPlayers);
        }

        private void ShowInfo(List<Player> players)
        {
            foreach (Player player in players)
            {
                Console.WriteLine($"{player.Name}. Lvl: {player.Level}. Pwr: {player.Power}.");
            }
        }
    }

    class Player
    {
        public string Name { get; private set; }
        public int Level { get; private set; }
        public int Power { get; private set; }

        public Player(string name, int level, int power)
        {
            Name = name;
            Level = level;                
            Power = power;
        }
    }
}
