using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Car[] garage = { new Car("Myvi"), new Car("Honda"), new Car("Axia") };

            foreach (Car car in garage)
            {
                Console.WriteLine(car.model);
            }

            /*Car[] garage = new Car[3];

            Car car1 = new Car("Myvi");
            Car car2 = new Car("Honda");
            Car car3 = new Car("Axia");

            garage[0] = car1;
            garage[1] = car2;
            garage[2] = car3*/;

           

            /*Console.WriteLine(garage[0].model);
            Console.WriteLine(garage[1].model);
            Console.WriteLine(garage[2].model);*/

            Console.ReadKey();

        }

    }
  
     class Car
    {
        public String model;

        public Car (String model)
        {
            this.model = model;
        }
    }

   



}







