using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics2
{
    public class Player
    {
        public string Name { get; set; }
        public int Number { get; set; }
    }

    public class FootballTeam : IEnumerable<Player>
    {
        private List<Player> players = new List<Player>();

        public void AddPlayer(Player player)
        {
            players.Add(player);
        }

        public IEnumerator<Player> GetEnumerator()
        {
            return players.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public class Programsq
    {
        public static void Main(string[] args)
        {
            FootballTeam team = new FootballTeam();
            team.AddPlayer(new Player { Name = "Neimar", Number = 10 });
            team.AddPlayer(new Player { Name = "Messi", Number = 7 });
            team.AddPlayer(new Player { Name = "Pele", Number = 4 });

            foreach (Player player in team)
            {
                Console.WriteLine("Name: " + player.Name + ", Number: " + player.Number);
            }
        }
    }
}
