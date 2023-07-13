using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics2
{
    public class MarineCreature
    {
        public string Name { get; set; }

        public MarineCreature(string name)
        {
            Name = name;
        }
    }
    public class Oceanarium : IEnumerable<MarineCreature>
    {
        private List<MarineCreature> inhabitants;

        public Oceanarium()
        {
            inhabitants = new List<MarineCreature>();
        }
        public void AddInhabitant(MarineCreature creature)
        {
            inhabitants.Add(creature);
        }
        public IEnumerator<MarineCreature> GetEnumerator()
        {
            return inhabitants.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
    public class Programc
    {
        public static void Main(string[] args)
        {
            Oceanarium oceanarium = new Oceanarium();

            oceanarium.AddInhabitant(new MarineCreature("Дельфін"));
            oceanarium.AddInhabitant(new MarineCreature("Акула"));
            oceanarium.AddInhabitant(new MarineCreature("Кит"));

            foreach (MarineCreature creature in oceanarium)
            {
                Console.WriteLine(creature.Name);
            }
        }
    }
}
