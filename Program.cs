using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics2
{
    class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }

        public Car(string brand, string model)
        {
            Brand = brand;
            Model = model;
        }
    }
    class Garage : IEnumerable<Car>
    {
        private List<Car> cars = new List<Car>();

        public void AddCar(Car car)
        {
            cars.Add(car);
        }

        public IEnumerator<Car> GetEnumerator()
        {
            return cars.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
    class Programist
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("BMW", "X5");
            Car car2 = new Car("Toyota", "Camry");
            Car car3 = new Car("Honda", "Civic");

            Garage garage = new Garage();

            garage.AddCar(car1);
            garage.AddCar(car2);
            garage.AddCar(car3);

            foreach (Car car in garage)
            {
                Console.WriteLine("Марка: {0}, Модель: {1}", car.Brand, car.Model);
            }
        }
    }
}
