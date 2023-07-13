using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics2
{
    public class Apartment
    {
        public string ApartmentNumber { get; set; }
        public List<string> Residents { get; set; }

        public Apartment(string apartmentNumber, List<string> residents)
        {
            ApartmentNumber = apartmentNumber;
            Residents = residents;
        }
    }

    public class House : IEnumerable<Apartment>
    {
        private List<Apartment> apartments;

        public House()
        {
            apartments = new List<Apartment>();
        }

        public void AddApartment(Apartment apartment)
        {
            apartments.Add(apartment);
        }

        public IEnumerator<Apartment> GetEnumerator()
        {
            return apartments.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public class Programb
    {
        public static void Main(string[] args)
        {
            House house = new House();

            List<string> residents1 = new List<string> { "John", "Emily" };
            Apartment apartment1 = new Apartment("42", residents1);
            house.AddApartment(apartment1);

            List<string> residents2 = new List<string> { "Tom", "Lisa", "Mike" };
            Apartment apartment2 = new Apartment("36", residents2);
            house.AddApartment(apartment2);

            foreach (Apartment apartment in house)
            {
                Console.WriteLine("Apartment: " + apartment.ApartmentNumber);
                Console.WriteLine("Residents: " + string.Join(", ", apartment.Residents));
                Console.WriteLine();
            }
        }
    }
}
