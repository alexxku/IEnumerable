using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace IEnumerable_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("List collection...");
            List<string> cars = new List<string>();
            cars.Add("Ford");
            cars.Add("Toyota");
            cars.Add("Lexus");
            cars.Add("BMW");

            foreach(string car in cars)
            {
                Console.WriteLine(car);
            }

            Console.WriteLine("\nOur own collection...");

            Car c = new Car();
            c[0] = "Ford";
            c[1] = "Dodge";
            c[2] = "Mercedes";

            foreach(string car in c)
            {
                Console.WriteLine(car);
            }
        }

        public class Car : IEnumerable
        {
            string[] car = new string[3];

            public string this[int carNum]
            {
                get { return car[carNum]; }
                set { car[carNum] = value;  }
            }

            public IEnumerator GetEnumerator()
            {
                foreach(string c in car)
                {
                    yield return c;
                }
            }
            
        
        }
        
       
    }
}
