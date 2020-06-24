using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson14
{
    class Program
    {
        const int car_wheels = 4;
        const int start_running = 0;
        const int num_of_drivers = 1;
        const int motorcycle_wheels = 2;
        static void PrintCarArray(Vehice[] x)
        {
            for (int i = start_running; i < x.Length; i++)
            {
                if (x[i]._NumberOfWheels == car_wheels)
                {
                    Console.WriteLine(x[i]);
                }
            }
        }
        static void PrintVehicle(Vehice v)
        {
            Console.WriteLine("model: " + v._Model);
            Console.WriteLine(v);
        }
        static void Main(string[] args)
        {
            Car honda = new Car()
            {
                 _Model = "civic",
                 _NumberOfWheels = car_wheels,
                 _NumberOfTransmissions = 7,
                 _NumberOfDoors = 4,
                 _Driver = num_of_drivers,
                 _NearTheDriver = 1,
                 _Back = 3
            };

            Car seat = new Car()
            {
                 _Model = "ibiza",
                 _NumberOfWheels = car_wheels,
                 _NumberOfTransmissions = 6,
                 _NumberOfDoors = 2,
                 _Driver = num_of_drivers,
                 _NearTheDriver = 1,
                 _Back = 2
            };

            Motorcycle Honda = new Motorcycle()
            {
                 _Model = "crossrunner",
                 _NumberOfWheels = motorcycle_wheels,
                 _NumberOfTransmissions = 4,
                 _NumberOfHandBreaks = 2,
                 _Driver = num_of_drivers,
                 _Back = 1
            };

            Motorcycle kawasaki = new Motorcycle()
            {
                 _Model = "Z900",
                 _NumberOfWheels = motorcycle_wheels,
                 _NumberOfTransmissions = 6,
                 _NumberOfHandBreaks = 1,
                 _Driver = num_of_drivers,
                 _Back = 1
            };

            Vehice[] x = new Vehice[3];
            x[0] = honda;
            x[1] = seat;
            x[2] = kawasaki;

            Carrier c = new Carrier()
            {
                 _v = new Vehice[]
                 {
                     seat,
                     Honda
                 }
            };
            Console.WriteLine(honda);
            Console.WriteLine(seat);
            Console.WriteLine(Honda);
            Console.WriteLine(kawasaki);
            Console.WriteLine("-----------------------------------------------------------------------------");
            PrintVehicle(honda);
            Console.WriteLine("-----------------------------------------------------------------------------");
            Console.WriteLine(x[2]);
            Console.WriteLine("-----------------------------------------------------------------------------");
            PrintCarArray(x);
            Console.WriteLine("-----------------------------------------------------------------------------");
            Console.WriteLine(c._v[0]);
            Console.WriteLine("-----------------------------------------------------------------------------");
            Console.WriteLine(c);
        }
    }
}
