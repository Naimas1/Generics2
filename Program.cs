using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics2
{
    public class CafeEmployee
    {
        public string Name { get; set; }
        public string Position { get; set; }
    }

    public class Cafe : IEnumerable<CafeEmployee>
    {
        private List<CafeEmployee> employees = new List<CafeEmployee>();

        public void AddEmployee(CafeEmployee employee)
        {
            employees.Add(employee);
        }

        public IEnumerator<CafeEmployee> GetEnumerator()
        {
            return employees.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public class Programx
    {
        public static void Main(string[] args)
        {
            Cafe cafe = new Cafe();
            cafe.AddEmployee(new CafeEmployee { Name = "John", Position = "Barista" });
            cafe.AddEmployee(new CafeEmployee { Name = "Emily", Position = "Waitress" });
            cafe.AddEmployee(new CafeEmployee { Name = "Mike", Position = "Chef" });

            foreach (CafeEmployee employee in cafe)
            {
                Console.WriteLine("Name: " + employee.Name + ", Position: " + employee.Position);
            }
        }
    }
}
