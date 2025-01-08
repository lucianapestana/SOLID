using System;
using Isp.Vehicles;

namespace Isp
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("Roxo", 2025, 2.0, 7, 2);
            Motorcycle motorcycle = new Motorcycle("Branca", 2025, 750);

            Console.ReadLine();
        }
    }
}
